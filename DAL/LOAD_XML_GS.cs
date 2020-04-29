using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Drawing;

namespace DAL
{
    public class LOAD_XML_GS
    {
        XmlDocument xml = new XmlDocument();
        //这是xml中的MAIN标签
        XmlNode MainNode = null;
        //Main标签中的Screen标签
        XmlNode MainScreenNode = null;
        //Main标签中的Form标签
        XmlNode MainFormNode = null;
        //Main->Form->Item
        XmlNode MainFormItemNode = null;
        //Main->Form->Font
        XmlNode MainFormFont = null;
        public LOAD_XML_GS(String xml_load_url)
        {
            xml.Load(xml_load_url);
            MainNode =xml["Main"];
            MainScreenNode = MainNode["Screen"];
            MainFormNode = MainNode["Form"];
            MainFormFont = MainNode["Form"]["Font"];
            MainFormItemNode = MainNode["Form"]["Item"];
        }
        /// <summary>
        /// 获取分辨率
        /// </summary>
        /// <returns></returns>
        public Size GetScreenSize()
        {
            Size s = new Size();
            s.Width = Convert.ToInt32(MainScreenNode["Width"]);
            s.Height = Convert.ToInt32(MainScreenNode["Height"]);
            return s;
        }
        /// <summary>
        /// 设置分辨率
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Size SetScreenSize(Size size)
        {
            MainScreenNode["Width"].InnerText = size.Width.ToString();
            MainScreenNode["Height"].InnerText = size.Height.ToString();
            return size;
        }
        /// <summary>
        /// 设置窗体大小
        /// </summary>
        /// <returns></returns>
        public Size GetFormSize()
        {
            Size s = new Size();
            s.Width = Convert.ToInt32(MainFormNode["Width"].InnerText);
            s.Height = Convert.ToInt32(MainFormNode["Height"].InnerText);
            return s;
        }
        /// <summary>
        /// 设置窗体大小
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Size SetFormSize(Size size)
        {
            MainFormNode["Width"].InnerText = size.Width.ToString();
            MainFormNode["Height"].InnerText = size.Height.ToString();
            return size;
        }
        /// <summary>
        /// 获取窗体字体
        /// </summary>
        /// <returns></returns>
        public Font GetFormFont()
        {
            String FName = MainFormFont["Name"].InnerText;
            int FSize = 9;
            FSize = Convert.ToInt32(MainFormFont["Size"].InnerText);
            Font f = new Font(FName,FSize);
            return f;
        }
        /// <summary>
        /// 设置窗体字体
        /// </summary>
        /// <returns></returns>
        public Font SetFormFont(Font font)
        {
            MainFormFont["Name"].InnerText = font.Name;
            MainFormFont["Size"].InnerText = font.Size.ToString();
            return font;
        }
        /// <summary>
        /// 获取前景颜色
        /// </summary>
        /// <returns></returns>
        public Color GetFormForeColor()
        {
            int A = Convert.ToInt32(MainFormNode["ForeColor"]["A"].InnerText);
            int R = Convert.ToInt32(MainFormNode["ForeColor"]["R"].InnerText);
            int G = Convert.ToInt32(MainFormNode["ForeColor"]["G"].InnerText);
            int B = Convert.ToInt32(MainFormNode["ForeColor"]["B"].InnerText);
            return Color.FromArgb(A, R, G, B);
        }
        /// <summary>
        /// 设置前景颜色
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Color SetFormForeColor(Color c)
        {
            MainFormNode["ForeColor"]["A"].InnerText = c.A.ToString() ;
            MainFormNode["ForeColor"]["R"].InnerText = c.R.ToString() ;
            MainFormNode["ForeColor"]["G"].InnerText = c.G.ToString() ;
            MainFormNode["ForeColor"]["B"].InnerText = c.B.ToString() ;
            return c;
        }


    }
}
