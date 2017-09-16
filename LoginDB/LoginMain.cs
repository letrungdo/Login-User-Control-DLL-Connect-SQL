using System;
using System.Windows.Forms;


namespace LoginDB
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
            
        }
        
        
        private void btn_setingDB_Click(object sender, EventArgs e)
        {
            LoginDB f = new LoginDB();
            f.ShowDialog();
        }

        private void LoginMain_Load(object sender, EventArgs e)
        {
            userControl_login.connectString = Properties.Settings.Default.connectString;
        }
    }
}
