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
using System.IO;

namespace UI
{
    public partial class ADDFiles_Form : Form
    {
        public ADDFiles_Form()
        {
            InitializeComponent();
        }
        FileInfo fi = null;
        private void BT_OPEN_FILE_URL_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            TEXT_URL.Text = ofd.FileName;
            fi = new FileInfo(ofd.FileName);
            LB_SIZE.Text =Convert.ToInt32(fi.Length / 1024.0 / 1024.0) + " MB";
        }
        private void BT_SUBMIT_Click(object sender, EventArgs e)
        {
            GET_XML_FILES_BLL gxfb = new GET_XML_FILES_BLL();
            gxfb.AddFiles(new MODLE.FileModle()
            {
                Time = DateTime.Now.ToString(),
                Title = TEXT_TITLE.Text,
                Url=TEXT_URL.Text,
                Size=Convert.ToInt32(fi.Length / 1024.0 / 1024.0)
            }) ;
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ADDFiles_Form_Load(object sender, EventArgs e)
        {
        }
    }
}
