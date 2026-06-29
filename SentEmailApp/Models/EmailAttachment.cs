using SentEmailApp.Helpers;

namespace SentEmailApp.Models;

public sealed class EmailAttachment
{
    public required string FilePath { get; init; }

    public string FileName => Path.GetFileName(FilePath);

    public long SizeBytes { get; init; }

    public string FormattedSize => FileSizeFormatter.Format(SizeBytes);

    public static EmailAttachment FromPath(string filePath)
    {
        var info = new FileInfo(filePath);
        return new EmailAttachment
        {
            FilePath = info.FullName,
            SizeBytes = info.Exists ? info.Length : 0
        };
    }
}
