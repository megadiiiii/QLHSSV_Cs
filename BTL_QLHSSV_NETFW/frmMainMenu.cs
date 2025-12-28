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
    public partial class frmMainMenu : Form
    {
        private Form loginForm;
        public frmMainMenu()
        {
            InitializeComponent();

            this.ActiveControl = null;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void navDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.BringToFront();
        }

        private void navTeacher_Click(object sender, EventArgs e)
        {

        }

        private void navFaculties_Click(object sender, EventArgs e)
        {
            uC_Faculties1.BringToFront();
        }


        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navStudent_Click(object sender, EventArgs e)
        {
            uC_Student1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void navClass_Click(object sender, EventArgs e)
        {
            uC_Class1.BringToFront();
        }

        private void navMajor_Click(object sender, EventArgs e)
        {
            uC_Major1.BringToFront();
        }

        private void navKhenThuong_Click(object sender, EventArgs e)
        {
            uC_KhenThuong1.BringToFront();
        }

        private void navKyLuat_Click(object sender, EventArgs e)
        {
            uC_KyLuat1.BringToFront();
        }
    }
}
