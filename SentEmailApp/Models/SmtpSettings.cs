namespace SentEmailApp.Models;

/// <summary>
/// SMTP connection settings entered by the user at runtime.
/// Credentials are never stored in code — fill these in on the form.
/// </summary>
public sealed class SmtpSettings
{
    public required string Server { get; init; }
    public required int Port { get; init; }
    public required string SenderEmail { get; init; }
    public required string Password { get; init; }
    public bool UseSslTls { get; init; } = true;
}
