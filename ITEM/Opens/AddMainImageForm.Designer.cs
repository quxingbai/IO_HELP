namespace ITEM.Opens
{
    partial class AddMainImageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TEXT_TITLE = new ITEM.TextBoxItem();
            this.BT_SUBMIT = new ITEM.ButtonItem();
            this.TEXT_URL = new ITEM.TextBoxItem();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_EXIT = new ITEM.ButtonItem();
            this.BT_FILEOPEN = new ITEM.ButtonItem();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // TEXT_TITLE
            // 
            this.TEXT_TITLE.BorderSize = 2;
            this.TEXT_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_TITLE.EnterBorderColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.EnterLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.FocusGotBorderColol = System.Drawing.Color.Black;
            this.TEXT_TITLE.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_TITLE.LeftText = "";
            this.TEXT_TITLE.Location = new System.Drawing.Point(59, 9);
            this.TEXT_TITLE.Name = "TEXT_TITLE";
            this.TEXT_TITLE.OpenEnterBorder = true;
            this.TEXT_TITLE.OpenEnterForeColor = false;
            this.TEXT_TITLE.OpenFocusBorder = true;
            this.TEXT_TITLE.OpenFocusForeColor = false;
            this.TEXT_TITLE.OpenLeftText = true;
            this.TEXT_TITLE.OpenLeftTextColor = false;
            this.TEXT_TITLE.Size = new System.Drawing.Size(280, 14);
            this.TEXT_TITLE.TabIndex = 1;
            this.TEXT_TITLE.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // BT_SUBMIT
            // 
            this.BT_SUBMIT.Border_Open = true;
            this.BT_SUBMIT.Border_Size = 2F;
            this.BT_SUBMIT.Enter_Back_Color = System.Drawing.Color.Black;
            this.BT_SUBMIT.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.BT_SUBMIT.Enter_Fore_Color = System.Drawing.Color.Black;
            this.BT_SUBMIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_SUBMIT.Location = new System.Drawing.Point(14, 74);
            this.BT_SUBMIT.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BT_SUBMIT.MouseDownBorderColor = System.Drawing.Color.Black;
            this.BT_SUBMIT.MouseUpBackColor = System.Drawing.Color.Empty;
            this.BT_SUBMIT.MouseUpBorderColor = System.Drawing.Color.Black;
            this.BT_SUBMIT.Name = "BT_SUBMIT";
            this.BT_SUBMIT.OnMouseEnter_Open = true;
            this.BT_SUBMIT.OnMouseLeave_Open = true;
            this.BT_SUBMIT.OpenMouseDownBackColor = true;
            this.BT_SUBMIT.OpenMouseDownBorderColor = true;
            this.BT_SUBMIT.Out_Border_Color = System.Drawing.Color.Black;
            this.BT_SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.BT_SUBMIT.TabIndex = 2;
            this.BT_SUBMIT.Text = "确认";
            this.BT_SUBMIT.Text_Open = true;
            this.BT_SUBMIT.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.BT_SUBMIT.Click += new System.EventHandler(this.BT_SUBMIT_Click);
            // 
            // TEXT_URL
            // 
            this.TEXT_URL.BorderSize = 2;
            this.TEXT_URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_URL.EnterBorderColor = System.Drawing.Color.Black;
            this.TEXT_URL.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_URL.EnterLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_URL.FocusGotBorderColol = System.Drawing.Color.Black;
            this.TEXT_URL.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeftText = "";
            this.TEXT_URL.Location = new System.Drawing.Point(59, 39);
            this.TEXT_URL.Name = "TEXT_URL";
            this.TEXT_URL.OpenEnterBorder = true;
            this.TEXT_URL.OpenEnterForeColor = false;
            this.TEXT_URL.OpenFocusBorder = true;
            this.TEXT_URL.OpenFocusForeColor = false;
            this.TEXT_URL.OpenLeftText = true;
            this.TEXT_URL.OpenLeftTextColor = false;
            this.TEXT_URL.Size = new System.Drawing.Size(199, 14);
            this.TEXT_URL.TabIndex = 4;
            this.TEXT_URL.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "路径";
            // 
            // BT_EXIT
            // 
            this.BT_EXIT.Border_Open = true;
            this.BT_EXIT.Border_Size = 2F;
            this.BT_EXIT.Enter_Back_Color = System.Drawing.Color.Black;
            this.BT_EXIT.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.BT_EXIT.Enter_Fore_Color = System.Drawing.Color.Black;
            this.BT_EXIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_EXIT.Location = new System.Drawing.Point(264, 80);
            this.BT_EXIT.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BT_EXIT.MouseDownBorderColor = System.Drawing.Color.Black;
            this.BT_EXIT.MouseUpBackColor = System.Drawing.Color.Empty;
            this.BT_EXIT.MouseUpBorderColor = System.Drawing.Color.Black;
            this.BT_EXIT.Name = "BT_EXIT";
            this.BT_EXIT.OnMouseEnter_Open = true;
            this.BT_EXIT.OnMouseLeave_Open = true;
            this.BT_EXIT.OpenMouseDownBackColor = true;
            this.BT_EXIT.OpenMouseDownBorderColor = true;
            this.BT_EXIT.Out_Border_Color = System.Drawing.Color.Black;
            this.BT_EXIT.Size = new System.Drawing.Size(75, 23);
            this.BT_EXIT.TabIndex = 5;
            this.BT_EXIT.Text = "退出";
            this.BT_EXIT.Text_Open = true;
            this.BT_EXIT.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.BT_EXIT.Click += new System.EventHandler(this.BT_EXIT_Click);
            // 
            // BT_FILEOPEN
            // 
            this.BT_FILEOPEN.Border_Open = true;
            this.BT_FILEOPEN.Border_Size = 2F;
            this.BT_FILEOPEN.Enter_Back_Color = System.Drawing.Color.Black;
            this.BT_FILEOPEN.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.BT_FILEOPEN.Enter_Fore_Color = System.Drawing.Color.Black;
            this.BT_FILEOPEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_FILEOPEN.Location = new System.Drawing.Point(264, 29);
            this.BT_FILEOPEN.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BT_FILEOPEN.MouseDownBorderColor = System.Drawing.Color.Black;
            this.BT_FILEOPEN.MouseUpBackColor = System.Drawing.Color.Empty;
            this.BT_FILEOPEN.MouseUpBorderColor = System.Drawing.Color.Black;
            this.BT_FILEOPEN.Name = "BT_FILEOPEN";
            this.BT_FILEOPEN.OnMouseEnter_Open = true;
            this.BT_FILEOPEN.OnMouseLeave_Open = true;
            this.BT_FILEOPEN.OpenMouseDownBackColor = true;
            this.BT_FILEOPEN.OpenMouseDownBorderColor = true;
            this.BT_FILEOPEN.Out_Border_Color = System.Drawing.Color.Black;
            this.BT_FILEOPEN.Size = new System.Drawing.Size(75, 24);
            this.BT_FILEOPEN.TabIndex = 6;
            this.BT_FILEOPEN.Text = "打开文件";
            this.BT_FILEOPEN.Text_Open = true;
            this.BT_FILEOPEN.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.BT_FILEOPEN.Click += new System.EventHandler(this.BT_FILEOPEN_Click);
            // 
            // AddMainImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 115);
            this.Controls.Add(this.BT_FILEOPEN);
            this.Controls.Add(this.BT_EXIT);
            this.Controls.Add(this.TEXT_URL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_SUBMIT);
            this.Controls.Add(this.TEXT_TITLE);
            this.Controls.Add(this.label1);
            this.Name = "AddMainImageForm";
            this.Text = "AddMainImageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextBoxItem TEXT_TITLE;
        private ButtonItem BT_SUBMIT;
        private TextBoxItem TEXT_URL;
        private System.Windows.Forms.Label label2;
        private ButtonItem BT_EXIT;
        private ButtonItem BT_FILEOPEN;
    }
}