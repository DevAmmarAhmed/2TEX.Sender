using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using SentEmailApp.Models;

namespace SentEmailApp.Services;

/// <summary>
/// Sends email via SMTP using MailKit (replaces the deprecated System.Net.Mail.SmtpClient).
/// </summary>
public sealed class EmailService
{
  /*
   * Gmail SMTP example:
   *   Server: smtp.gmail.com
   *   Port:   587
   *   SSL/TLS: enabled (STARTTLS)
   *
   * Gmail no longer accepts your regular account password for SMTP.
   * Use an App Password instead:
   *   1. Enable 2-Step Verification on your Google account.
   *   2. Open https://myaccount.google.com/apppasswords
   *   3. Create an app password for "Mail" on "Windows Computer".
   *   4. Paste the 16-character password into the Sender Password field.
   *
   * Other providers (Outlook, Yahoo, etc.) publish their own SMTP host, port,
   * and TLS requirements in their help documentation.
   */

  public async Task SendAsync(
    SmtpSettings settings,
    string subject,
    string body,
    IEnumerable<string> recipients,
    CancellationToken cancellationToken = default)
  {
    ArgumentNullException.ThrowIfNull(settings);
    ArgumentException.ThrowIfNullOrWhiteSpace(subject);
    ArgumentException.ThrowIfNullOrWhiteSpace(body);

    var recipientList = recipients.ToList();
    if (recipientList.Count == 0)
      throw new ArgumentException("At least one recipient is required.", nameof(recipients));

    var message = new MimeMessage();
    message.From.Add(MailboxAddress.Parse(settings.SenderEmail));

    foreach (var recipient in recipientList)
      message.To.Add(MailboxAddress.Parse(recipient));

    message.Subject = subject;
    message.Body = new TextPart("plain") { Text = body };

    var secureSocketOptions = settings.UseSslTls
      ? (settings.Port == 465 ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls)
      : SecureSocketOptions.None;

    using var client = new SmtpClient();
    await client.ConnectAsync(settings.Server, settings.Port, secureSocketOptions, cancellationToken)
      .ConfigureAwait(false);
    await client.AuthenticateAsync(settings.SenderEmail, settings.Password, cancellationToken)
      .ConfigureAwait(false);
    await client.SendAsync(message, cancellationToken).ConfigureAwait(false);
    await client.DisconnectAsync(true, cancellationToken).ConfigureAwait(false);
  }
}
