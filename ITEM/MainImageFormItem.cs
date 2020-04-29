using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODLE;
using ITEM.Opens;
using BLL;

namespace ITEM
{
    public class MainImageFormItem : SuperItem
    {
        ImageModle modle = new ImageModle();
        IO_Help ih = new IO_Help();
        IMAGE_MODLE_XML_BLL imxb = new IMAGE_MODLE_XML_BLL();


        Image backgroundimage = null;
        /// <summary>
        /// 加载选项
        /// </summary>
        /// <param name="modle">本体</param>
        /// <param name="Loads">是否加载额外操作 true加载 false 只加载图像</param>
        public MainImageFormItem(ImageModle modle, Boolean Loads)
        {
            if (Loads)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("打开", null, OpenImate);
                cms.Items.Add("保存到", null, SavesTo);
                cms.Items.Add("转换格式", null, SavesNewImage);
                cms.Items.Add("详细信息", null, ImageDI);
                cms.Items.Add("打开文件位置", null, OpenImageUrl);
                cms.Items.Add("删除", null, Delete);

                this.ContextMenuStrip = cms;
            }
            if (modle != null)
            {
                this.modle = modle;
                this.Text = modle.Title + "\n" + modle.Time;
            }
            try
            {
                this.backgroundimage = Image.FromFile(modle.Url);
                this.BackgroundImage = backgroundimage;
            }
            catch
            {
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(modle.Url);
                    Bitmap b = icon.ToBitmap();
                    backgroundimage = b;
                    this.BackgroundImage = backgroundimage;
                }
                catch
                {
                    this.BackgroundImage = Image.FromFile(@"Image\Images\NULL.png");
                }
            }
        }

        private void SavesNewImage(object sender, EventArgs e)
        {
            SaveFilesForm sff = new SaveFilesForm(new MainImageFormItem(modle, false) { BackgroundImage = this.BackgroundImage });
            sff.Show();
        }
        private void SavesTo(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".PNG";
            sfd.ShowDialog();
            String URL = sfd.FileName;
            if (URL == "")
            {
                return;
            }
            BackgroundImage.Save(URL);
            if (MessageBox.Show("保存成功 是否打开文件夹?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(ih.GetFullName(URL));
            }
        }

        private void Delete(object sender, EventArgs e)
        {
         
            if (MessageBox.Show("确定删除 " + modle.Title + " 吗", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (backgroundimage != null)
                {
                    backgroundimage.Dispose();
                    BackgroundImage.Dispose();
                }
                if (modle.Url != "")
                {
                    ih.Delete(modle.Url);
                }
            }
            MessageBox.Show("删除成功");
            Dispose();
            imxb.DeleteById(modle.ID);
        }

        private void OpenImageUrl(object sender, EventArgs e)
        {
            if (modle.Url != "")
            {
                ih.OpenFullName(ih.GetFullName(modle.Url));
            }
            else
            {
                MessageBox.Show("路径不合法");
            }
        }

        //获取详细信息
        private void ImageDI(object sender, EventArgs e)
        {
            List<String> Values = new List<string>()
            {
                "ID:"+modle.ID+"",
               "标题:"+ modle.Title,
                "创建时间:"+modle.Time+"",
                "链接地址:"+modle.Url
            };
            MainImageFormItem mifi = new MainImageFormItem(modle, false);
            mifi.Width = Width;
            mifi.Height = Height;
            DataForm df = new DataForm("详细信息", Values, mifi, DataForm.ItemTypes.MainImageFormItem);
            df.Show();
        }

        private void OpenImate(object sender, EventArgs e)
        {
            if (modle.Url == "")
            {
                ImageForm iform = new ImageForm(BackgroundImage);
                iform.Show();
                return;
            }
            ImageForm imageform = new ImageForm(modle);
            imageform.Show();
        }

        new public Image BackgroundImage { get; set; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            DoubleBuffered = true;
            e.Graphics.DrawImage(BackgroundImage, 0, 0, Width, Height);
            base.OnPaint(e);
        }
    }
}
