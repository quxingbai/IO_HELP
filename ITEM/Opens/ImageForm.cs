using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODLE;
namespace ITEM.Opens
{
    public partial class ImageForm : SuperForm
    {


        ImageModle modle = null;
        //这个是整个图片
        public ImageForm(ImageModle modle)
        {
            GetSupert = false;
            InitializeComponent();
            this.modle = modle;
        }
        new public Image BackgroundImage { get; set; }
        public ImageForm(Image image)
        {
            GetSupert = false;
            InitializeComponent();
            BackgroundImage = image;
            Controls.Add(new MainImageFormItem(new ImageModle() 
            {
            ID=0,
            Time=DateTime.Now.ToString(),
            Title="NULL",
            Url="",
            }, false) { Border_Open = false, OnMouseEnter_Open = false, OnMouseLeave_Open = false, Text_Open = false ,BackgroundImage=image});
        }
        Boolean Down = false;
        private void ImageForm_Load(object sender, EventArgs e)
        {
            Controls.Add(new MainImageFormItem(modle, false) {Border_Open=false,OnMouseEnter_Open=false,OnMouseLeave_Open=false,Text_Open=false});
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is MainImageFormItem)
                {
                    c.Width = Width;
                    c.Height = Height;
                    c.Invalidate();
                }
            }
            base.OnPaint(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Down = true;
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Down = false;
            base.OnMouseUp(e);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

    }
}
