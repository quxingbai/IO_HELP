namespace UI.ImageForms
{
    partial class GetAllFiles
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
            this.URL = new System.Windows.Forms.TextBox();
            this.GET = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.VALUE = new System.Windows.Forms.TextBox();
            this.FilesOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(12, 12);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(103, 21);
            this.URL.TabIndex = 0;
            this.URL.Text = "C:\\";
            // 
            // GET
            // 
            this.GET.Location = new System.Drawing.Point(12, 39);
            this.GET.Name = "GET";
            this.GET.Size = new System.Drawing.Size(75, 23);
            this.GET.TabIndex = 1;
            this.GET.Text = "确定";
            this.GET.UseVisualStyleBackColor = true;
            this.GET.Click += new System.EventHandler(this.GET_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Location = new System.Drawing.Point(155, 40);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(75, 23);
            this.CLOSE.TabIndex = 2;
            this.CLOSE.Text = "关闭";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // VALUE
            // 
            this.VALUE.Location = new System.Drawing.Point(184, 12);
            this.VALUE.Name = "VALUE";
            this.VALUE.Size = new System.Drawing.Size(41, 21);
            this.VALUE.TabIndex = 3;
            this.VALUE.Text = ".png";
            // 
            // FilesOpen
            // 
            this.FilesOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilesOpen.Location = new System.Drawing.Point(118, 12);
            this.FilesOpen.Name = "FilesOpen";
            this.FilesOpen.Size = new System.Drawing.Size(63, 21);
            this.FilesOpen.TabIndex = 4;
            this.FilesOpen.Text = "打开文件";
            this.FilesOpen.UseVisualStyleBackColor = true;
            this.FilesOpen.Click += new System.EventHandler(this.FilesOpen_Click);
            // 
            // GetAllFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 75);
            this.Controls.Add(this.FilesOpen);
            this.Controls.Add(this.VALUE);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.GET);
            this.Controls.Add(this.URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GetAllFiles";
            this.ParentLocationBind = true;
            this.Text = "GetAllFiles";
            this.Load += new System.EventHandler(this.GetAllFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button GET;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.TextBox VALUE;
        private System.Windows.Forms.Button FilesOpen;
    }
}