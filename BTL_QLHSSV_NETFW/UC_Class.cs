using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_QLHSSV_NETFW
{
    public partial class UC_Class : UserControl
    {

        public UC_Class()
        {
            InitializeComponent();
        }

        /* ================= LOAD DATA ================= */

        private void facultiesLoad()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = "select facu_id, facu_name from faculties";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboFacu.DataSource = dt;
                cboFacu.DisplayMember = "facu_name";
                cboFacu.ValueMember = "facu_id";
                cboFacu.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classLoad()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"SELECT c.*, f.facu_name, m.major_name, t.teacher_name, ch.cohort_name
                                FROM class c
                                JOIN major m ON m.major_id = c.major_id
                                JOIN faculties f ON f.facu_id = m.facu_id
                                JOIN teacher t ON t.teacher_id = c.teacher_id
                                JOIN cohort ch ON ch.cohort_id = c.cohort_id 
                                ORDER BY cohort_name asc";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvClass.AutoGenerateColumns = false;

                    dgvClassID.DataPropertyName = "class_id";
                    dgvClassName.DataPropertyName = "class_name";
                    dgvCohort.DataPropertyName = "cohort_name";
                    dgvFacu.DataPropertyName = "facu_name";
                    dgvMajor.DataPropertyName = "major_name";
                    dgvTeacher.DataPropertyName = "teacher_name";
                    dgvCurrentStudent.DataPropertyName = "student_current";
                    dgvMaxStudent.DataPropertyName = "student_max";

                    dgvClass.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_Class_Load(object sender, EventArgs e)
        {
            facultiesLoad();
            cohortLoad();
            classLoad();
        }

        /* ================= EVENT ================= */

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvClass.Rows[e.RowIndex];
            txtClassID.Text = row.Cells["dgvClassID"].Value.ToString();
            txtClassName.Text = row.Cells["dgvClassName"].Value.ToString();
            cboFacu.Text = row.Cells["dgvFacu"].Value.ToString();
            cboMajor.Text = row.Cells["dgvMajor"].Value.ToString();
            cboCohort.Text = row.Cells["dgvCohort"].Value.ToString();
            cboTeacher.Text = row.Cells["dgvTeacher"].Value.ToString();
            txtCurrentStudent.Text = row.Cells["dgvCurrentStudent"].Value.ToString();
            txtMaxStudent.Text = row.Cells["dgvMaxStudent"].Value.ToString();
        }

        /* ================= ADD ================= */

        private void btnSave_Click(object sender, EventArgs e)
        {
            string classId = generateClassId();
            string className = generateClassName();

            if (cboMajor.SelectedValue == null ||
                cboTeacher.SelectedValue == null ||
                cboCohort.SelectedValue == null)
            {
                MessageBox.Show("Chọn đủ khoa / ngành / giáo viên / khóa");
                return;
            }

            string majorId = cboMajor.SelectedValue.ToString();
            string teacherId = cboTeacher.SelectedValue.ToString();
            int cohortId = Convert.ToInt32(cboCohort.SelectedValue);

            if (!int.TryParse(txtMaxStudent.Text.Trim(), out int studentMax) || studentMax <= 0)
            {
                MessageBox.Show("Số SV tối đa phải là số > 0");
                return;
            }

            if (MessageBox.Show(
                $"Xác nhận tạo lớp\nMã: {classId}\nTên: {className}",
                "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO class
                (class_id, class_name, major_id, teacher_id, cohort_id, student_max, student_current)
                VALUES (@id, @name, @major, @teacher, @cohort, @max, 0)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", classId);
                        cmd.Parameters.AddWithValue("@name", className);
                        cmd.Parameters.AddWithValue("@major", majorId);
                        cmd.Parameters.AddWithValue("@teacher", teacherId);
                        cmd.Parameters.AddWithValue("@cohort", cohortId);
                        cmd.Parameters.AddWithValue("@max", studentMax);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm lớp thành công");
                            classLoad();
                            clearInput();
                        }
                        else
                        {
                            MessageBox.Show("Thêm lớp thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* ================= UPDATE ================= */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn lớp");
                return;
            }

            DataGridViewRow row = dgvClass.CurrentRow;

            string classId = row.Cells["dgvClassID"].Value?.ToString();
            if (!int.TryParse(txtMaxStudent.Text.Trim(), out int maxStudent) || maxStudent <= 0)
            {
                MessageBox.Show("Số SV tối đa phải là số nguyên dương");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE class 
                           SET student_max = @max
                           WHERE class_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@max", maxStudent);
                        cmd.Parameters.AddWithValue("@id", classId);

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            classLoad();
                        }
                        else
                        {
                            MessageBox.Show("Không cập nhật được lớp nào");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtClassID.Text.Trim();

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"delete from class where class_id = @id";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            classLoad();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select c.class_id, class_name, ch.cohort_name, m.major_name, f.facu_name
                                   from class c
                                   join major m on m.major_id = c.major_id
                                   join faculties f on f.facu_id = m.facu_id
                                   JOIN cohort ch on ch.cohort_id = c.cohort_id
                                   where (@id='' or c.class_id like @id)
                                     and (@name='' or c.class_name like @name)
                                     and (@cohort='' or cohort like @cohort)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", "%" + txtClassIDSearch.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@name", "%" + txtClassNameSearch.Text.Trim() + "%");
                    //cmd.Parameters.AddWithValue("@cohort", "%" + txtCohortSearch.Text.Trim() + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClass.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboFacu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFacu.SelectedIndex == -1) return;

            string facuId = cboFacu.SelectedValue.ToString();
            loadMajorByFacu(facuId);
            loadTeacherByFacu(facuId);
        }

        public void loadTeacherByFacu(string facuId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = "select teacher_id, teacher_name from teacher where facu_id=@facuId";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@facuId", facuId);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }

                    cboTeacher.DataSource = dt;
                    cboTeacher.DisplayMember = "teacher_name";
                    cboTeacher.ValueMember = "teacher_id";
                    cboTeacher.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadMajorByFacu(string facuId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = "select major_id, major_name from major where facu_id=@facuId";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@facuId", facuId);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }

                    cboMajor.DataSource = dt;
                    cboMajor.DisplayMember = "major_name";
                    cboMajor.ValueMember = "major_id";
                    cboMajor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cohortLoad()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select cohort_id, cohort_name from cohort
                                order by cohort_name asc";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboCohort.DataSource = dt;
                cboCohort.DisplayMember = "cohort_name";
                cboCohort.ValueMember = "cohort_id";
                cboCohort.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int countClasses(string facuId, string majorId, string cohortId)
        {
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT COUNT(*) 
                       FROM class c
                       JOIN major m ON m.major_id = c.major_id
                       WHERE m.facu_id = @facu
                         AND c.major_id = @major
                         AND c.cohort_id = @cohort";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@facu", facuId);
                    cmd.Parameters.AddWithValue("@major", majorId);
                    cmd.Parameters.AddWithValue("@cohort", cohortId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private string generateClassId()
        {
            if (cboFacu.SelectedIndex == -1 ||
                cboMajor.SelectedIndex == -1 ||
                cboCohort.SelectedIndex == -1)
                return "";

            string facuId = cboFacu.SelectedValue.ToString();
            string majorId = cboMajor.SelectedValue.ToString();
            string cohortId = cboCohort.SelectedValue.ToString();
            string cohortName = cboCohort.Text; // ví dụ: K65

            // lấy 2 số cuối
            string cohortStr = cohortName.Length >= 2
                ? cohortName.Substring(cohortName.Length - 2)
                : cohortName;

            int count = countClasses(facuId, majorId, cohortId);
            string seq = (count + 1).ToString("D2");

            return cohortStr + majorId + seq;
        }

        private string generateClassName()
        {
            if (cboMajor.SelectedIndex == -1 || cboCohort.SelectedIndex == -1)
                return "";

            string majorName = cboMajor.Text;
            string cohortName = cboCohort.Text;

            string facuId = cboFacu.SelectedValue.ToString();
            string majorId = cboMajor.SelectedValue.ToString();
            string cohortId = cboCohort.SelectedValue.ToString();

            int count = countClasses(facuId, majorId, cohortId);
            string seq = (count + 1).ToString("D2");

            return $"{majorName} {seq} - {cohortName}";
        }


        private void cboCohort_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClassID.Text = generateClassId();
            txtClassName.Text = generateClassName();
        }


        public void clearInput()
        {
            txtClassID.Clear();
            txtClassName.Clear();
            cboFacu.SelectedIndex = -1;
            cboMajor.SelectedIndex = -1;
            cboTeacher.SelectedIndex = -1;
            cboCohort.SelectedIndex = -1;
            txtCurrentStudent.Clear();
            txtMaxStudent.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Khoa");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 9).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH LỚP";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã lớp", "Tên lớp", "Khóa", "Chuyên ngành", "Khoa", "GVCN/CVHT", "Số SV hiện tại", "Số SV tối đa" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 9).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 9).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 9).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"SELECT c.*, f.facu_name, m.major_name, t.teacher_name, ch.cohort_name
                                FROM class c
                                JOIN major m ON m.major_id = c.major_id
                                JOIN faculties f ON f.facu_id = m.facu_id
                                JOIN teacher t ON t.teacher_id = c.teacher_id
                                JOIN cohort ch ON ch.cohort_id = c.cohort_id 
                                ORDER BY cohort_name asc";
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
                            ws.Cell(rowIndex, 2).Value = reader["class_id"].ToString();
                            ws.Cell(rowIndex, 3).Value = reader["class_name"].ToString();
                            ws.Cell(rowIndex, 4).Value = reader["cohort_name"].ToString();
                            ws.Cell(rowIndex, 5).Value = reader["major_name"].ToString();
                            ws.Cell(rowIndex, 6).Value = reader["facu_name"].ToString();
                            ws.Cell(rowIndex, 7).Value = reader["teacher_name"].ToString();
                            ws.Cell(rowIndex, 8).Value = reader["student_current"].ToString();
                            ws.Cell(rowIndex, 9).Value = reader["student_max"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 9).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 9).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 9);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 9);

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
                    sfd.Title = "Lưu danh sách lớp";
                    sfd.FileName = "Danh_sach_lop.xlsx"; // tên gợi ý

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
