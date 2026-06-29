using SentEmailApp.Models;

namespace SentEmailApp.Helpers;

public sealed class AttachmentCollection
{
    private readonly List<EmailAttachment> _items = [];

    public IReadOnlyList<EmailAttachment> Items => _items;

    public int AddFiles(IEnumerable<string> filePaths)
    {
        var added = 0;

        foreach (var filePath in filePaths)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                continue;

            var fullPath = Path.GetFullPath(filePath);
            if (_items.Any(item => string.Equals(item.FilePath, fullPath, StringComparison.OrdinalIgnoreCase)))
                continue;

            if (!File.Exists(fullPath))
                continue;

            _items.Add(EmailAttachment.FromPath(fullPath));
            added++;
        }

        return added;
    }

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < _items.Count)
            _items.RemoveAt(index);
    }

    public void Clear() => _items.Clear();

    public IReadOnlyList<EmailAttachment> GetMissingFiles() =>
        _items.Where(item => !File.Exists(item.FilePath)).ToList();
}
