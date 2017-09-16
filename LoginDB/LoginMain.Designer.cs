namespace LoginDB
{
    partial class LoginMain
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
            this.btn_setingDB = new System.Windows.Forms.Button();
            this.userControl_login = new LoginControl_GUI_UserControl.UserControl1();
            this.SuspendLayout();
            // 
            // btn_setingDB
            // 
            this.btn_setingDB.Location = new System.Drawing.Point(244, 205);
            this.btn_setingDB.Name = "btn_setingDB";
            this.btn_setingDB.Size = new System.Drawing.Size(75, 23);
            this.btn_setingDB.TabIndex = 1;
            this.btn_setingDB.Text = "Setting DB";
            this.btn_setingDB.UseVisualStyleBackColor = true;
            this.btn_setingDB.Click += new System.EventHandler(this.btn_setingDB_Click);
            // 
            // userControl_login
            // 
            this.userControl_login.Location = new System.Drawing.Point(12, 12);
            this.userControl_login.Name = "userControl_login";
            this.userControl_login.Size = new System.Drawing.Size(307, 187);
            this.userControl_login.TabIndex = 2;
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 243);
            this.Controls.Add(this.userControl_login);
            this.Controls.Add(this.btn_setingDB);
            this.Name = "LoginMain";
            this.Text = "LoginMain";
            this.Load += new System.EventHandler(this.LoginMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_setingDB;
        private LoginControl_GUI_UserControl.UserControl1 userControl_login;
    }
}