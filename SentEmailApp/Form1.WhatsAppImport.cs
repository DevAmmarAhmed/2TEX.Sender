using SentEmailApp.Controls;
using SentEmailApp.Helpers;
using SentEmailApp.Services;

namespace SentEmailApp;

public partial class Form1
{
    private readonly WhatsAppEmailExtractorService _whatsAppEmailExtractor = new();

    private void InitializeWhatsAppImport()
    {
        lblWhatsAppFileName.Text = "No file selected";
        lblWhatsAppEmailCount.Text = "0 emails extracted";
        chkWhatsAppRemoveDuplicates.Checked = true;

        btnImportWhatsApp.Click += BtnImportWhatsApp_Click;
        panelWhatsAppStatus.Resize += (_, _) =>
        {
            lblWhatsAppEmailCount.Width = 230;
            lblWhatsAppFileName.Width = Math.Max(120, panelWhatsAppStatus.Width - lblWhatsAppEmailCount.Width - 8);
        };
    }

    private async void BtnImportWhatsApp_Click(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Title = "Select WhatsApp Exported Chat File",
            Filter = "Text files (*.txt)|*.txt",
            Multiselect = false
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        await ImportWhatsAppChatAsync(dialog.FileName);
    }

    private async Task ImportWhatsAppChatAsync(string filePath)
    {
        ToggleWhatsAppImportState(true);
        ClearFieldError(lblErrRecipients);

        try
        {
            statusBanner.SetStatus(StatusKind.Sending, "Reading WhatsApp chat...");
            await Task.Yield();

            statusBanner.SetStatus(StatusKind.Sending, "Extracting emails...");
            var removeDuplicates = chkWhatsAppRemoveDuplicates.Checked;
            var extractedEmails = await _whatsAppEmailExtractor
                .ExtractEmailsFromFileAsync(filePath, removeDuplicates);

            lblWhatsAppFileName.Text = Path.GetFileName(filePath);

            if (extractedEmails.Count == 0)
            {
                lblWhatsAppEmailCount.Text = "0 emails extracted";
                statusBanner.SetStatus(
                    StatusKind.Error,
                    "No email addresses found in this WhatsApp chat file.");
                return;
            }

            var recipients = BuildRecipientList(extractedEmails, removeDuplicates);
            txtRecipients.Text = string.Join(Environment.NewLine, recipients);
            lblWhatsAppEmailCount.Text = $"{recipients.Count} email(s) extracted";
            statusBanner.SetStatus(StatusKind.Success, "Emails imported successfully.");
        }
        catch (Exception ex)
        {
            lblWhatsAppEmailCount.Text = "0 emails extracted";
            statusBanner.SetStatus(
                StatusKind.Error,
                $"Failed to read WhatsApp chat file — {ex.Message}");
        }
        finally
        {
            ToggleWhatsAppImportState(false);
        }
    }

    private List<string> BuildRecipientList(IReadOnlyList<string> extractedEmails, bool removeDuplicates)
    {
        var recipients = chkWhatsAppAppendRecipients.Checked
            ? RecipientParser.Parse(txtRecipients.Text).ToList()
            : [];

        recipients.AddRange(extractedEmails);

        if (!removeDuplicates)
            return recipients;

        return recipients
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private void ToggleWhatsAppImportState(bool isImporting)
    {
        btnImportWhatsApp.Enabled = !isImporting;
        btnImportWhatsApp.Text = isImporting ? "Importing..." : "Import WhatsApp Chat";
        UseWaitCursor = isImporting;
    }
}
