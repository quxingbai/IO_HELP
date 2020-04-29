using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEM;
namespace ITEM.Opens
{
    public partial class DataForm : SuperForm
    {
        public enum ItemTypes
        {
            SuperItem=1,
            MainImageFormItem =2
        }
        ItemTypes types = new ItemTypes();
        String Title = "";
        List<String> Values = null;
        SuperItem item = null;
        public DataForm(String Title,List<String> Values,SuperItem item,ItemTypes types)
        {
            this.types = types;
            this.Title = Title;
            this.Values = Values;
            this.item = item;
            InitializeComponent();
        }
        /// <summary>
        /// 直接判断并添加组件
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Values"></param>
        /// <param name="item"></param>
        void SetDatas(String Title, List<String> Values,SuperItem item)
        {
            int Width = this.Width - 20;
            //传进来的item和当前窗体的差距
            if (types==ItemTypes.MainImageFormItem)
            {
                item = ((MainImageFormItem)item);
            }
           
            TextBox t = new TextBox();
            t.Width = Width-t.Margin.Right-10;
            t.Height = Height;

            FlowLayoutPanel flp = To_Help.Create_FlowLayoutPanel_TextBox(Title, Values,t);
            flp.Width = Width;
            flp.Height =Convert.ToInt32(Form.Height);
            Form.Controls.Add(item);
            Form.Controls.Add(flp);
        }
        
        private void DataForm_Load(object sender, EventArgs e)
        {
            SetDatas(Title,Values,item);
        }
    }
}
