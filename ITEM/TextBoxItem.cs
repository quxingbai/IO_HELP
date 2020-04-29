using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM
{
    public class TextBoxItem : TextBox
    {

        /// <summary>
        /// 文本框属性
        /// Value_TextBox只能输入数字
        /// Text_TextBox什么都可以输入
        /// </summary>
        public enum TextBoxStyle_Enum
        {
            Int_TextBox = 1,
            Text_TextBox = 2
        }
        public TextBoxItem()
        {
            BorderStyle = BorderStyle.None;
            LeaveForeColor = ForeColor;
            this.Invalidate();
        }
        public TextBoxStyle_Enum TextBoxStyle { get; set; } = TextBoxStyle_Enum.Text_TextBox;
        /// <summary>
        /// 是否开启边框
        /// </summary>
        public Boolean OpenEnterBorder { get; set; } = true;
        /// <summary>
        /// 边框大小
        /// </summary>
        public int BorderSize { get; set; } = 2;
        /// <summary>
        /// 鼠标移动到上方的 边框颜色
        /// </summary>
        public Color EnterBorderColor { get; set; } = Color.Black;
        /// <summary>
        /// 边框默认颜色
        /// </summary>
        public Color LeaveBorderColor { get; set; } = Color.Black;
        /// <summary>
        /// 是否开启左方的文本
        /// </summary>
        public Boolean OpenLeftText { get; set; } = true;
        /// <summary>
        /// 左边文本的内容
        /// </summary>
        public String LeftText { get; set; } = "";

        public Boolean OpenLeftTextColor { get; set; } = false;
        /// <summary>
        /// 左边文本 默认颜色
        /// </summary>
        public Color LeaveLeftTextColor { get; set; } = Color.Black;
        /// <summary>
        /// 鼠标移动到上方时的左边 文本颜色
        /// </summary>
        /// 
        public Color EnterLeftTextColor { get; set; } = Color.Black;
        /// <summary>
        /// 是否打开字体颜色变换
        /// </summary>
        public Boolean OpenEnterForeColor { get; set; } = false;
        /// <summary>
        /// 鼠标移动到上方时的 字体颜色
        /// </summary>
        public Color EnterForeColor { get; set; } = Color.Black;
        /// <summary>
        /// 鼠标移开时 字体颜色
        /// </summary>
        /// 
        Color LeaveForeColor { get; set; } = Color.Black;

        public Boolean OpenFocusBorder { get; set; } = true;
        /// <summary>
        /// 获取焦点之后 边框颜色
        /// </summary>
        public Color FocusGotBorderColol { get; set; } = Color.Black;
        /// <summary>
        /// 获取焦点之后字体颜色是否改变
        /// </summary>
        public Boolean OpenFocusForeColor { get; set; } = false;
        /// <summary>
        /// 获取焦点之后 字体颜色
        /// </summary>
        public Color FocusGotForeColor { get; set; } = Color.Black;

        Boolean Mouse_Enter = false;
        Boolean IS_Focus = false;
        /// <summary>
        /// 获取整个窗口的API
        /// </summary>
        /// <param name="Handle">句柄</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr Handle);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr Handle, IntPtr Hdc);
        protected override void OnMouseEnter(EventArgs e)
        {
            Mouse_Enter = true;
            this.Invalidate();
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            Mouse_Enter = false;
            this.Invalidate();
            base.OnMouseLeave(e);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            IS_Focus = true;
            this.Invalidate();
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            IS_Focus = false;
            this.Invalidate();
            base.OnLostFocus(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            String NText = "";
            int selecti = SelectionStart;
            if (this.Text.Length > 0)
            {
                if (TextBoxStyle == TextBoxStyle_Enum.Text_TextBox)
                {
                    NText = Text;
                }
                else if (TextBoxStyle == TextBoxStyle_Enum.Int_TextBox)
                {
                    int delchars = 0;
                    for(int f = 0; f <= Text.Length-1; f++)
                    {
                        Char c = Text[f];
                        if (c>='0'&&c<='9')
                        {
                            NText += c;
                        }
                        else
                        {
                            delchars ++;
                        }
                    }
                    selecti -= delchars;
                }
            }
            Text = NText;
            this.SelectionStart = selecti;
            base.OnTextChanged(e);
        }
        new public void Invalidate()
        {
            if (Parent != null)
            {
                Graphics ParentForm = Graphics.FromHwnd(Parent.Handle);
                OnPaint(new PaintEventArgs(ParentForm, new Rectangle(0, 0, Width, Height)));
            }
        }
        /// <summary>
        /// 这里传进来的是来自GetWindowDC返回的句柄
        /// 并不是直接拿的组件句柄
        /// </summary>
        /// <param name="Handle">句柄</param>
        public void Invalidate(IntPtr Handle)
        {
            IntPtr getwin = GetWindowDC(Handle);
            OnPaint(new PaintEventArgs(Graphics.FromHdc(getwin), new Rectangle(0, 0, Width, Height)));
            ReleaseDC(Handle, getwin);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            if (OpenEnterBorder)
            {
                Pen BorderPen = new Pen(Mouse_Enter ? EnterBorderColor : LeaveBorderColor, BorderSize);
                e.Graphics.DrawRectangle(BorderPen, x, y, Width, Height);
                BorderPen.Dispose();
            }
            if (OpenEnterForeColor)
            {
                this.ForeColor = Mouse_Enter ? EnterForeColor : LeaveForeColor;
            }
            if (OpenLeftText)
            {
                e.Graphics.DrawString(LeftText, Font, new SolidBrush(Mouse_Enter && OpenLeftTextColor ? EnterLeftTextColor : LeaveLeftTextColor), x - Convert.ToInt32(GetTextWidth(LeftText)), y);
            }
            if (OpenFocusBorder && IS_Focus)
            {
                Pen BorderPen = new Pen(OpenFocusBorder ? FocusGotBorderColol : LeaveForeColor, BorderSize);
                e.Graphics.DrawRectangle(BorderPen, x, y, Width, Height);
                BorderPen.Dispose();
            }
            if (OpenFocusForeColor)
            {
                this.ForeColor = IS_Focus ? FocusGotForeColor : LeaveForeColor;
            }
            e.Dispose();
            base.OnPaint(e);
        }
        /// <summary>
        /// 这是方便判断现在鼠标在不在上方用的
        /// 不过好像没啥用
        /// </summary>
        /// <param name="EnterColor">鼠标在上方时的颜色</param>
        /// <param name="LeaveColor">鼠标离开时的颜色</param>
        /// <returns></returns>
        Color EnterOrLeave(Color EnterColor, Color LeaveColor)
        {
            if (Mouse_Enter)
            {
                return EnterColor;
            }
            else
            {
                return LeaveColor;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf || m.Msg == 0x133)
            {
                // Invalidate(m.HWnd);
                Invalidate();
            }
        }
        double GetTextWidth(String Text)
        {
            double size = Encoding.Default.GetBytes(Text).Length * Font.Size;
            return size;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
