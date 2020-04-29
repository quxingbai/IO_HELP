namespace UI
{
    partial class ADDFiles_Form
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
            this.TEXT_TITLE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXT_URL = new System.Windows.Forms.TextBox();
            this.BT_OPEN_FILE_URL = new System.Windows.Forms.Button();
            this.BT_SUBMIT = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_SIZE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TEXT_TITLE
            // 
            this.TEXT_TITLE.Location = new System.Drawing.Point(59, 9);
            this.TEXT_TITLE.Name = "TEXT_TITLE";
            this.TEXT_TITLE.Size = new System.Drawing.Size(247, 21);
            this.TEXT_TITLE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件位置";
            // 
            // TEXT_URL
            // 
            this.TEXT_URL.Location = new System.Drawing.Point(59, 36);
            this.TEXT_URL.Name = "TEXT_URL";
            this.TEXT_URL.Size = new System.Drawing.Size(150, 21);
            this.TEXT_URL.TabIndex = 2;
            // 
            // BT_OPEN_FILE_URL
            // 
            this.BT_OPEN_FILE_URL.Location = new System.Drawing.Point(215, 36);
            this.BT_OPEN_FILE_URL.Name = "BT_OPEN_FILE_URL";
            this.BT_OPEN_FILE_URL.Size = new System.Drawing.Size(91, 23);
            this.BT_OPEN_FILE_URL.TabIndex = 4;
            this.BT_OPEN_FILE_URL.Text = "打开文件位置";
            this.BT_OPEN_FILE_URL.UseVisualStyleBackColor = true;
            this.BT_OPEN_FILE_URL.Click += new System.EventHandler(this.BT_OPEN_FILE_URL_Click);
            // 
            // BT_SUBMIT
            // 
            this.BT_SUBMIT.Location = new System.Drawing.Point(4, 96);
            this.BT_SUBMIT.Name = "BT_SUBMIT";
            this.BT_SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.BT_SUBMIT.TabIndex = 5;
            this.BT_SUBMIT.Text = "确定";
            this.BT_SUBMIT.UseVisualStyleBackColor = true;
            this.BT_SUBMIT.Click += new System.EventHandler(this.BT_SUBMIT_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Location = new System.Drawing.Point(224, 96);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(82, 23);
            this.BT_CLOSE.TabIndex = 6;
            this.BT_CLOSE.Text = "取消";
            this.BT_CLOSE.UseVisualStyleBackColor = true;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "大小：";
            // 
            // LB_SIZE
            // 
            this.LB_SIZE.AutoSize = true;
            this.LB_SIZE.Location = new System.Drawing.Point(50, 65);
            this.LB_SIZE.Name = "LB_SIZE";
            this.LB_SIZE.Size = new System.Drawing.Size(0, 12);
            this.LB_SIZE.TabIndex = 8;
            // 
            // ADDFiles_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 136);
            this.Controls.Add(this.LB_SIZE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_CLOSE);
            this.Controls.Add(this.BT_SUBMIT);
            this.Controls.Add(this.BT_OPEN_FILE_URL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEXT_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEXT_TITLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ADDFiles_Form";
            this.Text = "ADDFiles_Form";
            this.Load += new System.EventHandler(this.ADDFiles_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXT_TITLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXT_URL;
        private System.Windows.Forms.Button BT_OPEN_FILE_URL;
        private System.Windows.Forms.Button BT_SUBMIT;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_SIZE;
    }
}