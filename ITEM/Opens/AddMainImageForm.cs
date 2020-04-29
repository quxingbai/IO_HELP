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
using BLL;

namespace ITEM.Opens
{
    public partial class AddMainImageForm : SuperForm
    {
        public AddMainImageForm()
        {
            InitializeComponent();
        }
        IMAGE_MODLE_XML_BLL bll = new IMAGE_MODLE_XML_BLL();
        private void BT_FILEOPEN_Click(object sender, EventArgs e)
        {
            OpenFileDialog urls = new OpenFileDialog();
            urls.ShowDialog();
            TEXT_URL.Text = urls.FileName;
            urls.Dispose();
        }
        public Object ParentForms { get; set; }
        private void BT_SUBMIT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bll.AddXmlNode(new ImageModle()
            {
                ID = 0,
                Time = DateTime.Now.ToString(),
                Title = TEXT_TITLE.Text,
                Url = TEXT_URL.Text,
            })!= null?"添加成功":"添加失败");
            Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
