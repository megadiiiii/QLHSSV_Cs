using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using Syncfusion.WinForms.ListView;
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
    public partial class UC_Student : UserControl
    {
        public UC_Student()
        {
            InitializeComponent();
        }

        private void LoadFaculties()
        {
            try
            {
                DataTable dt = new DataTable();
                using (var conn = dbConn.GetConnection())
                {
                    string sql = "SELECT facu_id, facu_name FROM faculties";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.Fill(dt);
                    }
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

        private void LoadMajorsByFaculty(string facuId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var conn = dbConn.GetConnection())
                {
                    string sql = "SELECT major_id, major_name FROM major WHERE facu_id = @facuId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@facuId", facuId);
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                cboMajor.DataSource = dt;
                cboMajor.DisplayMember = "major_name";
                cboMajor.ValueMember = "major_id";
                cboMajor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void UC_Student_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            studentTableLoad();
        }

        public void studentTableLoad()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"select student_id, student_lastName, student_firstName, dob, gender, s.class_id,
                                c.class_name, cohort, major_name, facu_name, status, hometown, phone, email, id_no
                                from student s
                                join class c on c.class_id = s.class_id
                                join major m on m.major_id = c.major_id
                                join faculties f on f.facu_id = m.facu_id
                                order by student_firstName asc";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);

                        }

                        dgvStudentTable.Columns["dgvID"].DataPropertyName = "student_id";
                        dgvStudentTable.Columns["dgvLastName"].DataPropertyName = "student_lastName";
                        dgvStudentTable.Columns["dgvFirstName"].DataPropertyName = "student_firstName";
                        dgvStudentTable.Columns["dgvDob"].DataPropertyName = "dob";
                        dgvStudentTable.Columns["dgvGender"].DataPropertyName = "gender";
                        dgvStudentTable.Columns["dgvClassID"].DataPropertyName = "class_id";
                        dgvStudentTable.Columns["dgvClass"].DataPropertyName = "class_name";
                        dgvStudentTable.Columns["dgvCohort"].DataPropertyName = "cohort";
                        dgvStudentTable.Columns["dgvMajor"].DataPropertyName = "major_name";
                        dgvStudentTable.Columns["dgvFacu"].DataPropertyName = "facu_name";
                        dgvStudentTable.Columns["dgvHometown"].DataPropertyName = "hometown";
                        dgvStudentTable.Columns["dgvPhone"].DataPropertyName = "phone";
                        dgvStudentTable.Columns["dgvEmail"].DataPropertyName = "email";
                        dgvStudentTable.Columns["dgvIdNo"].DataPropertyName = "id_no";
                        dgvStudentTable.Columns["dgvStatus"].DataPropertyName = "status";
                        dgvStudentTable.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearInput()
        {
            txtId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtDob.Value = DateTime.Now;
            txtHometown.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtIdNo.Clear();

            cboGender.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;

            cboFacu.SelectedIndex = -1;
            cboMajor.DataSource = null;
            cboClass.DataSource = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();

            if (txtDob.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDob.Focus();
                return;
            }
            DateTime? dob = txtDob.Value;

            if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGender.Focus();
                return;
            }
            string gender = cboGender.SelectedItem.ToString();
            string homeTown = txtHometown.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string idNo = txtIdNo.Text.Trim();

            if (cboFacu.SelectedIndex == -1 ||
                cboMajor.SelectedIndex == -1 ||
                cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn đầy đủ Khoa - Ngành - Lớp");
                return;
            }

            string facuId = cboFacu.SelectedValue.ToString();
            string majorId = cboMajor.SelectedValue.ToString();
            string classId = cboClass.SelectedValue.ToString();

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return;
            }
            string status = cboStatus.SelectedItem?.ToString();

            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO student (student_id, student_lastName, student_firstName, dob, gender, hometown, phone, email, id_no, class_id, status) 
                                VALUES (@student_id, @lastName, @firstName, @dob, @gender, @hometown, @phone, @email, @idNo, @classId, @status)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", id);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@hometown", homeTown);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@idNo", idNo);
                        cmd.Parameters.AddWithValue("@classId", classId);
                        cmd.Parameters.AddWithValue("@status", status);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            studentTableLoad();
                            clearInput();
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFacu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFacu.SelectedIndex == -1) return;

            string facuId = cboFacu.SelectedValue.ToString();
            LoadMajorsByFaculty(facuId);
        }

        private void cboMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMajor.SelectedIndex == -1) return;

            string majorId = cboMajor.SelectedValue.ToString();
            LoadClassByMajor(majorId);
        }

        private void LoadClassByMajor(string majorId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var conn = dbConn.GetConnection())
                {
                    string sql = @"SELECT class_id, class_name 
                           FROM class 
                           WHERE major_id = @majorId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@majorId", majorId);
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                cboClass.DataSource = dt;
                cboClass.DisplayMember = "class_name";
                cboClass.ValueMember = "class_id";
                cboClass.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStudentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //txtId.ReadOnly = false;
                return;
            }
            DataGridViewRow row = dgvStudentTable.Rows[e.RowIndex];

            txtId.Text = row.Cells["dgvID"].Value?.ToString();
            //txtId.ReadOnly = true;
            txtLastName.Text = row.Cells["dgvLastName"].Value?.ToString();
            txtFirstName.Text = row.Cells["dgvFirstName"].Value?.ToString();
            if (row.Cells["dgvDob"].Value != DBNull.Value)
            {
                txtDob.Value = Convert.ToDateTime(row.Cells["dgvDob"].Value);
            }
            cboGender.SelectedItem = row.Cells["dgvGender"].Value?.ToString();
            txtHometown.Text = row.Cells["dgvHometown"].Value?.ToString();
            txtPhone.Text = row.Cells["dgvPhone"].Value?.ToString();
            txtEmail.Text = row.Cells["dgvEmail"].Value?.ToString();
            txtIdNo.Text = row.Cells["dgvIdNo"].Value?.ToString();
            cboStatus.Text = row.Cells["dgvStatus"].Value?.ToString();

            //Load Facu/Major/Class info
            comboLoad(row);

        }

        public void comboLoad(DataGridViewRow row)
        {
            string classId = row.Cells["dgvClassID"].Value?.ToString();
            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                                select c.class_id, m.major_id, f.facu_id
                                from class c
                                join major m on m.major_id = c.major_id
                                join faculties f on f.facu_id = m.facu_id
                                where c.class_id = @classId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@classId", classId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string facuId = reader["facu_id"].ToString();
                                string majorId = reader["major_id"].ToString();

                                //Set Facu
                                cboFacu.SelectedValue = facuId;

                                //Set Major
                                LoadMajorsByFaculty(facuId);
                                cboMajor.SelectedValue = majorId;

                                //Set Class
                                LoadClassByMajor(majorId);
                                cboClass.SelectedValue = classId;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"DELETE FROM student
                                 WHERE student_id = @id";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue(@"id", id);
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                studentTableLoad();
                                clearInput();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE student 
                           SET student_lastName = @lastName,
                               student_firstName = @firstName,
                               dob = @dob,
                               gender = @gender,
                               hometown = @hometown,
                               phone = @phone,
                               email = @email,
                               id_no = @idNo,
                               class_id = @classId,
                               status = @status
                           WHERE student_id = @student_id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", id);
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", txtDob.Value);
                        cmd.Parameters.AddWithValue("@gender", cboGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@hometown", txtHometown.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@idNo", txtIdNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@classId", cboClass.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem?.ToString());
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            studentTableLoad();
                            clearInput();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var ws = wb.Worksheets.Add("Student");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 15).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH SINH VIÊN";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã SV", "Họ đệm", "Tên", "Ngày sinh", "Giới tính", "Lớp",
                "Khóa", "Chuyên ngành", "Khoa","Trạng thái", "Quê quán", "SĐT", "Email", "Số CCCD"};
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 15).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 15).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 15).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"select student_id, student_lastName, student_firstName, dob, gender, s.class_id,
                                c.class_name, cohort, major_name, facu_name, status, hometown, phone, email, id_no
                                from student s
                                join class c on c.class_id = s.class_id
                                join major m on m.major_id = c.major_id
                                join faculties f on f.facu_id = m.facu_id
                                order by student_firstName asc";
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
                            if (reader["dob"] != DBNull.Value)
                            {
                                DateTime dob = Convert.ToDateTime(reader["dob"]);
                                ws.Cell(rowIndex, 5).Value = dob.ToString("dd/MM/yyyy");
                            }
                            ws.Cell(rowIndex, 6).Value = reader["gender"].ToString();
                            ws.Cell(rowIndex, 7).Value = reader["class_name"].ToString();
                            ws.Cell(rowIndex, 8).Value = reader["cohort"].ToString();
                            ws.Cell(rowIndex, 9).Value = reader["major_name"].ToString();
                            ws.Cell(rowIndex, 10).Value = reader["facu_name"].ToString();
                            ws.Cell(rowIndex, 11).Value = reader["status"].ToString();
                            ws.Cell(rowIndex, 12).Value = reader["hometown"].ToString();
                            ws.Cell(rowIndex, 13).Value = reader["phone"].ToString();
                            ws.Cell(rowIndex, 14).Value = reader["email"].ToString();
                            ws.Cell(rowIndex, 15).Value = reader["id_no"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 15).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 15).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 15);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 15);

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
                    sfd.Title = "Lưu danh sách sinh viên";
                    sfd.FileName = "Danh_sach_sinh_vien.xlsx"; // tên gợi ý

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
            string id = txtIDSearch.Text.Trim();
            string name = txtNameSearch.Text.Trim();
            string className = txtClassNameSearch.Text.Trim();

            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select s.*, c.class_name, m.major_name, f.facu_name, cohort
                                    from student s
                                    join class c on c.class_id = s.class_id
                                    join major m on m.major_id = c.major_id
                                    join faculties f on f.facu_id = m.facu_id
                                    WHERE (@id = '' OR s.student_id LIKE @id)
                                    AND (@name = '' OR CONCAT(s.student_lastName, ' ', s.student_firstName) LIKE @name)
                                    AND (@className = '' OR c.class_name LIKE @className)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(@"id", "%" + id + "%");
                        cmd.Parameters.AddWithValue(@"name", "%" + name + "%");
                        cmd.Parameters.AddWithValue(@"className", "%" + className + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvStudentTable.AutoGenerateColumns = false;
                    dgvStudentTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}