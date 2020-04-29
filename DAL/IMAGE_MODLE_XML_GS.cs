using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MODLE;

namespace DAL
{
    public class IMAGE_MODLE_XML_GS
    {
        XmlDocument xml = null;
        XmlNode MainNode = null;
        String URL = "";
        public IMAGE_MODLE_XML_GS(String Url)
        {
            URL = Url;
            xml = new XmlDocument();
            xml.Load(Url);
            MainNode = xml["Main"];
        }
        /// <summary>
        /// 不需要提供ID
        /// </summary>
        /// <param name="modle"></param>
        /// <returns></returns>
        public XmlNode AddXmlNode(ImageModle modle)
        {
            int MaxID = MainNode.ChildNodes.Count + 1;
            int ID=0;
            Random rd = new Random();
            while (true)
            {
                ID = rd.Next(1, MaxID + 1);
                int r = IsId(new ImageModle() { ID = ID, Url = modle.Url });
                if (r==3)
                {
                    break;
                }else if (r == 1)
                {
                    return null;
                }
            }
            XmlNode xn = xml.CreateElement("Image");
            XmlAttribute attr = xml.CreateAttribute("ID");
            attr.Value = ID.ToString();
            xn.Attributes.Append(attr);
            // XmlNode IDNode = xml.CreateElement("ID");
            XmlNode TitleNode = xml.CreateElement("Title");
            XmlNode TitleUrl = xml.CreateElement("Url");
            XmlNode TitleTime = xml.CreateElement("Time");

            // IDNode.InnerText = modle.ID.ToString();
            TitleNode.InnerText = modle.Title;
            TitleUrl.InnerText = modle.Url;
            TitleTime.InnerText = modle.Time;

            // xn.AppendChild(IDNode);
            xn.AppendChild(TitleNode);
            xn.AppendChild(TitleUrl);
            xn.AppendChild(TitleTime);

            MainNode.AppendChild(xn);
            Save();
            return xn;
        }
        /// <summary>
        /// 判断能否成为ID
        /// </summary>
        /// <returns></returns>
        int IsId(ImageModle modle)
        {
            Boolean IDs = true;
            Boolean Urls = true;
            foreach (ImageModle m in GetAllImage())
            {
                if (modle.Url == m.Url)
                {

                    Urls = false;
                    break;
                }
                if (m.ID == modle.ID)
                {
                    IDs = false;
                    break;
                }
            }
            if (!Urls)
            {
                //情况 1 URL已经有了
                return 1;
            }
            else if (!IDs)
            {
                //情况 2 ID 已经有了
                return 2;
            }
                //情况 3 这个可以用
            return 3;
        }
        void Save()
        {
            xml.Save(URL);
        }
        public List<ImageModle> GetAllImage()
        {
            return XmlToListModle(MainNode);
        }


        List<ImageModle> XmlToListModle(XmlNode imagenode)
        {
            List<ImageModle> list = new List<ImageModle>();
            foreach (XmlNode xn in imagenode.ChildNodes)
            {
                list.Add(new ImageModle()
                {
                    ID = Convert.ToInt32(xn.Attributes["ID"].Value),
                    Time = xn["Time"].InnerText.ToString(),
                    Title = xn["Title"].InnerText.ToString(),
                    Url = xn["Url"].InnerText.ToString(),
                });
            }
            return list;
        }
        ImageModle XmlToModle(XmlNode imagenode)
        {
            ImageModle modle = new ImageModle();
            modle = (new ImageModle()
            {
                ID = Convert.ToInt32(imagenode.Attributes["ID"].Value),
                Time = imagenode["Time"].InnerText.ToString(),
                Title = imagenode["Title"].InnerText.ToString(),
                Url = imagenode["Url"].InnerText.ToString(),
            });
            return modle;
        }
        /// <summary>
        /// 根据ID查找对应的node
        /// </summary>
        /// <param name="ID">ID编号</param>
        /// <returns>List</returns>
        public ImageModle GetImagesByID(int ID)
        {
            foreach (XmlNode node in MainNode)
            {
                if (node.Attributes["ID"].Value == ID.ToString())
                {
                    return XmlToModle(node);
                }
            }
            return null;
        }
        /// <summary>
        /// 根据传进来的modle值进行查询
        /// </summary>
        /// <param name="modle">里边的值可以不填，即不判断</param>
        /// <returns>List</returns>
        public List<ImageModle> GetImagesByModle(ImageModle modle)
        {
            List<ImageModle> list = new List<ImageModle>();
            foreach (XmlNode node in MainNode)
            {
                Boolean BID = node.Attributes["ID"].Value == 0.ToString() ? true : node.Attributes["ID"].Value == modle.ID.ToString();
                Boolean BTitle = modle.Title == "" ? true : node["Title"].InnerText == modle.Title;
                Boolean BTime = modle.Time == "" ? true : node["Time"].InnerText == modle.Time;
                Boolean BUrl = modle.Url == "" ? true : node["Url"].InnerText == modle.Url;
                Boolean TRUES = BID == BTitle == BTime == BUrl;
                if (TRUES)
                {
                    list.Add(XmlToModle(node));
                }
            }
            return list;
        }
        public void DeleteById(int ID)
        {
            foreach (XmlNode node in MainNode)
            {
                if (node.Attributes["ID"].Value == ID.ToString())
                {
                    MainNode.RemoveChild(node);
                    Save();
                }
            }
        }
    }
}
