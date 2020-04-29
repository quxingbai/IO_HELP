using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using System.Drawing;
using DAL;

namespace BLL
{
    public class LOAD_XML_GS_BLL
    {
        LOAD_XML_GS lxg = null;
        public LOAD_XML_GS_BLL()
        {
            try
            {
                String xml_load_url = ConfigurationManager.ConnectionStrings["LOAD_XML_URL"].ConnectionString;
                lxg = new LOAD_XML_GS(xml_load_url);
            }
            catch
            {
                //throw new Exception("XML NULL\n没有访问到Load.xml");
            }
        }
        /// <summary>
        /// 获取分辨率
        /// </summary>
        /// <returns></returns>
        public Size GetScreenSize()
        {
            return lxg.GetScreenSize();
        }
        /// <summary>
        /// 设置分辨率
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Size SetScreenSize(Size size)
        {
            return lxg.SetScreenSize(size);
        }
        /// <summary>
        /// 设置窗体大小
        /// </summary>
        /// <returns></returns>
        public Size GetFormSize()
        {
            return lxg.GetFormSize();
        }
        /// <summary>
        /// 设置窗体大小
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Size SetFormSize(Size size)
        {
            return lxg.SetFormSize(size);
        }
        /// <summary>
        /// 获取窗体字体
        /// </summary>
        /// <returns></returns>
        public Font GetFormFont()
        {
            return lxg.GetFormFont();
        }
        /// <summary>
        /// 设置窗体字体
        /// </summary>
        /// <returns></returns>
        public Font SetFormFont(Font font)
        {
            return lxg.SetFormFont(font);
        }
        /// <summary>
        /// 获取前景颜色
        /// </summary>
        /// <returns></returns>
        public Color GetFormForeColor()
        {
            return lxg.GetFormForeColor();
        }
        /// <summary>
        /// 设置前景颜色
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Color SetFormForeColor(Color c)
        {
            return lxg.SetFormForeColor(c);
        }
    }
}
