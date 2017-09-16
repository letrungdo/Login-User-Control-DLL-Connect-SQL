using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestConnect_NoGui;

namespace LoginControl_GUI_UserControl
{
    public partial class UserControl1: UserControl
    {

        dbTestConnect con;
        public string connectString="";

        public UserControl1()
        {
            InitializeComponent();
        }

        
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            con = new dbTestConnect(connectString);

            if (txt_User.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Pass.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Connect();

                string selectString = string.Format("SELECT * FROM Account WHERE Username='{0}' and Password='{1}'",
                    txt_User.Text, txt_Pass.Text);


                if (con.testConnect(selectString) == 1)
                    MessageBox.Show("Login Success!");
                else MessageBox.Show("Login Fail");
                

                con.Disconnet();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Sai tên máy chủ" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
