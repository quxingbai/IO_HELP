using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MODLE;
using DAL;
using System.Configuration;

namespace BLL
{
    public class GET_XML_FILES_BLL
    {
        GET_XML_FILES gxf = null;
        public GET_XML_FILES_BLL()
        {
            try
            {
                String XML_URL = ConfigurationManager.ConnectionStrings["FILES_XML_URL"].ConnectionString;
                gxf = new GET_XML_FILES(XML_URL);
            }
            catch
            {
                throw new Exception("获取文件信息失败");
            }
        }
        public List<FileModle> GetAllFiles()
        {
            return gxf.GetAllFiles();
        }
        public XmlNode AddFiles(FileModle file)
        {
            return gxf.AddFiles(file);
        }
    }
}
