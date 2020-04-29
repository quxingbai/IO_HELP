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
using BLL;
using ITEM;
using ITEM.Opens;

namespace UI
{
    public partial class Super_Form : Form
    {
        public Super_Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否从Xml文件中获取 数据
        /// </summary>
        public Boolean XmlGet { get; set; } = true;
        /// <summary>
        /// 是否从Xml文件中获取 大小
        /// </summary>
        public Boolean XmlGetSize { get; set; } = true;

        /// <summary>
        /// 是否从Xml文件中获取 字体
        /// </summary>
        public Boolean XmlGetFont { get; set; } = true;
        /// <summary>
        /// 是否从Xml文件中获取 字体颜色
        /// </summary>
        public Boolean XmlGetForeColor { get; set; } = true;
        /// <summary>
        /// 是否加载自定义组件
        /// </summary>
        public Boolean LoadControl_Open { get; set; } = true;

        /// <summary>
        /// 父窗体的句柄
        /// </summary>
        public IntPtr SuperFormHandle { get; set; }

        /// <summary>
        /// 无返回值方法的委托
        /// </summary>
        public delegate void VoidFunction();
        void XmlLoad()
        {
            LOAD_XML_GS_BLL lxgb = new LOAD_XML_GS_BLL();
            if (XmlGetSize)
            {
                Size = lxgb.GetFormSize();
            }
            if (XmlGetFont)
            {
                Font = lxgb.GetFormFont();
            }
            if (XmlGetForeColor)
            {
                ForeColor = lxgb.GetFormForeColor();
            }
        }
        private void Super_Form_Load(object sender, EventArgs e)
        {
            try
            {
                if (XmlGet)
                {
                    XmlLoad();
                }

            }
            catch
            {

            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
