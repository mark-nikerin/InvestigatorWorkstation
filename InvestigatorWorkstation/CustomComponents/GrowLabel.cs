using System;
using System.Drawing;
using System.Windows.Forms;

public class GrowLabel : Label
{
    private bool mGrowing;
    public GrowLabel()
    {
        AutoSize = false;
    }

    private void ResizeLabel()
    {
        if (mGrowing) return;
        try
        {
            mGrowing = true;
            var sz = new Size(Width, int.MaxValue);
            sz = TextRenderer.MeasureText(Text, Font, sz, TextFormatFlags.WordBreak);
            Height = sz.Height;
        }
        finally
        {
            mGrowing = false;
        }
    }
    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        ResizeLabel();
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        ResizeLabel();
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        ResizeLabel();
    }
}