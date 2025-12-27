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

        private void uC_Student1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void navClass_Click(object sender, EventArgs e)
        {
                
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
