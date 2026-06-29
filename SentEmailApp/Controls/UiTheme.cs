namespace SentEmailApp.Controls;

internal static class UiTheme
{
    public static readonly Color PageBackground = Color.FromArgb(243, 244, 246);
    public static readonly Color CardBackground = Color.White;
    public static readonly Color CardBorder = Color.FromArgb(229, 231, 235);
    public static readonly Color Primary = Color.FromArgb(37, 99, 235);
    public static readonly Color PrimaryHover = Color.FromArgb(29, 78, 216);
    public static readonly Color PrimaryPressed = Color.FromArgb(30, 64, 175);
    public static readonly Color TextPrimary = Color.FromArgb(17, 24, 39);
    public static readonly Color TextSecondary = Color.FromArgb(107, 114, 128);
    public static readonly Color TextMuted = Color.FromArgb(156, 163, 175);
    public static readonly Color Error = Color.FromArgb(220, 38, 38);
    public static readonly Color Success = Color.FromArgb(22, 163, 74);
    public static readonly Color SuccessBackground = Color.FromArgb(240, 253, 244);
    public static readonly Color ErrorBackground = Color.FromArgb(254, 242, 242);
    public static readonly Color InfoBackground = Color.FromArgb(239, 246, 255);
    public static readonly Color InputBorder = Color.FromArgb(209, 213, 219);
    public static readonly Color InputBackground = Color.White;

    public const int CornerRadius = 8;
    public const int InputHeight = 32;
    public const int Spacing = 10;
    public const int FieldRowHeight = 54;
    public const int SectionHeaderHeight = 26;

    public static Font TitleFont => new("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
    public static Font SubtitleFont => new("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
    public static Font SectionFont => new("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
    public static Font LabelFont => new("Segoe UI Semibold", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
    public static Font BodyFont => new("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
    public static Font HintFont => new("Segoe UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
    public static Font ButtonFont => new("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
    public static Font IconFont => new("Segoe MDL2 Assets", 14F, FontStyle.Regular, GraphicsUnit.Point);
    public static Font StatusIconFont => new("Segoe MDL2 Assets", 16F, FontStyle.Regular, GraphicsUnit.Point);

    public static void StyleInput(TextBox textBox, bool multiline = false)
    {
        textBox.Font = BodyFont;
        textBox.BorderStyle = BorderStyle.FixedSingle;
        textBox.BackColor = InputBackground;
        textBox.ForeColor = TextPrimary;

        if (!multiline)
        {
            textBox.Height = InputHeight;
            textBox.Margin = new Padding(0, 2, 0, 0);
        }
        else
        {
            textBox.Margin = new Padding(0, 2, 0, 0);
            textBox.ScrollBars = ScrollBars.Vertical;
        }
    }

    public static void StyleFieldLabel(Label label)
    {
        label.Font = LabelFont;
        label.ForeColor = TextSecondary;
        label.AutoSize = true;
        label.Margin = new Padding(0, 0, 0, 2);
    }

    public static void StyleErrorLabel(Label label)
    {
        label.Font = HintFont;
        label.ForeColor = Error;
        label.AutoSize = true;
        label.Margin = new Padding(0, 2, 0, 0);
        label.Visible = false;
    }

    public static void StyleSecondaryButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = UiTheme.HintFont;
        button.ForeColor = UiTheme.TextSecondary;
        button.BackColor = Color.FromArgb(249, 250, 251);
        button.FlatAppearance.BorderColor = UiTheme.InputBorder;
        button.FlatAppearance.BorderSize = 1;
        button.Height = 28;
        button.Padding = new Padding(8, 0, 8, 0);
        button.Cursor = Cursors.Hand;
    }
}
