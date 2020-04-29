using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MODLE;
namespace DAL
{
    public class GET_XML_FILES
    {
        XmlDocument xml = new XmlDocument();
        XmlNode MainNode = null;
        public GET_XML_FILES(String url)
        {
            xml.Load(url);
            MainNode = xml["Main"];
        }
        public List<FileModle> GetAllFiles()
        {
            List<FileModle> list = new List<FileModle>();
            foreach(XmlNode node in MainNode)
            {
                list.Add(new FileModle()
                {
                    Url= node["Url"].Value,
                    Title=node["Title"].Value,
                    Size=Convert.ToDouble(node["Size"]),
                    Time=node["Time"].Value
                });
            }
            return list;
        }
        public XmlNode AddFiles(FileModle file)
        {
            XmlDocument document = new XmlDocument();
            XmlNode node = new XmlDocument().CreateElement("File");

            XmlNode NTitle = new XmlDocument().CreateElement("Title");
            XmlNode NText = new XmlDocument().CreateElement("Url");
            XmlNode NSize = new XmlDocument().CreateElement("Size");
            XmlNode NTime = new XmlDocument().CreateElement("Time");

            NTitle.InnerText = file.Title;
            NText.InnerText = file.Url;
            NSize.InnerText = file.Size+"";
            NTime.InnerText = file.Time;

            node.AppendChild(NTitle);
            node.AppendChild(NText);
            node.AppendChild(NSize);
            node.AppendChild(NTime);

            MainNode.AppendChild(node);
            return node;
        }
        public Boolean Delete(String FileName)
        {
            foreach (XmlNode node  in MainNode)
            {
                if (node["File"].Value==FileName)
                {
                    node.RemoveAll();
                    return true;
                }
            }
            return false;
        }

    }
}
