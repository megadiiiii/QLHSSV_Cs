using ClosedXML.Excel;
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
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Khóa");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 4).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH KHÓA ĐÀO TẠO";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Tên khóa", "Năm bắt đầu", "Năm kết thúc" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 4).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 4).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 4).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"select * from cohort
                                order by cohort_name asc";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int rowIndex = 5; //Số hàng bắt đầu ghi dữ liệu
                        int no = 1; //STT
                        while (reader.Read())
                        {
                            ws.Cell(rowIndex, 1).Value = no++;

                            //Các cột dữ liệu
                            ws.Cell(rowIndex, 2).Value = reader["cohort_name"].ToString();
                            ws.Cell(rowIndex, 3).Value = reader["cohort_start_year"].ToString();
                            ws.Cell(rowIndex, 4).Value = reader["cohort_end_year"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 4).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 4).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 4);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 4);

                        usedRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;


                    }
                }

                ws.Columns().AdjustToContents(); //Autofit content

                //Lưu file
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    sfd.Title = "Lưu danh sách";
                    sfd.FileName = "Danh_sach_khoa_dao_tao.xlsx"; // tên gợi ý

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file thành công!", "Thông báo");
                    }
                }
            }
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
