using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM.Opens
{
    public partial class SuperForm : Form
    {
        public SuperForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取父窗体的属性
        /// </summary>
        public Boolean GetSupert { get; set; } = true;
        /// <summary>
        /// 父窗体的句柄
        /// </summary>
        public IntPtr ParentHandle { get; set; }

        /// <summary>
        /// 用于加载时的值
        /// </summary>
        public static String ReturnValues { get; set; } = "";
        /// <summary>
        /// 是否与父窗体长度的 尺寸绑定
        /// true 是 false否
        /// </summary>
        public Boolean ParentWidthBind { get; set; } = false;
        /// <summary>
        /// 是否与父窗体高度的 尺寸绑定
        /// true 是 false否
        /// </summary>
        public Boolean ParentHeightBind { get; set; } = false;
        /// <summary>
        /// 是否与父窗体高度的 位置绑定
        /// true 是 false否
        /// </summary>
        public Boolean ParentLocationBind { get; set; } = false;
        public enum ParentLocationBind_Point
        {
            None=0,
            Top = 1,
            Left = 2,
            Bottom = 3,
            Right = 4,
        }
        public ParentLocationBind_Point ParentLocationBind_Points { get; set; } = ParentLocationBind_Point.Top;
        /// <summary>
        /// 进行的委托
        /// </summary>
        public delegate void VoidFunction();
        Control ParentControl = null;
        private void SuperForm_Load(object sender, EventArgs e)
        {
            if (ParentHandle != null)
            {
                ParentControl = FromHandle(ParentHandle);
                if (ParentLocationBind)
                {
                    ReSizes(ParentControl,null);
                    Moves(ParentControl, null);
                    this.Move += Moves;
                    ParentControl.Move += Moves;
                }
                if (GetSupert)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                }
                if (ParentWidthBind || ParentHeightBind)
                {
                    this.Resize += ReSizes;
                    ParentControl.Resize += ReSizes;
                }
            }
        }

        private void ReSizes(object sender, EventArgs e)
        {
            Control chufa = ((Control)sender);
            Control mubiao = sender == this ? ParentControl : this;
            if (ParentWidthBind)
            {
                mubiao.Width = chufa.Width;
            }
            if (ParentHeightBind)
            {
                mubiao.Height = chufa.Height;
            }
        }

        private void Moves(object sender, EventArgs e)
        {
            if (ParentControl==null)
            {
                throw new Exception("没有设定父窗体的句柄");
                return;
            }
            Control chufa = ((Control)sender);
            Control mubiao = chufa == this ? ParentControl : this;
            if(ParentLocationBind_Points == ParentLocationBind_Point.None)
            {

            }
            else if (ParentLocationBind_Points == ParentLocationBind_Point.Left)
            {
                mubiao.Location = new Point()
                {
                    X = chufa.Location.X + (chufa == this ? (+this.Width) : (-this.Width)),
                    Y = chufa.Location.Y,
                };
            }
            else if (ParentLocationBind_Points == ParentLocationBind_Point.Right)
            {
                mubiao.Location = new Point()
                {
                    X = chufa.Location.X,
                    Y = chufa.Location.Y + (chufa == this ? (+this.Height) : (-chufa.Height)),
                };
            }
            else if (ParentLocationBind_Points == ParentLocationBind_Point.Bottom)
            {

                mubiao.Location = new Point()
                {
                    X = chufa.Location.X,
                    Y = chufa.Location.Y + (chufa == this ? (-mubiao.Height) : (+chufa.Height)),
                };
            }
            else if (ParentLocationBind_Points == ParentLocationBind_Point.Top)
            {
                mubiao.Location = new Point()
                {
                    X = chufa.Location.X,
                    Y = chufa.Location.Y + (chufa == this ? (+this.Height) : (-this.Height)),
                };
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ParentControl != null)
            {


            }
            base.OnPaint(e);
        }
    }
}
