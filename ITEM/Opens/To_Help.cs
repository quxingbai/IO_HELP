using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM.Opens
{
    public static class To_Help
    {
        /// <summary>
        /// 创建一个GroupBox 其中带有TextBox
        /// </summary>
        /// <param name="Title">标签名称</param>
        /// <param name="Values">值</param>
        /// <returns></returns>
        public static FlowLayoutPanel Create_FlowLayoutPanel_TextBox(String Title, List<String> Values, TextBox tb)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            for (int f = 0; f < Values.Count; f++)
            {
                flp.Controls.Add(new TextBox()
                {
                    Width = tb.Width,
                    Height = tb.Height,
                    Text = Values[f]
                }) ;
            }
            return flp;
        }
    }
}
