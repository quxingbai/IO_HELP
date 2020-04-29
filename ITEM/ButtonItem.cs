using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM
{
    public class ButtonItem:SuperItem
    {
        public ButtonItem()
        {
            TextStyle = TextStyle_Enum.Center;
        }
        Boolean Mouse_Down = false;
        public Boolean OpenMouseDownBorderColor { get; set; } = true;
        public Color MouseDownBorderColor { get; set; } = Color.Black;
        public Color MouseUpBorderColor { get; set; } = Color.Black;

        public Boolean OpenMouseDownBackColor { get; set; } = true;
        public Color MouseDownBackColor { get; set; } = Color.Silver;
        public Color MouseUpBackColor { get; set; } = Color.Empty;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Mouse_Down = true;
            Invalidate();
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Mouse_Down = false;
            Invalidate();
            base.OnMouseUp(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (OpenMouseDownBorderColor)
            {
                Pen BorderPen = new Pen(Mouse_Down ? MouseDownBorderColor : MouseUpBorderColor, Border_Size);
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width, Height);
                BorderPen.Dispose();
            }
            if (OpenMouseDownBackColor)
            {
                this.BackColor = Mouse_Down ? MouseDownBackColor : MouseUpBackColor;
            }
            base.OnPaint(e);
        }

    }
}
