using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class ScreenSet : Super_Form
    {
        public ScreenSet()
        {
            InitializeComponent();
        }

        private void ScreenSet_Load(object sender, EventArgs e)
        {

        }

        private void BT_SUBMIT_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(TEXT_WIDTH.Text);
            int height = Convert.ToInt32(TEXT_HEIGHT.Text);
            new SettingWindowsSizeBLL().RESIZE(width, height);
        }
    }
}
