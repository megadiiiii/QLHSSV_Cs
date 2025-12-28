using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
namespace BTL_QLHSSV_NETFW
{
    public partial class UC_KyLuat : UserControl
    {
        private const string T_STUDENT = "student";
        private const string T_KYLUAT = "kyluat";
        private const string C_STU_ID = "student_id";
        private const string C_STU_LAST = "student_lastName";
        private const string C_STU_FIRST = "student_firstName";
        private const string C_KL_ID = "idkyluat";       
        private const string C_KL_STU = "student_id";
        private const string C_KL_HT = "hinhThuc";
        private const string C_KL_QD = "soQuyetDinh";
        private const string C_KL_REASON = "lyDo";
        private const string C_KL_DATE = "kyluat_date";
        private const string C_KL_END = "ngayKetThuc";
        private DataTable _dtStudents;
        public UC_KyLuat()
        {
            InitializeComponent();
            this.Load += UC_KyLuat_Load;
            dtgvKyLuat.CellClick += dtgvKyLuat_CellClick;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnReset.Click += btnReset_Click;
            btnSearch.Click += btnSearch_Click;
            cboStudentId.TextChanged += cboStudentId_TextChanged;
            cboStudentId.SelectionChangeCommitted += cboStudentId_SelectionChangeCommitted;
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
                            {C_STU_ID},
                            CONCAT({C_STU_LAST}, ' ', {C_STU_FIRST}) AS full_name
                        FROM {T_STUDENT}
                        ORDER BY {C_STU_ID};
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        _dtStudents = new DataTable();
                        da.Fill(_dtStudents);

                        // bind mã sv để click xổ ra danh sách như cũ
                        cboStudentId.DataSource = _dtStudents;
                        cboStudentId.DisplayMember = C_STU_ID;
                        cboStudentId.ValueMember = C_STU_ID;
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
            DataRow[] rows = _dtStudents.Select($"{C_STU_ID} = '{safe}'");
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
                            kl.{C_KL_ID} AS {C_KL_ID},
                            kl.{C_KL_STU} AS {C_KL_STU},
                            CONCAT(st.{C_STU_LAST}, ' ', st.{C_STU_FIRST}) AS full_name,
                            kl.{C_KL_HT} AS {C_KL_HT},
                            kl.{C_KL_QD} AS {C_KL_QD},
                            kl.{C_KL_REASON} AS {C_KL_REASON},
                            kl.{C_KL_DATE} AS {C_KL_DATE},
                            kl.{C_KL_END} AS {C_KL_END}
                        FROM {T_KYLUAT} kl
                        LEFT JOIN {T_STUDENT} st ON kl.{C_KL_STU} = st.{C_STU_ID}
                        ORDER BY kl.{C_KL_ID} DESC;
                    ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);                
                        dtgvKyLuatId.DataPropertyName = C_KL_ID;
                        dtgvStudentId.DataPropertyName = C_KL_STU;
                        dtgvKyLuatTenSV.DataPropertyName = "full_name";
                        dtgvKyLuatType.DataPropertyName = C_KL_HT;
                        dtgvDecisionNo.DataPropertyName = C_KL_QD;
                        dtgvReason.DataPropertyName = C_KL_REASON;
                        dtgvNgaybatdau.DataPropertyName = C_KL_DATE;
                        dtgvNgayketthuc.DataPropertyName = C_KL_END;
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
            DateTime ngayBD = dtpKyLuatDate.Value.Date;
            DateTime ngayKT = dateTimePicker1.Value.Date;
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
                        INSERT INTO {T_KYLUAT}
                            ({C_KL_STU}, {C_KL_HT}, {C_KL_QD}, {C_KL_DATE}, {C_KL_END}, {C_KL_REASON})
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
            DateTime ngayBD = dtpKyLuatDate.Value.Date;
            DateTime ngayKT = dateTimePicker1.Value.Date;
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
                        UPDATE {T_KYLUAT}
                        SET
                            {C_KL_STU} = @stu,
                            {C_KL_HT} = @ht,
                            {C_KL_QD} = @soqd,
                            {C_KL_DATE} = @ngaybd,
                            {C_KL_END} = @ngaykt,
                            {C_KL_REASON} = @lydo
                        WHERE {C_KL_ID} = @id;
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
                    string sql = $@"DELETE FROM {T_KYLUAT} WHERE {C_KL_ID} = @id;";
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
                            kl.{C_KL_ID} AS {C_KL_ID},
                            kl.{C_KL_STU} AS {C_KL_STU},
                            CONCAT(st.{C_STU_LAST}, ' ', st.{C_STU_FIRST}) AS full_name,
                            kl.{C_KL_HT} AS {C_KL_HT},
                            kl.{C_KL_QD} AS {C_KL_QD},
                            kl.{C_KL_REASON} AS {C_KL_REASON},
                            kl.{C_KL_DATE} AS {C_KL_DATE},
                            kl.{C_KL_END} AS {C_KL_END}
                        FROM {T_KYLUAT} kl
                        LEFT JOIN {T_STUDENT} st ON kl.{C_KL_STU} = st.{C_STU_ID}
                        WHERE (@hasId = 0 OR kl.{C_KL_ID} = @id)
                          AND (@stu = '' OR kl.{C_KL_STU} LIKE @stu_like)
                        ORDER BY kl.{C_KL_ID} DESC;
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
    }
}
