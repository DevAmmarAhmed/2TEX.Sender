using System.Drawing.Drawing2D;

namespace SentEmailApp.Controls;

internal sealed class ModernButton : Button
{
    private bool _isHovered;
    private bool _isPressed;

    public ModernButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = UiTheme.Primary;
        ForeColor = Color.White;
        Font = UiTheme.ButtonFont;
        Cursor = Cursors.Hand;
        Height = 40;
        MinimumSize = new Size(140, 40);
        Padding = new Padding(20, 0, 20, 0);
        TabStop = true;
        UseVisualStyleBackColor = false;

        MouseEnter += (_, _) => { _isHovered = true; Invalidate(); };
        MouseLeave += (_, _) => { _isHovered = false; _isPressed = false; Invalidate(); };
        MouseDown += (_, e) =>
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPressed = true;
                Invalidate();
            }
        };
        MouseUp += (_, _) => { _isPressed = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        var background = Enabled
            ? _isPressed ? UiTheme.PrimaryPressed : _isHovered ? UiTheme.PrimaryHover : UiTheme.Primary
            : Color.FromArgb(191, 219, 254);

        var bounds = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedRectangle(bounds, 8);
        using var brush = new SolidBrush(background);
        pevent.Graphics.FillPath(brush, path);

        var textColor = Enabled ? ForeColor : Color.FromArgb(219, 234, 254);
        TextRenderer.DrawText(
            pevent.Graphics,
            Text,
            Font,
            bounds,
            textColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
    {
        var path = new GraphicsPath();
        var diameter = radius * 2;
        var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

        path.AddArc(arc, 180, 90);
        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90);
        arc.Y = bounds.Bottom - diameter;
        path.AddArc(arc, 0, 90);
        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);
        path.CloseFigure();
        return path;
    }
}
