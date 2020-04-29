using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Service_Form : Super_Form
    {
        public Service_Form()
        {
            InitializeComponent();
        }

        private void Service_Form_Load(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items[0].Text = "添加服务";
            cms.Items[0].Click += ADD_SERVICE;
        }

        private void ADD_SERVICE(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
