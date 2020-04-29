using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
namespace ITEM
{
    public class IO_Help
    {
        List<String> ALL_FILES = null;

        void GetALL(String URL, String VALUE)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(URL);
                foreach (FileInfo file in d.GetFiles())
                {
                    if (VALUE == "")
                    {
                        ALL_FILES.Add(file.FullName);
                    }
                    else if (file.Name.IndexOf(VALUE) > 0)
                    {
                        ALL_FILES.Add(file.FullName);
                    }
                }
                foreach (DirectoryInfo di in d.GetDirectories())
                {
                    GetALL(di.FullName, VALUE);
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="url">文件目标</param>
        /// <returns>文件大小</returns>
        public double GetSize(String url)
        {
            FileInfo fi = new FileInfo(url);
            return Convert.ToDouble(fi.Length / 1024.0 / 1024.0);
        }
        /// <summary>
        /// 获取文件名称
        /// </summary>
        /// <param name="url">文件目标</param>
        /// <returns>文件名</returns>
        public String GetName(String url)
        {
            return new FileInfo(url).Name;
        }
        /// <summary>
        /// 获取创建时间
        /// </summary>
        /// <param name="url">文件目标</param>
        /// <returns>创建时间</returns>
        public DateTime GateCrateTime(String url)
        {
            return new FileInfo(url).CreationTime;
        }
        /// <summary>
        /// 获取目录下所有带有VALUE的文件
        /// </summary>
        /// <param name="URL">开始目录</param>
        /// <param name="VALUE">根据这个来判断是否获取</param>
        /// <returns></returns>
        public List<String> GetAllFiles(String URL, String VALUE)
        {
            ALL_FILES = new List<String>();
            GetALL(URL, VALUE);
            return ALL_FILES;
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="URL">文件目标</param>
        public void Delete(String URL)
        {
            File.Delete(URL);
        }
        /// <summary>
        /// 获取文件的父目录
        /// </summary>
        /// <param name="URL">文件目标</param>
        /// <returns></returns>
        public String GetFullName(String URL)
        {
            String url = "";
            url = new FileInfo(URL).Directory.FullName;
            return url;
        }
        /// <summary>
        /// 创建文件 并且输入值
        /// </summary>
        /// <param name="URL">创建位置</param>
        /// <param name="Name">文件名和后缀</param>
        /// <param name="Text">往文件中穿的值</param>
        /// <returns>是否创建成功</returns>
        public Boolean CreateFiles(String URL, String Name, String Text)
        {
            try
            {
                using (FileStream file = new FileStream(URL, FileMode.Create))
                {
                    new StreamWriter(file).WriteLine(Text);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 打开文件并且添加值
        /// </summary>
        /// <param name="URL">文件位置 包括文件名</param>
        /// <param name="Text">添加的文本</param>
        /// <param name="Saves">是否覆盖 true覆盖</param>
        public void OpenWriteFiles(String URL, String Text, Boolean Saves)
        {
            if (!File.Exists(URL))
            {
                throw new Exception("找不到此文件");
            }
            using (FileStream file = new FileStream(URL, FileMode.Open))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    if (Saves)
                    {
                        sw.WriteLine(Text);
                    }
                    else
                    {
                        String texts = OpenReaderFiles(URL);
                        sw.WriteLine(texts + "\n" + Text);
                    }
                }
            }
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="URL">文件目标</param>
        /// <returns>读取到的数值</returns>
        public String OpenReaderFiles(String URL)
        {
            try
            {
                if (!File.Exists(URL))
                {
                    throw new Exception("找不到此文件");
                }
                String Text = "";
                using (FileStream file = new FileStream(URL, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        Text = sr.ReadToEnd();
                    }
                }
                return Text;
            }
            catch
            {
                return "读取错误"; 
            }
        }
        /// <summary>
        /// 这是用来打开文件夹的的
        /// </summary>
        /// <param name="URL">目标文件夹</param>
        public void OpenFullName(String URL)
        {
            Process.Start(URL);
        }
        /// <summary>
        /// 复制文件到某个地方
        /// </summary>
        /// <param name="Files">想要复制的文件</param>
        /// <param name="ToUrl">复制到的位置</param>
        /// <returns>异常消息</returns>
        public String CopyFiles(String Files, String ToUrl)
        {
            try
            {
                File.Copy(Files, ToUrl);
                return "";
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public Image IconToImage(Icon i)
        {
            Image img = Image.FromHbitmap(i.Handle);
            return img;
        }
        public Icon ImageToIcon(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Icon);
            Icon i = new Icon(ms);
            ms.Dispose();
            return i;
        }
        public Icon GetAppIcon(String URL)
        {
            Icon icon = Icon.ExtractAssociatedIcon(URL);
            Bitmap b = icon.ToBitmap();
            return icon;
        }
        /// <summary>
        /// 改变格式
        /// </summary>
        /// <param name="URL">文件</param>
        /// <param name="IF">图片类型</param>
        /// <returns>图片</returns>
        public Image ImageToNewImage(String URL, System.Drawing.Imaging.ImageFormat IF)
        {
            MemoryStream ms = new MemoryStream();
            Image img = Image.FromFile(URL);
            img.Save(ms, IF);
            img = Image.FromStream(ms);
            ms.Dispose();
            return img;
        }
        public class ImageAndType
        {
            public object img;
            public ImageFormat type;
        }

        /// <summary>
        /// 改变格式
        /// </summary>
        /// <param name="img">想要转换格式的文件</param>
        /// <param name="IF">图片类型</param>
        /// <returns>图片</returns>
        public ImageAndType ImageToNewImage(Bitmap bitmap, ImageFormat IF)
        {
            ImageAndType iat = new ImageAndType();
            iat.type = IF;
            if (IF == ImageFormat.Png || IF == ImageFormat.Jpeg|| IF == ImageFormat.Bmp|| IF == ImageFormat.Gif)
            {
                Image img = bitmap;
                iat.img = bitmap;
                img.Dispose();
            }
            else if (IF == ImageFormat.Icon)
            {
                iat.img = Icon.FromHandle(bitmap.GetHicon());
            }
            else
            {
                throw new Exception("还没有这个功能");
            }
            return iat;
        }
    }
}
