namespace SentEmailApp.Models;

public sealed class EmailMessage
{
    public required string Subject { get; init; }
    public required string Body { get; init; }
    public IReadOnlyList<string> To { get; init; } = [];
    public IReadOnlyList<string> Cc { get; init; } = [];
    public IReadOnlyList<string> Bcc { get; init; } = [];
    public IReadOnlyList<string> AttachmentPaths { get; init; } = [];
}
