using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MAIN_IMAGE_FORM_XML_BLL
    {
        MAIN_IMAGE_FORM_XML_GS mifxg = null;
        public MAIN_IMAGE_FORM_XML_BLL()
        {
            String xml_load_url = ConfigurationManager.ConnectionStrings["MAIN_FORM_IMAGE_XML_URL"].ConnectionString;
            mifxg = new MAIN_IMAGE_FORM_XML_GS(xml_load_url);
        }
        public Size GetItemSize(int Tid)
        {
            return mifxg.GetItemSize(Tid);
        }
    }
}
