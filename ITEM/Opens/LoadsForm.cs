using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEM.Opens
{
    public partial class LoadsForm : SuperForm
    {
        Timer CloseTimer = new Timer();
        public LoadsForm()
        {
            InitializeComponent();
            CloseTimer.Interval = 1000;
            CloseTimer.Enabled = true;
            CloseTimer.Tick += IsMaxValue;
        }

        private void IsMaxValue(object sender, EventArgs e)
        {
            if (Value == 100)
            {
                Dispose();
            }
        }

        private int value;
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                Item.Value = value;
                this.value = value;
                if (value == 100)
                {
                }
            }
        }

        private void LoadsForm_Load(object sender, EventArgs e)
        {
            Control parent = GetParent();
            if (parent != null)
            {
                this.MaximumSize = new Size()
                {
                    Width = parent.Width,
                    Height = this.Height,
                };
                this.Size = MaximumSize;
                //parent.Move += supers;
            }
            //supers(null, null);
        }
        //private void supers(object sender, EventArgs e)
        //{
        //    this.Location = new Point()
        //    {
        //        X= GetParent().Location.X,
        //        Y= GetParent().Location.Y-this.Height
        //    };
        //}
        //protected override void OnMove(EventArgs e)
        //{
        //    GetParent().Location = new Point()
        //    {
        //        X = this.Location.X,
        //        Y = this.Location.Y + this.Height
        //    };
        //    base.OnMove(e);
        //}
        Control GetParent()
        {
            if (ParentHandle != null)
            {
                return FromHandle(ParentHandle);
            }
            else
            {
                return new Control()
                {

                };
            }
        }
    }
}
