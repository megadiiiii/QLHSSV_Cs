using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Syncfusion.WinForms.ListView.Enums;
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
    public partial class UC_Suspension : UserControl
    {
        public UC_Suspension()
        {
            InitializeComponent();
        }

        private void UC_Suspension_Load(object sender, EventArgs e)
        {
            loadTable();
            LoadStudentId();
        }

        public void loadTable()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = @"SELECT suspension_id, s.student_id,
                                    CONCAT(s.student_lastName, ' ', s.student_firstName) AS student_name,
                                    startdate,enddate, reason, sp.status
                               FROM suspension sp      
                               JOIN student s on s.student_id = sp.student_id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                dgvSus.AutoGenerateColumns = false;

                dgvStudentID.DataPropertyName = "student_id";
                dgvStudentName.DataPropertyName = "student_name";
                dgvStartDate.DataPropertyName = "startdate";
                dgvEndDate.DataPropertyName = "enddate";
                dgvReason.DataPropertyName = "reason";
                dgvSusStatus.DataPropertyName = "status";
                dgvId.DataPropertyName = "suspension_id";
                dgvSus.DataSource = dt;
                dgvSus.Refresh();

                dgvId.Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Bảo lưu");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 7).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH BẢO LƯU";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã SV", "Tên SV", "Ngày bắt đầu", "Ngày kết thúc", "Lý do", "Trạng thái" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 7).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 7).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 7).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"SELECT suspension_id, s.student_id,
                                    CONCAT(s.student_lastName, ' ', s.student_firstName) AS student_name,
                                    startdate,enddate, reason, sp.status
                               FROM suspension sp      
                               JOIN student s on s.student_id = sp.student_id";
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
                            ws.Cell(rowIndex, 2).Value = reader["student_id"].ToString();
                            ws.Cell(rowIndex, 3).Value = reader["student_name"].ToString();
                            if (reader["startdate"] != DBNull.Value)
                            {
                                DateTime dob = Convert.ToDateTime(reader["startdate"]);
                                ws.Cell(rowIndex, 4).Value = dob.ToString("dd/MM/yyyy");
                            }
                            if (reader["enddate"] != DBNull.Value)
                            {
                                DateTime dob = Convert.ToDateTime(reader["enddate"]);
                                ws.Cell(rowIndex, 5).Value = dob.ToString("dd/MM/yyyy");
                            }
                            ws.Cell(rowIndex, 6).Value = reader["reason"].ToString();
                            ws.Cell(rowIndex, 7).Value = reader["status"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 7).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 7).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 7);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 7);

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
                    sfd.FileName = "Danh_sach_bao_luu.xlsx"; // tên gợi ý

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file thành công!", "Thông báo");
                    }
                }
            }
        }

        private void dgvSus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvSus.Rows[e.RowIndex];

            cboStudentId.Text = row.Cells["dgvStudentId"].Value?.ToString();
            txtFullName.Text = row.Cells["dgvStudentName"].Value?.ToString();
            if (row.Cells["dgvStartDate"].Value != DBNull.Value)
            {
                txtStartDate.Value = Convert.ToDateTime(row.Cells["dgvStartDate"].Value);
            }
            if (row.Cells["dgvEndDate"].Value != DBNull.Value)
            {
                txtEndYear.Value = Convert.ToDateTime(row.Cells["dgvEndDate"].Value);
            }
            cboSusStatus.Text = row.Cells["dgvSusStatus"].Value?.ToString();
            txtReason.Text = row.Cells["dgvReason"].Value?.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudentId.SelectedValue == null)
            {
                MessageBox.Show("Chọn MSSV");
                return;
            }

            if (cboSusStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn trạng thái");
                return;
            }

            if (!txtStartDate.Value.HasValue || !txtEndYear.Value.HasValue)
            {
                MessageBox.Show("Chọn đủ ngày");
                return;
            }

            if (txtEndYear.Value <= txtStartDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }

            string reason = txtReason.Text.Trim();
            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Nhập lý do đình chỉ");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"INSERT INTO suspension 
                           (student_id, startdate, enddate, reason, status)
                           VALUES (@student_id, @startdate, @enddate, @reason, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@student_id", MySqlDbType.VarChar).Value = cboStudentId.SelectedValue.ToString();
                        cmd.Parameters.Add("@startdate", MySqlDbType.Date).Value = txtStartDate.Value.Value;
                        cmd.Parameters.Add("@enddate", MySqlDbType.Date).Value = txtEndYear.Value.Value;
                        cmd.Parameters.Add("@reason", MySqlDbType.VarChar).Value = reason;
                        cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cboSusStatus.SelectedItem.ToString();

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                loadTable();
                MessageBox.Show("Lưu đình chỉ thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadStudentId()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"
                SELECT 
                    s.student_id,
                    CONCAT(s.student_lastName, ' ', s.student_firstName) AS student_name
                FROM student s
                ORDER BY s.student_id ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboStudentId.DataSource = dt;
                cboStudentId.DisplayMember = "student_id";   // hiện mã
                cboStudentId.ValueMember = "student_id";     // value là mã

                // Auto complete
                cboStudentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboStudentId.AutoCompleteSuggestMode = AutoCompleteSuggestMode.Contains;

                cboStudentId.SelectedIndex = -1;
                txtFullName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cboStudentId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboStudentId.SelectedItem is DataRowView row)
            {
                txtFullName.Text = row["student_name"].ToString();
            }
            else
            {
                txtFullName.Clear();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateStatusFromGrid("Đã duyệt");
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateStatusFromGrid("Bị từ chối");
        }

        private void UpdateStatusFromGrid(string status)
        {
            if (dgvSus.CurrentRow == null)
            {
                MessageBox.Show("Chọn một dòng trước đã!");
                return;
            }

            DataGridViewRow row = dgvSus.CurrentRow;

            int suspensionId = Convert.ToInt32(row.Cells["dgvId"].Value);

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = @"UPDATE suspension 
                       SET status = @status 
                       WHERE suspension_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", suspensionId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật trạng thái thành công!");
            loadTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSus.CurrentCell == null)
            {
                MessageBox.Show("Chọn dòng để xóa");
                return;
            }

            int rowIndex = dgvSus.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Dòng không hợp lệ");
                return;
            }

            DataGridViewRow row = dgvSus.Rows[rowIndex];

            int suspensionId = Convert.ToInt32(row.Cells["dgvId"].Value);

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa bản ghi này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = @"DELETE FROM suspension
                       WHERE suspension_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", suspensionId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Xóa thành công!");
            loadTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                StringBuilder sql = new StringBuilder(@"
        SELECT 
            suspension_id,
            s.student_id,
            CONCAT(s.student_lastName, ' ', s.student_firstName) AS student_name,
            startdate,
            enddate,
            reason,
            sp.status
        FROM suspension sp
        JOIN student s ON s.student_id = sp.student_id
        WHERE 1 = 1
        ");

                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn))
                {
                    string studentId = txtStudentIdSearch.Text.Trim();
                    if (!string.IsNullOrEmpty(studentId))
                    {
                        sql.Append(" AND s.student_id LIKE @studentId");
                        cmd.Parameters.AddWithValue("@studentId", "%" + studentId + "%");
                    }

                    if (cboSusStatusSearch.SelectedIndex >= 0)
                    {
                        sql.Append(" AND sp.status = @status");
                        cmd.Parameters.AddWithValue(
                            "@status",
                            cboSusStatusSearch.SelectedItem.ToString()
                        );
                    }

                    cmd.CommandText = sql.ToString();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dgvSus.DataSource = dt;
        }

    }
}
