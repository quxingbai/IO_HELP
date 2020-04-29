using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DLL
{
    public class XML_GS
    {
        XmlDocument xml= new XmlDocument();
        public XML_GS(String url)
        {
            xml.Load(url);
        }
        public void UpDateXmlValue(XmlNode node,String Value)
        {
            node.InnerText = Value;
        }
    }
}
