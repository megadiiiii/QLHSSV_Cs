using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class UC_Cohort : UserControl
    {
        public UC_Cohort()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cohortName = txtCohortName.Text.Trim();
            string cohortStartStr = txtStartYear.Text.Trim();
            string cohortEndStr = txtEndYear.Text.Trim();

            if (string.IsNullOrEmpty(cohortName) ||
                string.IsNullOrEmpty(cohortStartStr) ||
                string.IsNullOrEmpty(cohortEndStr))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            int cohortStartYear, cohortEndYear;
            try
            {
                cohortStartYear = int.Parse(cohortStartStr);
                cohortEndYear = int.Parse(cohortEndStr);
            }
            catch
            {
                MessageBox.Show("Năm bắt đầu/kết thúc phải là số");
                return;
            }

            if (cohortStartYear < 1900 || cohortStartYear > 3000 ||
                cohortEndYear < 1900 || cohortEndYear > 3000)
            {
                MessageBox.Show("Năm không hợp lệ");
                return;
            }

            if (cohortEndYear < cohortStartYear)
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm nhập học");
                return;
            }

            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO cohort 
                           (cohort_name, cohort_start_year, cohort_end_year)
                           VALUES (@name, @start, @end)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", cohortName);
                        cmd.Parameters.AddWithValue("@start", cohortStartYear);
                        cmd.Parameters.AddWithValue("@end", cohortEndYear);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            loadTable();
                            clearInput();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void loadTable()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = @"select * from cohort
                                order by cohort_name asc";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                dgvCohortName.DataPropertyName = "cohort_name";
                dgvStartDate.DataPropertyName = "cohort_start_year";
                dgvEndDate.DataPropertyName = "cohort_end_year";
                dgvCohort.DataSource = dt;
                dgvCohort.Refresh();
                dgvCohort.Columns["cohort_id"].Visible = false;
            }
        }

        private void UC_Cohort_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void clearInput()
        {
            txtCohortName.Text = "";
            txtStartYear.Text = "";
            txtEndYear.Text = "";
        }

        private void dgvCohort_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvCohort.Rows[e.RowIndex];
            txtCohortName.Text = row.Cells["dgvCohortName"].Value?.ToString();
            txtStartYear.Text = row.Cells["dgvStartDate"].Value?.ToString();
            txtEndYear.Text = row.Cells["dgvEndDate"].Value?.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCohort.CurrentRow == null) return; // ko có row thì thoát

            // Lấy ID cohort đang chọn
            string cohortId = dgvCohort.CurrentRow.Cells["cohort_id"].Value.ToString();

            // Lấy thông tin mới
            string cohortName = txtCohortName.Text.Trim();
            string startStr = txtStartYear.Text.Trim();
            string endStr = txtEndYear.Text.Trim();

            if (string.IsNullOrEmpty(cohortName) || string.IsNullOrEmpty(startStr) || string.IsNullOrEmpty(endStr))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(startStr, out int startYear) || !int.TryParse(endStr, out int endYear))
            {
                MessageBox.Show("Năm phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startYear < 1900 || endYear > 3000 || endYear < startYear)
            {
                MessageBox.Show("Năm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update vào DB
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE cohort 
                       SET cohort_name=@name, cohort_start_year=@start, cohort_end_year=@end 
                       WHERE cohort_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", cohortName);
                    cmd.Parameters.AddWithValue("@start", startYear);
                    cmd.Parameters.AddWithValue("@end", endYear);
                    cmd.Parameters.AddWithValue("@id", cohortId);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadTable();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCohort.CurrentRow == null) return;

            string cohortId = dgvCohort.CurrentRow
                                        .Cells["cohort_id"]
                                        .Value
                                        .ToString();

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();

                        string sql = "DELETE FROM cohort WHERE cohort_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", cohortId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            loadTable();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtCohortNameSearch.Text.Trim();
            string start = txtStartYearSearch.Text.Trim();
            string end = txtEndYearSearch.Text.Trim();

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql = @"SELECT * FROM cohort
                           WHERE (@name = '' OR cohort_name LIKE @name)
                             AND (@start = '' OR cohort_start_year LIKE @start)
                             AND (@end = '' OR cohort_end_year LIKE @end)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        cmd.Parameters.AddWithValue("@start", "%" + start + "%");
                        cmd.Parameters.AddWithValue("@end", "%" + end + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvCohort.DataSource = dt;
                            dgvCohort.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
