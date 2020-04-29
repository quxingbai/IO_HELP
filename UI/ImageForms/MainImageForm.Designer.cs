namespace UI.ImageForms
{
    partial class MainImageForm
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
            this.IMAGES = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // IMAGES
            // 
            this.IMAGES.AllowDrop = true;
            this.IMAGES.AutoScroll = true;
            this.IMAGES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IMAGES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMAGES.Location = new System.Drawing.Point(0, 0);
            this.IMAGES.Name = "IMAGES";
            this.IMAGES.Size = new System.Drawing.Size(800, 450);
            this.IMAGES.TabIndex = 0;
            this.IMAGES.DragEnter += new System.Windows.Forms.DragEventHandler(this.IMAGES_DragEnter);
            this.IMAGES.DragLeave += new System.EventHandler(this.IMAGES_DragLeave);
            // 
            // MainImageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IMAGES);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainImageForm";
            this.Text = "MainImageForm";
            this.Load += new System.EventHandler(this.MainImageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel IMAGES;
    }
}