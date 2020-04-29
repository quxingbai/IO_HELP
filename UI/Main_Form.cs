using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODS;
namespace UI
{
    public partial class Main_Form : Super_Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            ContextMenuStrip context = new ContextMenuStrip();
            context.Items.Add("设置窗体");
            context.Items[0].Click += FormSetting ;
            context.Items.Add("设置分辨率");
            context.Items[1].Click += ScreenSizeStting; 
            context.Items.Add("添加文件");
            context.Items[2].Click += OpenSaveForm;
            context.Items.Add("添加文件",null,new EventHandler((a,b)=>{
                SettingHostFile shf = new SettingHostFile();
            }));
            ITEMS.ContextMenuStrip = context;
        }



        private void FormSetting(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ScreenSizeStting(object sender, EventArgs e)
        {
            new ScreenSet().Show();
        }
        private void OpenSaveForm(object sender, EventArgs e)
        {
            new ADDFiles_Form().Show();
        }
    }
}
