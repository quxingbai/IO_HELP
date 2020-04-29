using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using MODLE;
namespace DAL
{
    public class MAIN_IMAGE_FORM_XML_GS
    {
        XmlDocument xml = new XmlDocument();
        XmlNode MainNode = null;
        XmlNode ItemNode = null;
        public MAIN_IMAGE_FORM_XML_GS(String url)
        {
            xml.Load(url);
            MainNode = xml["Main"];
            ItemNode = MainNode["Item"];
        }
        /// <summary>
        /// 获取指定type的size
        /// </summary>
        /// <param name="Tid">指定的type标签中的Tid属性</param>
        /// <returns></returns>
        public Size GetItemSize(int Tid)
        {
            foreach (XmlNode types in ItemNode)
            {
                if (types.Attributes["Tid"].Value==Tid+"")
                {
                    return new Size()
                    {
                        Width = Convert.ToInt32(types["Width"].InnerText),
                        Height = Convert.ToInt32(types["Height"].InnerText)
                    };
                }
            }
            return new Size()
            {
                Width = 212,
                Height = 126
            };
        }
    }
}
