namespace LoginDB
{
    partial class LoginDB
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.cbo_ServerName = new System.Windows.Forms.ComboBox();
            this.cbo_Auth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_DbName = new System.Windows.Forms.ComboBox();
            this.chk_rememberPass = new System.Windows.Forms.CheckBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(214, 184);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(214, 100);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(166, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(214, 126);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(166, 20);
            this.txt_Pass.TabIndex = 2;
            // 
            // cbo_ServerName
            // 
            this.cbo_ServerName.FormattingEnabled = true;
            this.cbo_ServerName.Location = new System.Drawing.Point(214, 34);
            this.cbo_ServerName.Name = "cbo_ServerName";
            this.cbo_ServerName.Size = new System.Drawing.Size(166, 21);
            this.cbo_ServerName.TabIndex = 3;
            this.cbo_ServerName.DropDown += new System.EventHandler(this.cbo_ServerName_DropDown);
            this.cbo_ServerName.SelectedIndexChanged += new System.EventHandler(this.cbo_ServerName_SelectedIndexChanged);
            // 
            // cbo_Auth
            // 
            this.cbo_Auth.FormattingEnabled = true;
            this.cbo_Auth.Location = new System.Drawing.Point(214, 61);
            this.cbo_Auth.Name = "cbo_Auth";
            this.cbo_Auth.Size = new System.Drawing.Size(166, 21);
            this.cbo_Auth.TabIndex = 4;
            this.cbo_Auth.SelectedIndexChanged += new System.EventHandler(this.cbo_Auth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Authentication:";
            // 
            // cbo_DbName
            // 
            this.cbo_DbName.FormattingEnabled = true;
            this.cbo_DbName.Location = new System.Drawing.Point(214, 236);
            this.cbo_DbName.Name = "cbo_DbName";
            this.cbo_DbName.Size = new System.Drawing.Size(166, 21);
            this.cbo_DbName.TabIndex = 9;
            this.cbo_DbName.DropDown += new System.EventHandler(this.cbo_DbName_DropDown);
            this.cbo_DbName.SelectedIndexChanged += new System.EventHandler(this.cbo_DbName_SelectedIndexChanged);
            // 
            // chk_rememberPass
            // 
            this.chk_rememberPass.AutoSize = true;
            this.chk_rememberPass.Location = new System.Drawing.Point(214, 152);
            this.chk_rememberPass.Name = "chk_rememberPass";
            this.chk_rememberPass.Size = new System.Drawing.Size(125, 17);
            this.chk_rememberPass.TabIndex = 11;
            this.chk_rememberPass.Text = "Remember password";
            this.chk_rememberPass.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(214, 263);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 12;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // LoginDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.chk_rememberPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_DbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Auth);
            this.Controls.Add(this.cbo_ServerName);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginDB";
            this.Text = "Login DB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginDB_FormClosing);
            this.Load += new System.EventHandler(this.LoginDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.ComboBox cbo_ServerName;
        private System.Windows.Forms.ComboBox cbo_Auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_DbName;
        private System.Windows.Forms.CheckBox chk_rememberPass;
        private System.Windows.Forms.Button btn_Connect;
    }
}

