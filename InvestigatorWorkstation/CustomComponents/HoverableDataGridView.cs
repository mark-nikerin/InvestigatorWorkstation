using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvestigatorWorkstation.CustomComponents
{
    public class HoverableDataGridView : DataGridView
    {
        public HoverableDataGridView() { DoubleBuffered = true; }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            if (RectangleToScreen(e.RowBounds).Contains(MousePosition))
            {
                using var b = new SolidBrush(Color.FromArgb(50, Color.DarkGray));
                using var p = new Pen(Color.FromArgb(50, Color.DarkGray));
                var r = e.RowBounds;
                r.Width--;
                r.Height--;
                e.Graphics.FillRectangle(b, r);
                e.Graphics.DrawRectangle(p, r);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e); 
            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e); 
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e); 
            Invalidate();
        }
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e); 
            Invalidate();
        }
    }
}
