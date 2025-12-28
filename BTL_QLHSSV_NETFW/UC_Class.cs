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

        private void majorLoad(string facuId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = "select major_id, major_name from major where facu_id=@facuId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@facuId", facuId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
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

        private void classLoad()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select c.class_id, class_name, cohort, m.major_name, f.facu_name
                                    from class c
                                    join major m on m.major_id = c.major_id
                                    join faculties f on f.facu_id = m.facu_id";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvClassID.DataPropertyName = "class_id";
                    dgvClassName.DataPropertyName = "class_name";
                    dgvFacu.DataPropertyName = "facu_name";
                    dgvMajor.DataPropertyName = "major_name";
                    dgvCohort.DataPropertyName = "cohort";

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
            txtCohort.Value = Convert.ToInt32(row.Cells["dgvCohort"].Value);
        }

        /* ================= ADD ================= */

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassID.Text) ||
                string.IsNullOrEmpty(txtClassName.Text) ||
                cboFacu.SelectedIndex == -1 ||
                cboMajor.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"insert into class(class_id,class_name,major_id, cohort)
                                   values(@id,@name,@major, @cohort)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtClassID.Text);
                    cmd.Parameters.AddWithValue("@name", txtClassName.Text);
                    cmd.Parameters.AddWithValue("@major", cboMajor.SelectedValue);
                    cmd.Parameters.AddWithValue("@cohort", txtCohort.Value.ToString());

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    classLoad();
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
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"update class
                                   set class_name=@name,
                                       major_id=@major,
                                       cohort=@cohort
                                   where class_id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtClassID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtClassName.Text.Trim());
                    cmd.Parameters.AddWithValue("@major", cboMajor.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@cohort", txtCohort.Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    classLoad();
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
                    string sql = @"select c.class_id, class_name, cohort, m.major_name, f.facu_name
                                   from class c
                                   join major m on m.major_id = c.major_id
                                   join faculties f on f.facu_id = m.facu_id
                                   where (@id='' or c.class_id like @id)
                                     and (@name='' or c.class_name like @name)
                                     and (@cohort='' or cohort like @cohort)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", "%" + txtClassIDSearch.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@name", "%" + txtClassNameSearch.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@cohort", "%" + txtCohortSearch.Text.Trim() + "%");

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
            }
}
