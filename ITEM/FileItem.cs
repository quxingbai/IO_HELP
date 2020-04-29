using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MODLE;

namespace ITEM
{
    public class FileItem:SuperItem
    {
        FileModle file = null;
        public FileItem(FileModle file)
        {
            this.file = file;
            ContextMenuStrip context = new ContextMenuStrip();
            context.Items.Add("打开文件");
            context.Items[0].Click += FileOpen; ;
            context.Items.Add("打开文件位置");
            context.Items[1].Click += FileUrlOpen;
            context.Items.Add("删除文件");
            context.Items[2].Click += FileDelete;
            this.ContextMenuStrip = context;
            files = new FileInfo(file.Url);
        }
        FileInfo files = null;
        private void FileDelete(object sender, EventArgs e)
        {
            Boolean b = MessageBox.Show("确定删除吗", "确定删除" + file.Title + "吗",MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (b)
            {
                files.Delete();
            }
        }
        private void FileUrlOpen(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(files.FullName);
        }

        private void FileOpen(object sender, EventArgs e)
        {
            files.Open(FileMode.Open);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }
    }
}
