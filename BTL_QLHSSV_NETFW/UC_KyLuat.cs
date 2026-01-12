using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
namespace BTL_QLHSSV_NETFW
{
    public partial class UC_KyLuat : UserControl
    {
        private const string student = "student";
        private const string kyluat = "kyluat";
        private const string student_id = "student_id";
        private const string sutdent_lastname = "student_lastName";
        private const string sutdent_firstname = "student_firstName";
        private const string kyluat_id = "idkyluat";       
        private const string student_id_kyuat = "student_id";
        private const string hinhthuc = "hinhThuc";
        private const string soquyetdinh = "soQuyetDinh";
        private const string lydo = "lyDo";
        private const string kyluat_Date = "kyluat_date";
        private const string kyluat_ketthuc = "ngayKetThuc";
        private DataTable _dtStudents;
        public UC_KyLuat()
        {
            InitializeComponent();

        }
        private void UC_KyLuat_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            dtgvKyLuat.ReadOnly = true;
            dtgvKyLuat.AllowUserToAddRows = false;
            dtgvKyLuat.AutoGenerateColumns = false; 
            txtKyLuatId.ReadOnly = true;
            txtTenSinhVien.ReadOnly = true;
            txtTenSinhVien.Enabled = false;
            cboStudentId.DropDownStyle = ComboBoxStyle.DropDown;
            cboStudentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStudentId.AutoCompleteSource = AutoCompleteSource.ListItems; 
            cboStudentId.IntegralHeight = false;
            cboStudentId.DropDownHeight = 200;
            LoadHinhThuc();
            LoadStudentCombos();
            LoadTable();
            ResetForm();
        }
        private void LoadHinhThuc()
        {
            cbbKyLuatType.Items.Clear();
            cbbKyLuatType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbKyLuatType.Items.AddRange(new object[]
            {
                "Khiển trách",
                "Cảnh cáo",
                "Đình chỉ học tập",
                "Buộc thôi học"
            });

            cbbKyLuatType.SelectedIndex = -1;
        }
        private void LoadStudentCombos()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = $@"
                        SELECT 
                            {student_id},
                            CONCAT({sutdent_lastname}, ' ', {sutdent_firstname}) AS full_name
                        FROM {student}
                        ORDER BY {student_id};
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        _dtStudents = new DataTable();
                        da.Fill(_dtStudents);

                        // bind mã sv để click xổ ra danh sách như cũ
                        cboStudentId.DataSource = _dtStudents;
                        cboStudentId.DisplayMember = student_id;
                        cboStudentId.ValueMember = student_id;
                        cboStudentId.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load sinh viên lỗi: " + ex.Message); 
            }
        }
        private void cboStudentId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SyncStudentNameById((cboStudentId.Text ?? "").Trim());
        }
        private void cboStudentId_TextChanged(object sender, EventArgs e)
        {
            SyncStudentNameById((cboStudentId.Text ?? "").Trim());
        }
        private void SyncStudentNameById(string stuId)
        {
            if (_dtStudents == null)
            {
                txtTenSinhVien.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(stuId))
            {
                txtTenSinhVien.Text = "";
                return;
            }
            string safe = stuId.Replace("'", "''");
            DataRow[] rows = _dtStudents.Select($"{student_id} = '{safe}'");
            txtTenSinhVien.Text = (rows.Length > 0) ? rows[0]["full_name"].ToString() : "";
        }
        private void LoadTable()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = $@"
                        SELECT
                            kl.{kyluat_id} AS {kyluat_id},
                            kl.{student_id_kyuat} AS {student_id_kyuat},
                            CONCAT(st.{sutdent_lastname}, ' ', st.{sutdent_firstname}) AS full_name,
                            kl.{hinhthuc} AS {hinhthuc},
                            kl.{soquyetdinh} AS {soquyetdinh},
                            kl.{lydo} AS {lydo},
                            kl.{kyluat_Date} AS {kyluat_Date},
                            kl.{kyluat_ketthuc} AS {kyluat_ketthuc}
                        FROM {kyluat} kl
                        LEFT JOIN {student} st ON kl.{student_id_kyuat} = st.{student_id}
                        ORDER BY kl.{kyluat_id};
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);                
                        dtgvKyLuatId.DataPropertyName = kyluat_id;
                        dtgvStudentId.DataPropertyName = student_id_kyuat;
                        dtgvKyLuatTenSV.DataPropertyName = "full_name";
                        dtgvKyLuatType.DataPropertyName = hinhthuc;
                        dtgvDecisionNo.DataPropertyName = soquyetdinh;
                        dtgvReason.DataPropertyName = lydo;
                        dtgvNgaybatdau.DataPropertyName = kyluat_Date;
                        dtgvNgayketthuc.DataPropertyName = kyluat_ketthuc;
                        dtgvKyLuat.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load bảng kỉ luật lỗi: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentId = (cboStudentId.Text ?? "").Trim();     
            string hinhThuc = (cbbKyLuatType.Text ?? "").Trim();
            string soQD = (txtSoQuyetDinh.Text ?? "").Trim();
            string lyDo = (txtReason.Text ?? "").Trim();
            DateTime? ngayBD = dtpKyLuatDate.Value;
            DateTime? ngayKT = dateTimePicker1.Value;
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Vui lòng nhập/chọn Mã SV");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSinhVien.Text))
            {
                MessageBox.Show("Mã SV không tồn tại trong bảng sinh viên");
                return;
            }
            if (string.IsNullOrWhiteSpace(hinhThuc))
            {
                MessageBox.Show("Vui lòng chọn hình thức kỉ luật");
                return;
            }
            if (string.IsNullOrWhiteSpace(lyDo))
            {
                MessageBox.Show("Vui lòng nhập lý do");
                return;
            }
            if (ngayKT < ngayBD)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                return;
            }
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = $@"
                        INSERT INTO {kyluat}
                            ({student_id_kyuat}, {hinhthuc}, {soquyetdinh}, {kyluat_Date}, {kyluat_ketthuc}, {lydo})
                        VALUES
                            (@stu, @ht, @soqd, @ngaybd, @ngaykt, @lydo);
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@stu", studentId);
                        cmd.Parameters.AddWithValue("@ht", hinhThuc);
                        cmd.Parameters.AddWithValue("@soqd", string.IsNullOrWhiteSpace(soQD) ? (object)DBNull.Value : soQD);
                        cmd.Parameters.AddWithValue("@ngaybd", ngayBD);
                        cmd.Parameters.AddWithValue("@ngaykt", ngayKT);
                        cmd.Parameters.AddWithValue("@lydo", lyDo);
                        int row = cmd.ExecuteNonQuery();
                        MessageBox.Show(row > 0 ? "Lưu thành công" : "Lưu thất bại");
                    }
                }
                LoadTable();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu lỗi: " + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse((txtKyLuatId.Text ?? "").Trim(), out int id))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để sửa");
                return;
            }
            string studentId = (cboStudentId.Text ?? "").Trim();
            string hinhThuc = (cbbKyLuatType.Text ?? "").Trim();
            string soQD = (txtSoQuyetDinh.Text ?? "").Trim();
            string lyDo = (txtReason.Text ?? "").Trim();
            DateTime? ngayBD = dtpKyLuatDate.Value;
            DateTime? ngayKT = dateTimePicker1.Value;
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Vui lòng nhập/chọn Mã SV");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSinhVien.Text))
            {
                MessageBox.Show("Mã SV không tồn tại trong bảng sinh viên");
                return;
            }
            if (string.IsNullOrWhiteSpace(hinhThuc))
            {
                MessageBox.Show("Vui lòng chọn hình thức kỉ luật");
                return;
            }
            if (string.IsNullOrWhiteSpace(lyDo))
            {
                MessageBox.Show("Vui lòng nhập lý do");
                return;
            }
            if (ngayKT < ngayBD)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                return;
            }
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = $@"
                        UPDATE {kyluat}
                        SET
                            {student_id_kyuat} = @stu,
                            {hinhthuc} = @ht,
                            {soquyetdinh} = @soqd,
                            {kyluat_Date} = @ngaybd,
                            {kyluat_ketthuc} = @ngaykt,
                            {lydo} = @lydo
                        WHERE {kyluat_id} = @id;
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@stu", studentId);
                        cmd.Parameters.AddWithValue("@ht", hinhThuc);
                        cmd.Parameters.AddWithValue("@soqd", string.IsNullOrWhiteSpace(soQD) ? (object)DBNull.Value : soQD);
                        cmd.Parameters.AddWithValue("@ngaybd", ngayBD);
                        cmd.Parameters.AddWithValue("@ngaykt", ngayKT);
                        cmd.Parameters.AddWithValue("@lydo", lyDo);
                        int row = cmd.ExecuteNonQuery();
                        MessageBox.Show(row > 0 ? "Cập nhật thành công" : "Cập nhật thất bại");
                    }
                }
                LoadTable();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa lỗi: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse((txtKyLuatId.Text ?? "").Trim(), out int id))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = $@"DELETE FROM {kyluat} WHERE {kyluat_id} = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int row = cmd.ExecuteNonQuery();
                        MessageBox.Show(row > 0 ? "Xóa thành công" : "Xóa thất bại");
                    }
                }
                LoadTable();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lỗi: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idText = (txtKyLuatIdSearch.Text ?? "").Trim();
            string stu = (txtStudentIdSearch.Text ?? "").Trim();
            int idSearch;
            bool hasId = int.TryParse(idText, out idSearch);
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = $@"
                        SELECT
                            kl.{kyluat_id} AS {kyluat_id},
                            kl.{student_id_kyuat} AS {student_id_kyuat},
                            CONCAT(st.{sutdent_lastname}, ' ', st.{sutdent_firstname}) AS full_name,
                            kl.{hinhthuc} AS {hinhthuc},
                            kl.{soquyetdinh} AS {soquyetdinh},
                            kl.{lydo} AS {lydo},
                            kl.{kyluat_Date} AS {kyluat_Date},
                            kl.{kyluat_ketthuc} AS {kyluat_ketthuc}
                        FROM {kyluat} kl
                        LEFT JOIN {student} st ON kl.{student_id_kyuat} = st.{student_id}
                        WHERE (@hasId = 0 OR kl.{kyluat_id} = @id)
                          AND (@stu = '' OR kl.{student_id_kyuat} LIKE @stu_like)
                        ORDER BY kl.{kyluat_id};
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@hasId", hasId ? 1 : 0);
                        cmd.Parameters.AddWithValue("@id", idSearch);
                        cmd.Parameters.AddWithValue("@stu", stu);
                        cmd.Parameters.AddWithValue("@stu_like", "%" + stu + "%");
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgvKyLuat.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm lỗi: " + ex.Message);
            }
        }

        private void dtgvKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dtgvKyLuat.Rows[e.RowIndex];
            txtKyLuatId.Text = row.Cells["dtgvKyLuatId"]?.Value?.ToString();
            string stuId = row.Cells["dtgvStudentId"]?.Value?.ToString();
            cboStudentId.Text = stuId ?? "";
            SyncStudentNameById((cboStudentId.Text ?? "").Trim());
            cbbKyLuatType.Text = row.Cells["dtgvKyLuatType"]?.Value?.ToString();
            txtSoQuyetDinh.Text = row.Cells["dtgvDecisionNo"]?.Value?.ToString();
            txtReason.Text = row.Cells["dtgvReason"]?.Value?.ToString();
            if (DateTime.TryParse(row.Cells["dtgvNgaybatdau"]?.Value?.ToString(), out DateTime d1))
                dtpKyLuatDate.Value = d1;
            if (DateTime.TryParse(row.Cells["dtgvNgayketthuc"]?.Value?.ToString(), out DateTime d2))
                dateTimePicker1.Value = d2;
            cboStudentId.Enabled = false; 

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtKyLuatId.Clear();
            txtReason.Clear();
            txtSoQuyetDinh.Clear();
            if (cboStudentId.DataSource != null)
            cboStudentId.SelectedIndex = -1;
            cboStudentId.Text = "";
            txtTenSinhVien.Text = "";
            cbbKyLuatType.SelectedIndex = -1;
            dtpKyLuatDate.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            cboStudentId.Enabled = true;  
            cboStudentId.Focus();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Kỷ luật");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 8).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH KỶ LUẬT";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã SV", "Tên sinh viên", "Hình thức kỷ luật", "Số quyết định", "Lý do", "Ngày kỷ luật", "Ngày kết thúc" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 8).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 8).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 8).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = $@"
                        SELECT
                            kl.{student_id_kyuat} AS {student_id_kyuat},
                            CONCAT(st.{sutdent_lastname}, ' ', st.{sutdent_firstname}) AS full_name,
                            kl.{hinhthuc} AS {hinhthuc},
                            kl.{soquyetdinh} AS {soquyetdinh},
                            kl.{lydo} AS {lydo},
                            kl.{kyluat_Date} AS {kyluat_Date},
                            kl.{kyluat_ketthuc} AS {kyluat_ketthuc}
                        FROM {kyluat} kl
                        LEFT JOIN {student} st ON kl.{student_id_kyuat} = st.{student_id}
                        ORDER BY kl.{kyluat_id};
                    ";
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
                            ws.Cell(rowIndex, 2).Value = reader[student_id_kyuat]?.ToString();
                            ws.Cell(rowIndex, 3).Value = reader["full_name"]?.ToString();
                            ws.Cell(rowIndex, 4).Value = reader[hinhthuc]?.ToString();
                            ws.Cell(rowIndex, 5).Value = reader[soquyetdinh]?.ToString();
                            ws.Cell(rowIndex, 6).Value = reader[lydo]?.ToString();
                            ws.Cell(rowIndex, 7).Value = Convert.ToDateTime(reader[kyluat_Date]).ToString("dd/mm/yyyy");
                            ws.Cell(rowIndex, 8).Value = Convert.ToDateTime(reader[kyluat_ketthuc]).ToString("dd/mm/yyyy");


                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 8).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 8).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 8);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 8);

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
                    sfd.Title = "Lưu danh sách kỷ luật";
                    sfd.FileName = "Danh_sach_ky_luat.xlsx"; // tên gợi ý

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
