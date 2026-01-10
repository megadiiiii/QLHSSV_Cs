using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.Word;
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
    public partial class UC_KhenThuong : UserControl
    {
        public UC_KhenThuong()
        {
            InitializeComponent();
        }

        private string reward_id = null;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void loadTableReward()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                string sql = @"
                            select reward_id, r.student_id, s.student_lastName, s.student_firstName, class_name, reward_date, reward_quyetdinh, reward_note
                            from reward r
                            join student s on s.student_id = r.student_id
                            join class c on c.class_id = s.class_id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                dgvThongTin.AutoGenerateColumns = false;
                dgvThongTin.DataSource = dt;

                dgvMaSV.DataPropertyName = "student_id";
                dgvHoDem.DataPropertyName = "student_lastName";
                dgvTen.DataPropertyName = "student_firstName";
                dgvLop.DataPropertyName = "class_name";
                dgvDate.DataPropertyName = "reward_date";
                dgvQuyetDinh.DataPropertyName = "reward_quyetdinh";
                dgvLyDo.DataPropertyName = "reward_note";
                dgvRewardId.DataPropertyName = "reward_id";

                if (dgvThongTin.Columns["RewardId"] != null)
                {
                    dgvThongTin.Columns["RewardId"].Visible = false;
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string lyDo = txtLyDo.Text.Trim();
            DateTime? ngay = txtDate.Value;
            string qd = txtQuyetDinh.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(lyDo))
            {
                MessageBox.Show("Không được để trống dữ liệu");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO reward(student_id, reward_date, reward_note, reward_quyetdinh)
                           VALUES (@sv, @date, @note, @qd)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sv", maSV);
                        cmd.Parameters.AddWithValue("@date", ngay);
                        cmd.Parameters.AddWithValue("@note", lyDo);
                        cmd.Parameters.AddWithValue("@qd", qd);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Lưu khen thưởng thành công");
                            loadTableReward();
                            ClearInput();
                        }
                        else
                            MessageBox.Show("Lưu thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_KhenThuong_Load(object sender, EventArgs e)
        {
            loadTableReward();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvThongTin.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells["dgvMaSV"].Value?.ToString();
            txtLyDo.Text = row.Cells["dgvLyDo"].Value?.ToString();
            if (row.Cells["dgvDate"].Value != DBNull.Value)
            {
                txtDate.Value = Convert.ToDateTime(row.Cells["dgvDate"].Value);
            }
            txtQuyetDinh.Text = row.Cells["dgvQuyetDinh"].Value?.ToString();

           reward_id = row.Cells["dgvRewardId"].Value?.ToString();

            
        }
        public void ClearInput()
        {
            txtMaSV.Clear();
            txtLyDo.Clear();
            txtQuyetDinh.Clear();
            txtDate.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (reward_id == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa khen thưởng sinh viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"delete from reward where reward_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue(@"id", reward_id);
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Xóa khen thưởng thành công");
                                loadTableReward();
                                ClearInput();
                                reward_id = null;
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                    string maSV = txtMaSV.Text.Trim();
                    string lyDo = txtLyDo.Text.Trim();
                    string maQuyetDinh = txtQuyetDinh.Text.Trim();
                    DateTime? ngay = txtDate.Value;

            if (reward_id == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn sửa khen thưởng sinh viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();

                        string sql = @"UPDATE reward 
                           SET student_id = @sv,
                               reward_date = @date,
                               reward_note = @note,
                               reward_quyetdinh = @qdinh
                           WHERE reward_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@sv", maSV);
                            cmd.Parameters.AddWithValue("@date", ngay);
                            cmd.Parameters.AddWithValue("@note", lyDo);
                            cmd.Parameters.AddWithValue("@qdinh", maQuyetDinh);
                            cmd.Parameters.AddWithValue("@id", reward_id);

                            int row = cmd.ExecuteNonQuery();
                            MessageBox.Show(row > 0 ? "Cập nhật thành công" : "Cập nhật thất bại");
                        }
                    }

                    loadTableReward();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtMasvSearch.Text.Trim();
            string maQD = txtMaqdSearch.Text.Trim();

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT 
                    *
                FROM reward r
                JOIN student s ON s.student_id = r.student_id
                JOIN class c ON c.class_id = s.class_id
                WHERE (@maSV = '' OR s.student_id LIKE CONCAT('%', @maSV, '%'))
                  AND (@maQD = '' OR r.reward_quyetdinh LIKE CONCAT('%', @maQD, '%'))
            ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@maSV", maSV);
                        cmd.Parameters.AddWithValue("@maQD", maQD);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvThongTin.DataSource = dt;
                            dgvThongTin.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Khen thưởng");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 7).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH KHEN THƯỞNG";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã sinh viên", "Họ đệm", "Tên", "Lớp", "Ngày khen thưởng", "Quyết định số" };
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
                string sql = @"
                            select r.student_id, s.student_lastName, s.student_firstName, class_name, reward_date, reward_quyetdinh, reward_note
                            from reward r
                            join student s on s.student_id = r.student_id
                            join class c on c.class_id = s.class_id";
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
                            ws.Cell(rowIndex, 3).Value = reader["student_lastName"].ToString();
                            ws.Cell(rowIndex, 4).Value = reader["student_firstName"].ToString();
                          ws.Cell(rowIndex, 5).Value = reader["class_name"].ToString();
                            DateTime rewardDate = reader.GetDateTime("reward_date");
                            ws.Cell(rowIndex, 6).Value = rewardDate.ToString("dd/MM/yyyy");
                            ws.Cell(rowIndex, 7).Value = reader["reward_quyetdinh"].ToString();


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
                    sfd.Title = "Lưu danh sách khen thưởng";
                    sfd.FileName = "Danh_sach_khen_thuong.xlsx"; // tên gợi ý

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file thành công!", "Thông báo");
                    }
                }
            }
        }
    }
}
