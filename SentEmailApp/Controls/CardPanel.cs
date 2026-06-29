using System.Drawing.Drawing2D;

namespace SentEmailApp.Controls;

internal sealed class CardPanel : Panel
{
    public CardPanel()
    {
        BackColor = UiTheme.CardBackground;
        Padding = new Padding(14, 12, 14, 12);
        Margin = new Padding(0);
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        var bounds = new Rectangle(0, 0, Width - 1, Height - 1);
        var shadowBounds = new Rectangle(bounds.X + 1, bounds.Y + 2, bounds.Width, bounds.Height);

        using var shadowPath = CreateRoundedRectangle(shadowBounds, UiTheme.CornerRadius);
        using var shadowBrush = new SolidBrush(Color.FromArgb(18, 0, 0, 0));
        graphics.FillPath(shadowBrush, shadowPath);

        using var cardPath = CreateRoundedRectangle(bounds, UiTheme.CornerRadius);
        using var borderPen = new Pen(UiTheme.CardBorder);
        graphics.FillPath(Brushes.White, cardPath);
        graphics.DrawPath(borderPen, cardPath);
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
