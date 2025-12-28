using MySql.Data.MySqlClient;
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string fullname = string.Empty;
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = "SELECT fullname FROM account WHERE username = @username AND password = @password";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullname = reader["fullname"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show($"Đăng nhập thành công!\nXin chào {fullname}",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmMainMenu main = new frmMainMenu();
                main.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
