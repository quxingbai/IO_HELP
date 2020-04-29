using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ITEM.Opens
{
    public partial class SaveFilesForm : SuperForm
    {
        IO_Help ih = new IO_Help();
        public class SaveFilessFormItem
        {
            public String Title { get; set; } = "无标题";
            public ImageFormat Type { get; set; } = ImageFormat.Png;
        }
        MainImageFormItem image = null;
        Image TypeImages = null;
        public SaveFilesForm(MainImageFormItem mifi)
        {
            image = mifi;
            InitializeComponent();
        }
        public SaveFilesForm(Image img)
        {
            TypeImages = img;
            InitializeComponent();
        }
        private void SaveFilesForm_Load(object sender, EventArgs e)
        {
            List<SaveFilessFormItem> list = new List<SaveFilessFormItem>()
            {

                new SaveFilessFormItem()
                {
                    Title="PNG",
                    Type=ImageFormat.Png,
                },
                new SaveFilessFormItem()
                {
                    Title="JPEG",
                    Type=ImageFormat.Jpeg,
                },
                new SaveFilessFormItem()
                {
                    Title="GIF",
                    Type=ImageFormat.Gif,
                },
                new SaveFilessFormItem()
                {
                    Title="BMP",
                    Type=ImageFormat.Bmp,
                },
                new SaveFilessFormItem()
                {
                    Title="EMF",
                    Type=ImageFormat.Emf,
                },
                new SaveFilessFormItem()
                {
                    Title="ICO",
                    Type=ImageFormat.Icon,
                },
                new SaveFilessFormItem()
                {
                    Title="WEBP",
                    Type=ImageFormat.Png,
                },
            };
            for (int f = 0; f < list.Count; f++)
            {
                ButtonItem bi = new ButtonItem()
                {
                    Text = f + 1 + "\t保存为---" + list[f].Title,
                    Tag = list[f],
                    Width = this.Width - 10,
                    Height = Height / 10,
                };
                bi.Click += Save;
                MAIN.Controls.Add(bi);
            }

        }


        private void Save(object sender, EventArgs e)
        {
            ButtonItem bi = ((ButtonItem)sender);
            SaveFilessFormItem type = (SaveFilessFormItem)bi.Tag;
            if (type.Title == "WEBP")
            {
                //using (Bitmap image = WebPFormat.LoadFromStream(new FileStream("image.webp", FileMode.Open, FileAccess.Read)))
                //{
                //    image.Save("image.png", ImageFormat.Png);
                //}
                return;
            }
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "*." + type.Title + "|";
            ofd.ShowDialog();
            String SaveUrl = ofd.FileName;
            if (SaveUrl == "")
            {
                return;
            }
            IO_Help.ImageAndType img = ih.ImageToNewImage(new Bitmap(image.BackgroundImage,Convert.ToInt32(Text_Width.Text==""?image.BackgroundImage.Width+"":Text_Width.Text),Convert.ToInt32(Text_Height.Text==""?image.BackgroundImage.Height+"":Text_Height.Text)), type.Type);
            Image imgs = null;
            FileStream file = new FileStream(SaveUrl, FileMode.Create);
            if (type.Type == ImageFormat.Png || type.Type == ImageFormat.Jpeg|| type.Type == ImageFormat.Bmp|| type.Type == ImageFormat.Gif)
            {
                imgs = new Bitmap(image.BackgroundImage);
                imgs.Save(file, type.Type);
                imgs.Dispose();
            }
            else if (type.Type == ImageFormat.Icon)
            {
                Icon i = (Icon)img.img;
                i.Save(file);
            }
            try
            {
                ofd.Dispose();
                file.Dispose();
                imgs.Dispose();
            }
            catch
            {

            }
            if (MessageBox.Show("转换成功！是否打开 文件夹", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(ih.GetFullName(SaveUrl));
            }
            Dispose();
        }

        static ImageFormat GetImageType(String Title)
        {
            List<SaveFilessFormItem> list = new List<SaveFilessFormItem>()
            {
                new SaveFilessFormItem()
                {
                    Title="PNG",
                    Type=ImageFormat.Png,
                },
                new SaveFilessFormItem()
                {
                    Title="JPEG",
                    Type=ImageFormat.Jpeg,
                },
                new SaveFilessFormItem()
                {
                    Title="GIF",
                    Type=ImageFormat.Gif,
                },
                new SaveFilessFormItem()
                {
                    Title="BMP",
                    Type=ImageFormat.Bmp,
                },
                new SaveFilessFormItem()
                {
                    Title="EMF",
                    Type=ImageFormat.Emf,
                },
            };
            foreach (SaveFilessFormItem l in list)
            {
                if (l.Title == Title)
                {
                    return l.Type;
                }
            }
            return null;
        }

    }
}
