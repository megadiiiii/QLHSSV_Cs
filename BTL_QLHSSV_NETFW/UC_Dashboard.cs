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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        //private void UC_Dashboard_Load(object sender, EventArgs e)
        //{
        //    txtStudentCount.Text = StudentCount().ToString();
        //    txtFacuCnt.Text = FacuCount().ToString();
        //    txtMajorCnt.Text = MajorCount().ToString();
        //    txtClassCnt.Text = ClassCount().ToString();
        //    txtKT.Text = RewardCount().ToString();
        //    txtKL.Text = KLCount().ToString();
        //}

        //private int StudentCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM student";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sinh viên: " + ex.Message);
        //    }
        //    return total;
        //}

        //private int FacuCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM faculties";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm khoa: " + ex.Message);
        //    }
        //    return total;
        //}

        //private int MajorCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM major";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sinh viên: " + ex.Message);
        //    }
        //    return total;
        //}

        //private int ClassCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM class";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm lớp: " + ex.Message);
        //    }
        //    return total;
        //}

        //private int RewardCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM reward";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sinh viên: " + ex.Message);
        //    }
        //    return total;
        //}

        //private int KLCount()
        //{
        //    int total = 0;
        //    try
        //    {
        //        String query = "SELECT COUNT(*) FROM kyluat";
        //        using (MySqlConnection conn = dbConn.GetConnection())
        //        {
        //            conn.Open();
        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                total = Convert.ToInt32(cmd.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sinh viên: " + ex.Message);
        //    }
        //    return total;
        //}
    }
}
