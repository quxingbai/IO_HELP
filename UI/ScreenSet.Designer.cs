namespace UI
{
    partial class ScreenSet
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
            this.TEXT_WIDTH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXT_HEIGHT = new System.Windows.Forms.TextBox();
            this.BT_SUBMIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXT_WIDTH
            // 
            this.TEXT_WIDTH.Location = new System.Drawing.Point(60, 10);
            this.TEXT_WIDTH.Name = "TEXT_WIDTH";
            this.TEXT_WIDTH.Size = new System.Drawing.Size(74, 21);
            this.TEXT_WIDTH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wdith";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // TEXT_HEIGHT
            // 
            this.TEXT_HEIGHT.Location = new System.Drawing.Point(60, 37);
            this.TEXT_HEIGHT.Name = "TEXT_HEIGHT";
            this.TEXT_HEIGHT.Size = new System.Drawing.Size(74, 21);
            this.TEXT_HEIGHT.TabIndex = 2;
            // 
            // BT_SUBMIT
            // 
            this.BT_SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SUBMIT.Location = new System.Drawing.Point(13, 415);
            this.BT_SUBMIT.Name = "BT_SUBMIT";
            this.BT_SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.BT_SUBMIT.TabIndex = 4;
            this.BT_SUBMIT.Text = "确认";
            this.BT_SUBMIT.UseVisualStyleBackColor = true;
            this.BT_SUBMIT.Click += new System.EventHandler(this.BT_SUBMIT_Click);
            // 
            // ScreenSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_SUBMIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEXT_HEIGHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEXT_WIDTH);
            this.Name = "ScreenSet";
            this.Text = "ScreenSet";
            this.Load += new System.EventHandler(this.ScreenSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXT_WIDTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXT_HEIGHT;
        private System.Windows.Forms.Button BT_SUBMIT;
    }
}