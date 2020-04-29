namespace ITEM.Opens
{
    partial class LoadsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Item = new ITEM.ProgressBarItem();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.Border_Open = true;
            this.Item.Border_Size = 2F;
            this.Item.Enter_Back_Color = System.Drawing.Color.Black;
            this.Item.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.Item.Enter_Fore_Color = System.Drawing.Color.Black;
            this.Item.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Item.Location = new System.Drawing.Point(12, 12);
            this.Item.Name = "Item";
            this.Item.OnMouseEnter_Open = true;
            this.Item.OnMouseLeave_Open = true;
            this.Item.Out_Border_Color = System.Drawing.Color.Black;
            this.Item.ProGressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Item.Size = new System.Drawing.Size(412, 44);
            this.Item.TabIndex = 0;
            this.Item.Text = "%0";
            this.Item.Text_Open = true;
            this.Item.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.Item.Value = 0;
            // 
            // LoadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 75);
            this.Controls.Add(this.Item);
            this.Name = "LoadsForm";
            this.ParentLocationBind = true;
            this.ParentLocationBind_Points = ITEM.Opens.SuperForm.ParentLocationBind_Point.Bottom;
            this.Text = "加载中";
            this.Load += new System.EventHandler(this.LoadsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBarItem Item;
    }
}