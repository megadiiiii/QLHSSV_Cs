using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLHSSV_NETFW
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void AutoSelectAll(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
                tb.SelectAll();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnShowHidePassword.Image = IconResource.password_show;
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    this.Hide();   // ẩn login, KHÔNG dispose

            //    frmMainMenu main = new frmMainMenu();
            //    main.ShowDialog(); // chạy modal, chặn ở đây

            //    this.Show();  // khi MainMenu đóng → quay lại login
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsername.Focus();
            //}
            this.Hide();   // ẩn login, KHÔNG dispose

            frmMainMenu main = new frmMainMenu();
            main.ShowDialog(); // chạy modal, chặn ở đây
            this.Show();  // khi MainMenu đóng → quay lại login
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sfButton1_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar)
            {
                btnShowHidePassword.Image = IconResource.password_show;  // đang ẩn
            }
            else
            {
                btnShowHidePassword.Image = IconResource.password_hide;  // đang hiện
            }
        }
    }
}
