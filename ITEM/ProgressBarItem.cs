using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM
{
    public class ProgressBarItem : SuperItem
    {
        public ProgressBarItem()
        {
            TextStyle = TextStyle_Enum.Center;
        }

        Boolean overs = false;
        /// <summary>
        /// 这是百分比
        /// </summary>
        private int value;
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value == this.value)
                {
                    return;
                }
                if (value==100)
                {
                    Overs();
                }
                if (value < 0 || value > 100)
                {
                    return;
                }
                else
                {
                    this.value = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// 设置进度条的长度
        /// </summary>
        public Color ProGressBarColor { get; set; } = Color.FromArgb(100, 255, 255, 255);

        /// <summary>
        /// 加载结束
        /// </summary>
        public void Overs()
        {
            overs = true;
            Text = "加载完成";
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            double width = (Width / 100.0) * Value;
            e.Graphics.FillRectangle(new SolidBrush(ProGressBarColor), 0, 0, Convert.ToInt32(width), Height);
            if (!overs)
            {
                this.Text = "%" + Value;
            }
            base.OnPaint(e);
        }
    }
}
