using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BTL_QLHSSV_NETFW
{
    public partial class UC_Teacher : UserControl
    {
        private const string teacher = "teacher";
        private const string faculties = "faculties";
        private const string teacher_id = "teacher_id";
        private const string teacher_name = "teacher_name";
        private const string teacher_facu_id = "facu_id";
        private const string facu_id = "facu_id";
        private const string facu_name = "facu_name";
        private const string ALIAS_FACU_NAME = "facu_name";
        private DataTable _dtFaculties;

        public UC_Teacher()
        {
            InitializeComponent();
        }

        private void UC_Teacher_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dtgvTeacher.ReadOnly = true;
            dtgvTeacher.AllowUserToAddRows = false;
            dtgvTeacher.AutoGenerateColumns = false;

            txtFacuName.ReadOnly = true;
            txtFacuName.Enabled = false;

            SetupFacultyCombo(cboFacuId);
            SetupFacultyCombo(cboFacuIdSearch);

            LoadFacultyCombos();
            LoadTable();
            ResetForm();
        }

        private static void SetupFacultyCombo(ComboBox cbo)
        {
            cbo.DropDownStyle = ComboBoxStyle.DropDown;
            cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo.IntegralHeight = false;
            cbo.DropDownHeight = 200;
        }

        private void LoadFacultyCombos()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = $@"
                        SELECT {facu_id}, {facu_name}
                        FROM {faculties}
                        ORDER BY {facu_id};
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        _dtFaculties = new DataTable();
                        da.Fill(_dtFaculties);

                        // Combo nhập
                        cboFacuId.DataSource = _dtFaculties;
                        cboFacuId.DisplayMember = facu_id;
                        cboFacuId.ValueMember = facu_id;
                        cboFacuId.SelectedIndex = -1;

                        // Combo search: copy tránh ảnh hưởng selection
                        DataTable dt2 = _dtFaculties.Copy();
                        cboFacuIdSearch.DataSource = dt2;
                        cboFacuIdSearch.DisplayMember = facu_id;
                        cboFacuIdSearch.ValueMember = facu_id;
                        cboFacuIdSearch.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load khoa lỗi: " + ex.Message);
            }
        }

        private void cboFacuId_TextChanged(object sender, EventArgs e)
        {
            SyncFacultyNameById((cboFacuId.Text ?? "").Trim());
        }

        private void cboFacuId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SyncFacultyNameById((cboFacuId.Text ?? "").Trim());
        }

        private void SyncFacultyNameById(string facuIdValue)
        {
            if (_dtFaculties == null || string.IsNullOrWhiteSpace(facuIdValue))
            {
                txtFacuName.Text = "";
                return;
            }

            string safe = facuIdValue.Replace("'", "''");
            DataRow[] rows = _dtFaculties.Select($"{facu_id} = '{safe}'");
            txtFacuName.Text = (rows.Length > 0) ? rows[0][facu_name].ToString() : "";
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
                            t.{teacher_id},
                            t.{teacher_name},
                            t.{teacher_facu_id},
                            f.{facu_name} AS {ALIAS_FACU_NAME}
                        FROM {teacher} t
                        LEFT JOIN {faculties} f ON t.{teacher_facu_id} = f.{facu_id}
                        ORDER BY t.{teacher_id};
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtgvTeacherId.DataPropertyName = teacher_id;
                        dtgvTeacherName.DataPropertyName = teacher_name;
                        dtgvFacuId.DataPropertyName = teacher_facu_id;
                        dtgvFacuName.DataPropertyName = ALIAS_FACU_NAME;

                        dtgvTeacher.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load bảng giáo viên lỗi: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teacherId = (txtTeacherId.Text ?? "").Trim();
            string teacherNameValue = (txtTeacherName.Text ?? "").Trim();
            string facuIdValue = (cboFacuId.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(teacherId))
            {
                MessageBox.Show("Vui lòng nhập Mã giảng viên");
                return;
            }
            if (string.IsNullOrWhiteSpace(teacherNameValue))
            {
                MessageBox.Show("Vui lòng nhập Tên giảng viên");
                return;
            }
            if (string.IsNullOrWhiteSpace(facuIdValue))
            {
                MessageBox.Show("Vui lòng nhập/chọn Mã khoa");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFacuName.Text))
            {
                MessageBox.Show("Mã khoa không tồn tại trong bảng khoa");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string checkSql = $@"SELECT COUNT(*) FROM {teacher} WHERE {teacher_id} = @id;";
                    using (var checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", teacherId);
                        long cnt = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (cnt > 0)
                        {
                            MessageBox.Show("Mã giảng viên đã tồn tại!");
                            return;
                        }
                    }

                    string sql = $@"
                        INSERT INTO {teacher} ({teacher_id}, {teacher_name}, {teacher_facu_id})
                        VALUES (@id, @name, @facu);
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", teacherId);
                        cmd.Parameters.AddWithValue("@name", teacherNameValue);
                        cmd.Parameters.AddWithValue("@facu", facuIdValue);

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
            string teacherId = (txtTeacherId.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(teacherId))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để sửa");
                return;
            }

            string teacherNameValue = (txtTeacherName.Text ?? "").Trim();
            string facuIdValue = (cboFacuId.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(teacherNameValue))
            {
                MessageBox.Show("Vui lòng nhập Tên giảng viên");
                return;
            }
            if (string.IsNullOrWhiteSpace(facuIdValue))
            {
                MessageBox.Show("Vui lòng nhập/chọn Mã khoa");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFacuName.Text))
            {
                MessageBox.Show("Mã khoa không tồn tại trong bảng khoa");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = $@"
                        UPDATE {teacher}
                        SET
                            {teacher_name} = @name,
                            {teacher_facu_id} = @facu
                        WHERE {teacher_id} = @id;
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", teacherId);
                        cmd.Parameters.AddWithValue("@name", teacherNameValue);
                        cmd.Parameters.AddWithValue("@facu", facuIdValue);

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
            string teacherId = (txtTeacherId.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(teacherId))
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

                    string sql = $@"DELETE FROM {teacher} WHERE {teacher_id} = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", teacherId);
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
            string id = (txtTeacherIdSearch.Text ?? "").Trim();
            string name = (txtTeacherNameSearch.Text ?? "").Trim();
            string facu = (cboFacuIdSearch.Text ?? "").Trim();

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = $@"
                        SELECT
                            t.{teacher_id},
                            t.{teacher_name},
                            t.{teacher_facu_id},
                            f.{facu_name} AS {ALIAS_FACU_NAME}
                        FROM {teacher} t
                        LEFT JOIN {faculties} f ON t.{teacher_facu_id} = f.{facu_id}
                        WHERE (@id = '' OR t.{teacher_id} LIKE @id_like)
                          AND (@name = '' OR t.{teacher_name} LIKE @name_like)
                          AND (@facu = '' OR t.{teacher_facu_id} LIKE @facu_like)
                        ORDER BY t.{teacher_id};
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@id_like", "%" + id + "%");

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@name_like", "%" + name + "%");

                        cmd.Parameters.AddWithValue("@facu", facu);
                        cmd.Parameters.AddWithValue("@facu_like", "%" + facu + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgvTeacher.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm lỗi: " + ex.Message);
            }
        }

        private void dtgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtgvTeacher.Rows[e.RowIndex];

            txtTeacherId.Text = row.Cells["dtgvTeacherId"]?.Value?.ToString();
            txtTeacherName.Text = row.Cells["dtgvTeacherName"]?.Value?.ToString();

            string facuIdValue = row.Cells["dtgvFacuId"]?.Value?.ToString();
            cboFacuId.Text = facuIdValue ?? "";
            SyncFacultyNameById((cboFacuId.Text ?? "").Trim());

            txtTeacherId.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtTeacherId.Clear();
            txtTeacherName.Clear();

            if (cboFacuId.DataSource != null)
                cboFacuId.SelectedIndex = -1;

            cboFacuId.Text = "";
            txtFacuName.Text = "";

            txtTeacherId.Enabled = true;
            txtTeacherId.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Giảng viên");
            ws.Style.Font.FontName = "Times New Roman";

            ws.Range(1, 1, 2, 5).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH GIẢNG VIÊN";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            string[] headers = { "STT", "Mã giảng viên", "Tên giảng viên", "Mã khoa", "Tên khoa" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];
            }

            ws.Range(4, 1, 4, 5).Style.Font.SetBold().Font.FontSize = 14;
            ws.Range(4, 1, 4, 5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range(4, 1, 4, 5).Style.Fill.SetBackgroundColor(XLColor.LightGray);

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = $@"
                    SELECT
                        t.{teacher_id},
                        t.{teacher_name},
                        t.{teacher_facu_id},
                        f.{facu_name} AS {ALIAS_FACU_NAME}
                    FROM {teacher} t
                    LEFT JOIN {faculties} f ON t.{teacher_facu_id} = f.{facu_id}
                    ORDER BY t.{teacher_id};
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int rowIndex = 5;
                        int no = 1;

                        while (reader.Read())
                        {
                            ws.Cell(rowIndex, 1).Value = no++;
                            ws.Cell(rowIndex, 2).Value = reader[teacher_id]?.ToString();
                            ws.Cell(rowIndex, 3).Value = reader[teacher_name]?.ToString();
                            ws.Cell(rowIndex, 4).Value = reader[teacher_facu_id]?.ToString();
                            ws.Cell(rowIndex, 5).Value = reader[ALIAS_FACU_NAME]?.ToString();

                            ws.Range(rowIndex, 1, rowIndex, 5).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 5).Style.Font.SetBold(false);

                            rowIndex++;
                        }

                        var tableRange = ws.Range(4, 1, rowIndex - 1, 5);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 5);
                        usedRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    }
                }
            }

            ws.Columns().AdjustToContents();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Lưu danh sách giảng viên";
                sfd.FileName = "Danh_sach_giang_vien.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo");
                }
            }
        }
    }
}
