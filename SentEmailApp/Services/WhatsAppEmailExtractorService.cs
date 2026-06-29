using System.Text.RegularExpressions;

namespace SentEmailApp.Services;

public sealed class WhatsAppEmailExtractorService
{
    private static readonly Regex EmailRegex = new(
        @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}",
        RegexOptions.Compiled | RegexOptions.CultureInvariant);

    public List<string> ExtractEmailsFromFile(string filePath, bool removeDuplicates)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        var content = File.ReadAllText(filePath);
        return ExtractEmailsFromText(content, removeDuplicates);
    }

    public async Task<List<string>> ExtractEmailsFromFileAsync(
        string filePath,
        bool removeDuplicates,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        var content = await File.ReadAllTextAsync(filePath, cancellationToken).ConfigureAwait(false);
        return ExtractEmailsFromText(content, removeDuplicates);
    }

    private static List<string> ExtractEmailsFromText(string content, bool removeDuplicates)
    {
        var emails = new List<string>();

        foreach (Match match in EmailRegex.Matches(content))
        {
            var normalized = NormalizeEmail(match.Value);
            if (!string.IsNullOrWhiteSpace(normalized))
                emails.Add(normalized);
        }

        if (!removeDuplicates)
            return emails;

        return emails
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private static string NormalizeEmail(string raw)
    {
        var email = raw.Trim();

        if (email.StartsWith('<') && email.EndsWith('>'))
            email = email[1..^1].Trim();

        return email.ToLowerInvariant();
    }
}
