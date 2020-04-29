using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using System.Drawing;

namespace DLL
{
    public class LOAD_XML_GS
    {
        XmlDocument xml = new XmlDocument();
        //这是xml中的MAIN标签
        XmlNode xn = null;
        public LOAD_XML_GS()
        {
            String xml_load_url = ConfigurationManager.ConnectionStrings["LOAD_XML_URL"].ConnectionString;
            xml.Load(xml_load_url);
            xn = xml.ChildNodes[1];
        }
        public Size GetScreenSize()
        {
            Size s = new Size();
            s.Width = Convert.ToInt32(xn["Width"]);
            s.Height = Convert.ToInt32(xn["Height"]);
            return s;
        }
        public void SetScreenSize(Size size)
        {

        }
    }
}
