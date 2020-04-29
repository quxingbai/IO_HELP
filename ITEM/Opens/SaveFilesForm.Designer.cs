namespace ITEM.Opens
{
    partial class SaveFilesForm
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
            this.MAIN = new System.Windows.Forms.FlowLayoutPanel();
            this.Text_Width = new ITEM.TextBoxItem();
            this.Text_Height = new ITEM.TextBoxItem();
            this.SuspendLayout();
            // 
            // MAIN
            // 
            this.MAIN.Location = new System.Drawing.Point(1, 32);
            this.MAIN.Name = "MAIN";
            this.MAIN.Size = new System.Drawing.Size(428, 523);
            this.MAIN.TabIndex = 0;
            // 
            // Text_Width
            // 
            this.Text_Width.BorderSize = 2;
            this.Text_Width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Width.EnterBorderColor = System.Drawing.Color.BurlyWood;
            this.Text_Width.EnterForeColor = System.Drawing.Color.Black;
            this.Text_Width.EnterLeftTextColor = System.Drawing.Color.Black;
            this.Text_Width.FocusGotBorderColol = System.Drawing.Color.Black;
            this.Text_Width.FocusGotForeColor = System.Drawing.Color.Black;
            this.Text_Width.LeaveBorderColor = System.Drawing.Color.Black;
            this.Text_Width.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.Text_Width.LeftText = "Width";
            this.Text_Width.Location = new System.Drawing.Point(47, 12);
            this.Text_Width.Name = "Text_Width";
            this.Text_Width.OpenEnterBorder = true;
            this.Text_Width.OpenEnterForeColor = false;
            this.Text_Width.OpenFocusBorder = true;
            this.Text_Width.OpenFocusForeColor = false;
            this.Text_Width.OpenLeftText = true;
            this.Text_Width.OpenLeftTextColor = false;
            this.Text_Width.Size = new System.Drawing.Size(100, 14);
            this.Text_Width.TabIndex = 1;
            this.Text_Width.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // Text_Height
            // 
            this.Text_Height.BorderSize = 2;
            this.Text_Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Height.EnterBorderColor = System.Drawing.Color.BurlyWood;
            this.Text_Height.EnterForeColor = System.Drawing.Color.Black;
            this.Text_Height.EnterLeftTextColor = System.Drawing.Color.Black;
            this.Text_Height.FocusGotBorderColol = System.Drawing.Color.Black;
            this.Text_Height.FocusGotForeColor = System.Drawing.Color.Black;
            this.Text_Height.LeaveBorderColor = System.Drawing.Color.Black;
            this.Text_Height.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.Text_Height.LeftText = "Height";
            this.Text_Height.Location = new System.Drawing.Point(318, 12);
            this.Text_Height.Name = "Text_Height";
            this.Text_Height.OpenEnterBorder = true;
            this.Text_Height.OpenEnterForeColor = false;
            this.Text_Height.OpenFocusBorder = true;
            this.Text_Height.OpenFocusForeColor = false;
            this.Text_Height.OpenLeftText = true;
            this.Text_Height.OpenLeftTextColor = false;
            this.Text_Height.Size = new System.Drawing.Size(100, 14);
            this.Text_Height.TabIndex = 2;
            this.Text_Height.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // SaveFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 554);
            this.Controls.Add(this.Text_Height);
            this.Controls.Add(this.Text_Width);
            this.Controls.Add(this.MAIN);
            this.Name = "SaveFilesForm";
            this.Text = "SaveFilesForm";
            this.Load += new System.EventHandler(this.SaveFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MAIN;
        private TextBoxItem Text_Width;
        private TextBoxItem Text_Height;
    }
}