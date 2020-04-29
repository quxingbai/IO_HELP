using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using DAL;
using MODLE;

namespace BLL
{
    public class IMAGE_MODLE_XML_BLL
    {
        IMAGE_MODLE_XML_GS imxg = null;
        public IMAGE_MODLE_XML_BLL()
        {
            try
            {
                String xml_load_url = ConfigurationManager.ConnectionStrings["IMAGE_XML_URL"].ConnectionString;
                imxg = new IMAGE_MODLE_XML_GS(xml_load_url);
            }
            catch
            {
                throw new Exception("图像xml文件未加载");
            }
        }
        public XmlNode AddXmlNode(ImageModle modle)
        {
            return imxg.AddXmlNode(modle);
        }
        public List<ImageModle> GetAllImage()
        {
            return imxg.GetAllImage();
        } /// <summary>
          /// 根据ID查找对应的node
          /// </summary>
          /// <param name="ID">ID编号</param>
          /// <returns>List</returns>
        public ImageModle GetImagesByID(int ID)
        {
            return imxg.GetImagesByID(ID);
        }
        /// <summary>
        /// 根据传进来的modle值进行查询
        /// </summary>
        /// <param name="modle">里边的值可以不填，即不判断</param>
        /// <returns>List</returns>
        public List<ImageModle> GetImagesByModle(ImageModle modle)
        {
            return imxg.GetImagesByModle(modle);
        }
        public void DeleteById(int ID)
        {
            imxg.DeleteById(ID);
        }
    }
}
