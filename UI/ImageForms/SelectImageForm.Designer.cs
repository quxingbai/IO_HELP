namespace UI.ImageForms
{
    partial class SelectImageForm
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
            this.BUTTON_CLEAR = new ITEM.ButtonItem();
            this.BUTTON_SELECT = new ITEM.ButtonItem();
            this.TEXT_TIME = new ITEM.TextBoxItem();
            this.TEXT_URL = new ITEM.TextBoxItem();
            this.TEXT_NAME = new ITEM.TextBoxItem();
            this.TEXT_ID = new ITEM.TextBoxItem();
            this.SuspendLayout();
            // 
            // BUTTON_CLEAR
            // 
            this.BUTTON_CLEAR.Border_Open = true;
            this.BUTTON_CLEAR.Border_Size = 2F;
            this.BUTTON_CLEAR.Enter_Back_Color = System.Drawing.Color.Black;
            this.BUTTON_CLEAR.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.BUTTON_CLEAR.Enter_Fore_Color = System.Drawing.Color.Black;
            this.BUTTON_CLEAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BUTTON_CLEAR.Location = new System.Drawing.Point(215, 168);
            this.BUTTON_CLEAR.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BUTTON_CLEAR.MouseDownBorderColor = System.Drawing.Color.Black;
            this.BUTTON_CLEAR.MouseUpBackColor = System.Drawing.Color.Empty;
            this.BUTTON_CLEAR.MouseUpBorderColor = System.Drawing.Color.Black;
            this.BUTTON_CLEAR.Name = "BUTTON_CLEAR";
            this.BUTTON_CLEAR.OnMouseEnter_Open = true;
            this.BUTTON_CLEAR.OnMouseLeave_Open = true;
            this.BUTTON_CLEAR.OpenMouseDownBackColor = true;
            this.BUTTON_CLEAR.OpenMouseDownBorderColor = true;
            this.BUTTON_CLEAR.Out_Border_Color = System.Drawing.Color.Black;
            this.BUTTON_CLEAR.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_CLEAR.TabIndex = 6;
            this.BUTTON_CLEAR.Text = "清除";
            this.BUTTON_CLEAR.Text_Open = true;
            this.BUTTON_CLEAR.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.BUTTON_CLEAR.Click += new System.EventHandler(this.BUTTON_CLEAR_Click);
            // 
            // BUTTON_SELECT
            // 
            this.BUTTON_SELECT.Border_Open = true;
            this.BUTTON_SELECT.Border_Size = 2F;
            this.BUTTON_SELECT.Enter_Back_Color = System.Drawing.Color.Black;
            this.BUTTON_SELECT.Enter_Border_Color = System.Drawing.Color.Yellow;
            this.BUTTON_SELECT.Enter_Fore_Color = System.Drawing.Color.Black;
            this.BUTTON_SELECT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BUTTON_SELECT.Location = new System.Drawing.Point(42, 168);
            this.BUTTON_SELECT.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BUTTON_SELECT.MouseDownBorderColor = System.Drawing.Color.Black;
            this.BUTTON_SELECT.MouseUpBackColor = System.Drawing.Color.Empty;
            this.BUTTON_SELECT.MouseUpBorderColor = System.Drawing.Color.Black;
            this.BUTTON_SELECT.Name = "BUTTON_SELECT";
            this.BUTTON_SELECT.OnMouseEnter_Open = true;
            this.BUTTON_SELECT.OnMouseLeave_Open = true;
            this.BUTTON_SELECT.OpenMouseDownBackColor = true;
            this.BUTTON_SELECT.OpenMouseDownBorderColor = true;
            this.BUTTON_SELECT.Out_Border_Color = System.Drawing.Color.Black;
            this.BUTTON_SELECT.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_SELECT.TabIndex = 5;
            this.BUTTON_SELECT.Text = "查找";
            this.BUTTON_SELECT.Text_Open = true;
            this.BUTTON_SELECT.TextStyle = ITEM.SuperItem.TextStyle_Enum.Center;
            this.BUTTON_SELECT.Click += new System.EventHandler(this.BUTTON_SELECT_Click);
            // 
            // TEXT_TIME
            // 
            this.TEXT_TIME.BorderSize = 4;
            this.TEXT_TIME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_TIME.EnterBorderColor = System.Drawing.Color.Lime;
            this.TEXT_TIME.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_TIME.EnterLeftTextColor = System.Drawing.Color.Fuchsia;
            this.TEXT_TIME.FocusGotBorderColol = System.Drawing.Color.Fuchsia;
            this.TEXT_TIME.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_TIME.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_TIME.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_TIME.LeftText = "时间";
            this.TEXT_TIME.Location = new System.Drawing.Point(42, 117);
            this.TEXT_TIME.Name = "TEXT_TIME";
            this.TEXT_TIME.OpenEnterBorder = true;
            this.TEXT_TIME.OpenEnterForeColor = false;
            this.TEXT_TIME.OpenFocusBorder = true;
            this.TEXT_TIME.OpenFocusForeColor = false;
            this.TEXT_TIME.OpenLeftText = true;
            this.TEXT_TIME.OpenLeftTextColor = true;
            this.TEXT_TIME.Size = new System.Drawing.Size(248, 14);
            this.TEXT_TIME.TabIndex = 4;
            this.TEXT_TIME.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // TEXT_URL
            // 
            this.TEXT_URL.BorderSize = 4;
            this.TEXT_URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_URL.EnterBorderColor = System.Drawing.Color.Lime;
            this.TEXT_URL.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_URL.EnterLeftTextColor = System.Drawing.Color.Fuchsia;
            this.TEXT_URL.FocusGotBorderColol = System.Drawing.Color.Fuchsia;
            this.TEXT_URL.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_URL.LeftText = "位置";
            this.TEXT_URL.Location = new System.Drawing.Point(42, 84);
            this.TEXT_URL.Name = "TEXT_URL";
            this.TEXT_URL.OpenEnterBorder = true;
            this.TEXT_URL.OpenEnterForeColor = false;
            this.TEXT_URL.OpenFocusBorder = true;
            this.TEXT_URL.OpenFocusForeColor = false;
            this.TEXT_URL.OpenLeftText = true;
            this.TEXT_URL.OpenLeftTextColor = true;
            this.TEXT_URL.Size = new System.Drawing.Size(248, 14);
            this.TEXT_URL.TabIndex = 3;
            this.TEXT_URL.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // TEXT_NAME
            // 
            this.TEXT_NAME.BorderSize = 4;
            this.TEXT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_NAME.EnterBorderColor = System.Drawing.Color.Lime;
            this.TEXT_NAME.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_NAME.EnterLeftTextColor = System.Drawing.Color.Fuchsia;
            this.TEXT_NAME.FocusGotBorderColol = System.Drawing.Color.Fuchsia;
            this.TEXT_NAME.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_NAME.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_NAME.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_NAME.LeftText = "名称";
            this.TEXT_NAME.Location = new System.Drawing.Point(42, 53);
            this.TEXT_NAME.Name = "TEXT_NAME";
            this.TEXT_NAME.OpenEnterBorder = true;
            this.TEXT_NAME.OpenEnterForeColor = false;
            this.TEXT_NAME.OpenFocusBorder = true;
            this.TEXT_NAME.OpenFocusForeColor = false;
            this.TEXT_NAME.OpenLeftText = true;
            this.TEXT_NAME.OpenLeftTextColor = true;
            this.TEXT_NAME.Size = new System.Drawing.Size(248, 14);
            this.TEXT_NAME.TabIndex = 2;
            this.TEXT_NAME.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Text_TextBox;
            // 
            // TEXT_ID
            // 
            this.TEXT_ID.BorderSize = 4;
            this.TEXT_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_ID.EnterBorderColor = System.Drawing.Color.Lime;
            this.TEXT_ID.EnterForeColor = System.Drawing.Color.Black;
            this.TEXT_ID.EnterLeftTextColor = System.Drawing.Color.Fuchsia;
            this.TEXT_ID.FocusGotBorderColol = System.Drawing.Color.Fuchsia;
            this.TEXT_ID.FocusGotForeColor = System.Drawing.Color.Black;
            this.TEXT_ID.LeaveBorderColor = System.Drawing.Color.Black;
            this.TEXT_ID.LeaveLeftTextColor = System.Drawing.Color.Black;
            this.TEXT_ID.LeftText = "ID";
            this.TEXT_ID.Location = new System.Drawing.Point(42, 21);
            this.TEXT_ID.Name = "TEXT_ID";
            this.TEXT_ID.OpenEnterBorder = true;
            this.TEXT_ID.OpenEnterForeColor = false;
            this.TEXT_ID.OpenFocusBorder = true;
            this.TEXT_ID.OpenFocusForeColor = false;
            this.TEXT_ID.OpenLeftText = true;
            this.TEXT_ID.OpenLeftTextColor = true;
            this.TEXT_ID.Size = new System.Drawing.Size(248, 14);
            this.TEXT_ID.TabIndex = 1;
            this.TEXT_ID.TextBoxStyle = ITEM.TextBoxItem.TextBoxStyle_Enum.Int_TextBox;
            // 
            // SelectImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 209);
            this.Controls.Add(this.BUTTON_CLEAR);
            this.Controls.Add(this.BUTTON_SELECT);
            this.Controls.Add(this.TEXT_TIME);
            this.Controls.Add(this.TEXT_URL);
            this.Controls.Add(this.TEXT_NAME);
            this.Controls.Add(this.TEXT_ID);
            this.Name = "SelectImageForm";
            this.Text = "SelectImageForm";
            this.Load += new System.EventHandler(this.SelectImageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ITEM.TextBoxItem TEXT_ID;
        private ITEM.TextBoxItem TEXT_NAME;
        private ITEM.TextBoxItem TEXT_URL;
        private ITEM.TextBoxItem TEXT_TIME;
        private ITEM.ButtonItem BUTTON_SELECT;
        private ITEM.ButtonItem BUTTON_CLEAR;
    }
}