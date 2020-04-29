using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MODLE;

namespace UI.ImageForms
{
    public partial class SelectImageForm : Super_Form
    {
        public IntPtr ParentHandle { get; set; }
        public SelectImageForm()
        {
            XmlGet = false;
            InitializeComponent();
        }

        private void SelectImageForm_Load(object sender, EventArgs e)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void BUTTON_SELECT_Click(object sender, EventArgs e)
        {
          List<ImageModle> lim = Select_Image(new ImageModle()
            {
                ID = Convert.ToInt32(TEXT_ID.Text),
                Time = TEXT_TIME.Text,
                Title = TEXT_NAME.Text,
                Url = TEXT_URL.Text
            });
            if(ParentHandle != null)
            {
                MainImageForm mif = (MainImageForm)FromHandle(ParentHandle);
                mif.Add_MainImageFormItem(lim);
            }
            if (lim.Count>0)
            {
                Dispose();
            }
            else
            {
                this.Text = "未查到任何值";
            }
        }

        private void BUTTON_CLEAR_Click(object sender, EventArgs e)
        {
            foreach(Control C in Controls)
            {
                if(C is TextBox)
                C.Text = "";
            }
        }
        List<ImageModle> Select_Image(ImageModle modle)
        {
            IMAGE_MODLE_XML_BLL imxb = new IMAGE_MODLE_XML_BLL();
            return imxb.GetImagesByModle(modle);
        }
    }
}
