using System.Net.Mail;
using SentEmailApp.Controls;
using SentEmailApp.Helpers;
using SentEmailApp.Models;
using SentEmailApp.Services;

namespace SentEmailApp;

public partial class Form1 : Form
{
    private const int TwoColumnBreakpoint = 900;
    private const int CompactHeightBreakpoint = 680;

    private readonly EmailService _emailService = new();

    public Form1()
    {
        InitializeComponent();
        InitializeAttachments();
        InitializeWhatsAppImport();
        WireValidationClearHandlers();
        Load += (_, _) => AdjustResponsiveLayout();
        Resize += (_, _) => AdjustResponsiveLayout();
    }

    private void AdjustResponsiveLayout()
    {
        var wide = ClientSize.Width >= TwoColumnBreakpoint;

        layoutContent.SuspendLayout();
        panelMain.SuspendLayout();

        layoutContent.Controls.Clear();
        layoutContent.ColumnStyles.Clear();
        layoutContent.RowStyles.Clear();

        if (wide)
        {
            layoutContent.ColumnCount = 2;
            layoutContent.RowCount = 1;
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            cardSmtp.Margin = new Padding(0, 0, 6, 0);
            cardMessage.Margin = new Padding(6, 0, 0, 0);

            layoutContent.Controls.Add(cardSmtp, 0, 0);
            layoutContent.Controls.Add(cardMessage, 1, 0);
        }
        else
        {
            layoutContent.ColumnCount = 1;
            layoutContent.RowCount = 2;
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));

            cardSmtp.Margin = new Padding(0, 0, 0, 8);
            cardMessage.Margin = new Padding(0);

            layoutContent.Controls.Add(cardSmtp, 0, 0);
            layoutContent.Controls.Add(cardMessage, 0, 1);
        }

        panelMain.AutoScroll = !wide && ClientSize.Height < CompactHeightBreakpoint;

        layoutContent.ResumeLayout(true);
        panelMain.ResumeLayout(true);
    }

    private void WireValidationClearHandlers()
    {
        txtSmtpServer.TextChanged += (_, _) => ClearFieldError(lblErrSmtpServer);
        numPort.ValueChanged += (_, _) => ClearFieldError(lblErrPort);
        txtSenderEmail.TextChanged += (_, _) => ClearFieldError(lblErrSenderEmail);
        txtPassword.TextChanged += (_, _) => ClearFieldError(lblErrPassword);
        txtRecipients.TextChanged += (_, _) => ClearFieldError(lblErrRecipients);
        txtSubject.TextChanged += (_, _) => ClearFieldError(lblErrSubject);
        txtBody.TextChanged += (_, _) => ClearFieldError(lblErrBody);
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        if (!TryBuildRequest(out var settings, out var email, out var error))
        {
            statusBanner.SetStatus(StatusKind.Error, error);
            return;
        }

        await SendEmailAsync(settings, email);
    }

    private bool TryBuildRequest(
        out SmtpSettings settings,
        out EmailMessage email,
        out string error)
    {
        settings = null!;
        email = null!;
        var recipients = (IReadOnlyList<string>)[];
        var subject = string.Empty;
        var body = string.Empty;
        error = string.Empty;

        ClearAllFieldErrors();
        var isValid = true;

        if (string.IsNullOrWhiteSpace(txtSmtpServer.Text))
        {
            SetFieldError(lblErrSmtpServer, "SMTP Server is required.");
            txtSmtpServer.Focus();
            isValid = false;
        }

        if (numPort.Value < 1 || numPort.Value > 65535)
        {
            SetFieldError(lblErrPort, "Port must be between 1 and 65535.");
            if (isValid) numPort.Focus();
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtSenderEmail.Text))
        {
            SetFieldError(lblErrSenderEmail, "Sender Email is required.");
            if (isValid) txtSenderEmail.Focus();
            isValid = false;
        }
        else if (!IsValidEmail(txtSenderEmail.Text.Trim()))
        {
            SetFieldError(lblErrSenderEmail, "Enter a valid sender email address.");
            if (isValid) txtSenderEmail.Focus();
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            SetFieldError(lblErrPassword, "Password or App Password is required.");
            if (isValid) txtPassword.Focus();
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtRecipients.Text))
        {
            SetFieldError(lblErrRecipients, "At least one recipient is required.");
            if (isValid) txtRecipients.Focus();
            isValid = false;
        }
        else
        {
            recipients = RecipientParser.Parse(txtRecipients.Text);
            if (recipients.Count == 0)
            {
                SetFieldError(lblErrRecipients, "At least one valid recipient is required.");
                if (isValid) txtRecipients.Focus();
                isValid = false;
            }
            else
            {
                foreach (var recipient in recipients)
                {
                    if (!IsValidEmail(recipient))
                    {
                        SetFieldError(lblErrRecipients, $"Invalid email address: {recipient}");
                        if (isValid) txtRecipients.Focus();
                        isValid = false;
                        break;
                    }
                }
            }
        }

        if (string.IsNullOrWhiteSpace(txtSubject.Text))
        {
            SetFieldError(lblErrSubject, "Subject is required.");
            if (isValid) txtSubject.Focus();
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(txtBody.Text))
        {
            SetFieldError(lblErrBody, "Email body is required.");
            if (isValid) txtBody.Focus();
            isValid = false;
        }

        if (!isValid)
        {
            error = "Please fix the highlighted fields.";
            return false;
        }

        if (!TryValidateAttachments(out error))
            return false;

        settings = new SmtpSettings
        {
            Server = txtSmtpServer.Text.Trim(),
            Port = (int)numPort.Value,
            SenderEmail = txtSenderEmail.Text.Trim(),
            Password = txtPassword.Text,
            UseSslTls = chkUseSslTls.Checked
        };

        subject = txtSubject.Text.Trim();
        body = txtBody.Text;
        email = new EmailMessage
        {
            Subject = subject,
            Body = body,
            To = recipients,
            AttachmentPaths = GetAttachmentPaths()
        };
        return true;
    }

    private async Task SendEmailAsync(SmtpSettings settings, EmailMessage email)
    {
        ToggleSendingState(true);
        var attachmentCount = email.AttachmentPaths.Count;
        statusBanner.SetStatus(
            StatusKind.Sending,
            attachmentCount > 0
                ? $"Sending email with {attachmentCount} attachment(s)..."
                : "Sending email to recipients...");

        try
        {
            await _emailService.SendAsync(settings, email);
            var attachmentText = attachmentCount > 0
                ? $" with {attachmentCount} attachment(s)"
                : string.Empty;
            statusBanner.SetStatus(
                StatusKind.Success,
                $"Success — email sent to {email.To.Count} recipient(s){attachmentText}.");
        }
        catch (Exception ex)
        {
            var message = ex.InnerException?.Message ?? ex.Message;
            statusBanner.SetStatus(StatusKind.Error, $"Failed — {message}");
        }
        finally
        {
            ToggleSendingState(false);
        }
    }

    private void ToggleSendingState(bool isSending)
    {
        btnSend.Enabled = !isSending;
        btnSend.Text = isSending ? "Sending..." : "Send Email";
        UseWaitCursor = isSending;
    }

    private static void SetFieldError(Label errorLabel, string message)
    {
        errorLabel.Text = message;
        errorLabel.Visible = true;
    }

    private static void ClearFieldError(Label errorLabel)
    {
        errorLabel.Text = string.Empty;
        errorLabel.Visible = false;
    }

    private void ClearAllFieldErrors()
    {
        ClearFieldError(lblErrSmtpServer);
        ClearFieldError(lblErrPort);
        ClearFieldError(lblErrSenderEmail);
        ClearFieldError(lblErrPassword);
        ClearFieldError(lblErrRecipients);
        ClearFieldError(lblErrSubject);
        ClearFieldError(lblErrBody);
        ClearFieldError(lblErrAttachments);
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            _ = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
