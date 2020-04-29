using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ITEM
{
    public class SuperItem : Control
    {
        public enum TextStyle_Enum
        {
            Left=1,
            Center=2,
            Right=3
        }
        public Boolean Mouse_Enter = false;

        public float Border_Size { get; set; } = 2;
        public Color Enter_Border_Color { get; set; } = Color.Yellow;
        public Color Out_Border_Color { get; set; } = Color.Black;
        public Color Enter_Fore_Color { get; set; } = Color.Black;
        public Color Enter_Back_Color { get; set; } = Color.Black;

        public TextStyle_Enum TextStyle { get; set; } = TextStyle_Enum.Left;

        //控制自创组件
        public Boolean Border_Open { get; set; } = true;
        public Boolean Text_Open { get; set; } = true;

        //控制重写的方法
        public Boolean OnMouseEnter_Open { get; set; } = true;
        public Boolean OnMouseLeave_Open { get; set; } = true;

        public SuperItem()
        {
            ForeColor = ForeColor == Color.FromArgb(255,0,0,0) ? Color.Black : ForeColor;
        }

        /// <summary>
        /// 父窗体的绘图画面
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Border_Open)
            {
                Pen BorderPen = new Pen(Mouse_Enter ? Enter_Border_Color : Out_Border_Color, Border_Size);
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width, Height);
            }
            if (Text_Open)
            {
                Point TP = new Point();
                if (TextStyle==TextStyle_Enum.Left)
                {
                    TP.X = 5;
                    TP.Y =5;
                }else if (TextStyle == TextStyle_Enum.Center)
                {
                    TP.X = Width / 2 - Convert.ToInt32(GetStringLength(Text)/2);
                    TP.Y = Height / 4;
                }else if (TextStyle==TextStyle_Enum.Right)
                {
                    TP.X = Width- Convert.ToInt32(GetStringLength(Text));
                    TP.Y = Height / 4;
                }
                e.Graphics.DrawString(ToText(Text), Font, Mouse_Enter ? new SolidBrush(Enter_Fore_Color) : new SolidBrush(this.ForeColor),TP);
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (OnMouseLeave_Open)
            {
                Mouse_Enter = false;
                Invalidate();
            }
            base.OnMouseLeave(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (OnMouseEnter_Open)
            {
                Mouse_Enter = true;
                Invalidate();
            }
            base.OnMouseEnter(e);
        }
        public double GetStringLength(String str)
        {
            double len = 0;
            len = Encoding.Default.GetBytes(Text).Length * Font.Size;
            return len;
        }
        public String ToText(String text)
        {
            String t = "";
            double TextLength = 0;
            double B = 1.2;
            foreach (Char c in text)
            {
                double tsize = Encoding.Default.GetBytes(c + "").Length;
                if (TextLength + tsize * (Font.Size / B) > Width)
                {
                    TextLength = 0;
                    t += "\n";
                }
                else
                {
                    TextLength += tsize * Font.Size / B;
                    t += c + "";
                }
                if (c == '\n')
                {
                    TextLength = 0;
                }
            }
            return t;
        }
    }
}
