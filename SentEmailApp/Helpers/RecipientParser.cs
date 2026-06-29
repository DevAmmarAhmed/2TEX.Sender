namespace SentEmailApp.Helpers;

public static class RecipientParser
{
  /// <summary>
  /// Splits a recipient list by comma, semicolon, or new line.
  /// Trims whitespace and removes duplicates (case-insensitive).
  /// </summary>
  public static IReadOnlyList<string> Parse(string input)
  {
    return input
      .Split([',', ';', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries)
      .Select(r => r.Trim())
      .Where(r => !string.IsNullOrWhiteSpace(r))
      .Distinct(StringComparer.OrdinalIgnoreCase)
      .ToList();
  }
}
