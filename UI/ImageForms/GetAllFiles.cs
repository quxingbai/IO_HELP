using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEM;
namespace UI.ImageForms
{
    public partial class GetAllFiles : ITEM.Opens.SuperForm
    {
        Super_Form form = null;
        public GetAllFiles(Super_Form form)
        {
            //XmlGet = false;
            this.form = form;
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GET_Click(object sender, EventArgs e)
        {
            List<String> ALL_URL = new List<String>();
            IO_Help ih = new IO_Help();
            ALL_URL = ih.GetAllFiles(URL.Text, VALUE.Text);
            MainImageForm mif = ((MainImageForm)form);
            mif.SET_ALL_IMAGE_BY_URLS(ALL_URL);
            this.Dispose();
        }

        private void GetAllFiles_Load(object sender, EventArgs e)
        {
        }

        private void FilesOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            URL.Text = fbd.SelectedPath;
        }
    }
}
