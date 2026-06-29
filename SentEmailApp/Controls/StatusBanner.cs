namespace SentEmailApp.Controls;

internal enum StatusKind
{
    None,
    Sending,
    Success,
    Error
}

internal sealed class StatusBanner : Panel
{
    private readonly Label _iconLabel;
    private readonly Label _messageLabel;

    public StatusBanner()
    {
        Height = 44;
        Padding = new Padding(12, 8, 12, 8);
        Margin = new Padding(0);
        BackColor = UiTheme.InfoBackground;
        DoubleBuffered = true;

        _iconLabel = new Label
        {
            AutoSize = false,
            Size = new Size(24, 24),
            Location = new Point(12, 8),
            Font = UiTheme.StatusIconFont,
            ForeColor = UiTheme.Primary,
            TextAlign = ContentAlignment.MiddleCenter
        };

        _messageLabel = new Label
        {
            AutoSize = false,
            Location = new Point(40, 8),
            Height = 28,
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            Font = UiTheme.BodyFont,
            ForeColor = UiTheme.TextPrimary,
            Text = "Ready to send.",
            TextAlign = ContentAlignment.MiddleLeft
        };

        Controls.Add(_iconLabel);
        Controls.Add(_messageLabel);
        Resize += (_, _) => _messageLabel.Width = Math.Max(0, Width - 52);
        SetStatus(StatusKind.None, "Ready to send.");
    }

    public void SetStatus(StatusKind kind, string message)
    {
        _messageLabel.Text = message;

        switch (kind)
        {
            case StatusKind.Sending:
                BackColor = UiTheme.InfoBackground;
                _iconLabel.ForeColor = UiTheme.Primary;
                _iconLabel.Text = "\uE895";
                _messageLabel.ForeColor = UiTheme.TextPrimary;
                break;
            case StatusKind.Success:
                BackColor = UiTheme.SuccessBackground;
                _iconLabel.ForeColor = UiTheme.Success;
                _iconLabel.Text = "\uE73E";
                _messageLabel.ForeColor = UiTheme.Success;
                break;
            case StatusKind.Error:
                BackColor = UiTheme.ErrorBackground;
                _iconLabel.ForeColor = UiTheme.Error;
                _iconLabel.Text = "\uE783";
                _messageLabel.ForeColor = UiTheme.Error;
                break;
            default:
                BackColor = Color.FromArgb(249, 250, 251);
                _iconLabel.ForeColor = UiTheme.TextMuted;
                _iconLabel.Text = "\uE715";
                _messageLabel.ForeColor = UiTheme.TextSecondary;
                break;
        }

        Invalidate();
    }
}
