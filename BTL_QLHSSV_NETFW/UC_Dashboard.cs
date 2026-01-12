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

        private int CountTable(string tableName)
        {
            int total = 0;
            try
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        total = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đếm dữ liệu bảng {tableName}: " + ex.Message);
            }
            return total;
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            int totalStudents = CountTable("student");

            txtFacuCount.Text = CountTable("faculties").ToString();
            txtMajorCount.Text = CountTable("major").ToString();
            txtCohortCount.Text = CountTable("cohort").ToString();
            txtClassCount.Text = CountTable("class").ToString();
            txtStudentCount.Text = totalStudents.ToString();
            txtRoleCount.Text = CountTable("role").ToString();
            txtTeacherCount.Text = CountTable("teacher").ToString();

            txtRewardCount.Text = CountTable("reward").ToString();
            txtDiscCount.Text = CountTable("kyluat").ToString();
            txtScholarCount.Text = CountTable("scholarship").ToString();
            txtSusCount.Text = CountTable("suspension").ToString();

            double rewardPercent = CalcPercent("reward", totalStudents);
            double discPercent = CalcPercent("kyluat", totalStudents);
            double scholarPercent = CalcPercent("scholarship", totalStudents);
            double susPercent = CalcPercent("suspension", totalStudents);

            txtRewardPercent.Text = "Chiếm " + rewardPercent.ToString("F2") + " %" + " tống số sinh viên";
            txtDiscPercent.Text = "Chiếm " + discPercent.ToString("F2") + " %" + " tống số sinh viên";
            txtScholarPercent.Text = "Chiếm " + scholarPercent.ToString("F2") + " %" + " tống số sinh viên";
            txtSusPercent.Text = "Chiếm " + susPercent.ToString("F2") + " %" + " tống số sinh viên";
        }


        private double CalcPercent(string targetTable, int totalStudents)
        {
            if (totalStudents <= 0) return 0;

            int count = CountTable(targetTable);
            return (double)count / totalStudents * 100;
        }
    }
}
