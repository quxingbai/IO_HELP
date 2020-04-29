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
using ITEM;
using BLL;
using ITEM.Opens;
using System.Threading;

namespace UI.ImageForms
{
    public partial class MainImageForm : Super_Form
    {
        //这是所有图片的集合
        public MainImageForm()
        {
            InitializeComponent();
        }

        private void MainImageForm_Load(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            GetAll();
            cms.Items.Add("获取目录下所有图像", null, GET_ALL_IMAGE_FORM_SHOW);
            cms.Items.Add("从剪切板中导入图像", null, CLIP_IMAGE);
            cms.Items.Add("查找", null, SELECT_IMAGE);
            cms.Items.Add("添加", null, ADD_IMAGE);
            IMAGES.ContextMenuStrip = cms;
        }
        void GetAll()
        {
            IMAGE_MODLE_XML_BLL imxb = new IMAGE_MODLE_XML_BLL();
            Add_MainImageFormItem(imxb.GetAllImage());
        }
        private void ADD_IMAGE(object sender, EventArgs e)
        {
            new AddMainImageForm().ShowDialog();
            GetAll();
        }
        private void CLIP_IMAGE(object sender, EventArgs e)
        {
            if (Clipboard.GetImage() == null)
            {
                MessageBox.Show("剪切板里没有图像");
                return;
            }
            Add_MainImageFormItem(new MainImageFormItem(new ImageModle()
            {
                ID = 0,
                Time = DateTime.Now.ToString(),
                Title = "剪切板",
                Url = "",
            }, true)
            {
                BackgroundImage = Clipboard.GetImage(),
            });
        }
        private void SELECT_IMAGE(object sender, EventArgs e)
        {
            SelectImageForm sif = new SelectImageForm();
            sif.ParentHandle = this.Handle;
            sif.Show();
        }
        private void GET_ALL_IMAGE_FORM_SHOW(object sender, EventArgs e)
        {
            GetAllFiles gaf = new GetAllFiles(this);
            gaf.ParentHandle = this.Handle;
            gaf.Show();
        }
        public void SET_ALL_IMAGE_BY_URLS(List<String> urls)
        {
            List<ImageModle> lmfi = new List<ImageModle>();
            foreach (String s in urls)
            {
                lmfi.Add(new ImageModle()
                {
                    Url = s,
                    Time = new IO_Help().GateCrateTime(s).ToString(),
                    Title = new IO_Help().GetName(s)
                });
            }
            Add_MainImageFormItem(lmfi);
        }
        private void IMAGES_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void IMAGES_DragLeave(object sender, EventArgs e)
        {

        }

        private void mainImageFormItem1_Click(object sender, EventArgs e)
        {

        }
        public int Add_MainImageFormItem(List<ImageModle> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            LoadsForm lf = new LoadsForm();
            lf.ParentHandle = this.Handle;
            lf.Show();
            IMAGES.Controls.Clear();
            int i = 0;
            new Thread(new ThreadStart(() =>
            {
                MAIN_IMAGE_FORM_XML_BLL mifxb = new MAIN_IMAGE_FORM_XML_BLL();
                foreach (ImageModle modle in list)
                {
                    MainImageFormItem mifi = new MainImageFormItem(modle, true)
                    {
                        TextStyle = SuperItem.TextStyle_Enum.Left,
                    };
                    mifi.Size = mifxb.GetItemSize(GetImageType(mifi.BackgroundImage.Size));
                    i++;
                    this.Invoke((Action)(() =>
                    {
                        IMAGES.Controls.Add(mifi);
                        int max = list.Count;
                        double baifenbi = ((i + 0.0) / (list.Count + 0.0)) * 100.0;
                        lf.Value = Convert.ToInt32(baifenbi);
                        lf.Text=i+"个目标";
                    }));
                }
            })).Start();
            return i;
        }
        public void Add_MainImageFormItem(MainImageFormItem mifi)
        {
            MAIN_IMAGE_FORM_XML_BLL mifxb = new MAIN_IMAGE_FORM_XML_BLL();
            mifi.Size = mifxb.GetItemSize(GetImageType(mifi.BackgroundImage.Size));
            IMAGES.Controls.Add(mifi);
        }
        int GetImageType(Size size)
        {
            int type = 1;
            if (!(size.Width > size.Height))
            {
                type = 2;
            }
            return type;
        }
    }
}
