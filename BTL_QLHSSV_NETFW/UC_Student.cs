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
                    string sql = @"select s.*, c.class_name, m.major_name, f.facu_name 
                                    from student s
                                    join class c on c.class_id = s.class_id
                                    join major m on m.major_id = c.major_id
                                    join faculties f on f.facu_id = m.facu_id";
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
                        dgvStudentTable.Columns["dgvHometown"].DataPropertyName = "hometown";
                        dgvStudentTable.Columns["dgvPhone"].DataPropertyName = "phone";
                        dgvStudentTable.Columns["dgvEmail"].DataPropertyName = "email";
                        dgvStudentTable.Columns["dgvIdNo"].DataPropertyName = "id_no";
                        dgvStudentTable.Columns["dgvClass"].DataPropertyName = "class_name";
                        dgvStudentTable.Columns["dgvClassID"].DataPropertyName = "class_id";
                        dgvStudentTable.Columns["dgvMajor"].DataPropertyName = "major_name";
                        dgvStudentTable.Columns["dgvFacu"].DataPropertyName = "facu_name";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void autoLabel3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel4_Click(object sender, EventArgs e)
        {
        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

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

        }
    }
}
