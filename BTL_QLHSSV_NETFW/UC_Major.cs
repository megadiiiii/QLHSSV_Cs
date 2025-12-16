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
using MySql.Data.MySqlClient;

namespace BTL_QLHSSV_NETFW
{
    public partial class UC_Major : UserControl
    {
        public UC_Major()
        {
            InitializeComponent();
        }

        private void facultiesLoad()
        {
            try
            {
                DataTable dtFacu = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select facu_id, facu_name from faculties";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtFacu);
                        }
                    }
                }

                //cbo add/edit/del
                cboFacuName.DataSource = dtFacu;
                cboFacuName.DisplayMember = "facu_name";
                cboFacuName.ValueMember = "facu_id";
                cboFacuName.SelectedIndex = -1;

                //cbo search
                cboFacuNameSearch.DataSource = dtFacu.Copy();
                cboFacuNameSearch.DisplayMember = "facu_name";
                cboFacuNameSearch.ValueMember = "facu_id";
                cboFacuNameSearch.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void majorsLoad()
        {
            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"select m.major_id, m.major_name, facu_name, m.facu_id
                                    from major m
                                    join faculties f on f.facu_id = m.facu_id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvMajorId.DataPropertyName = "major_id";
                            dgvMajorName.DataPropertyName = "major_name";
                            dgvFacuId.DataPropertyName = "facu_id";
                            dgvFacuName.DataPropertyName = "facu_name";
                            dgvMajor.DataSource = dt;
                            dgvMajor.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_Major_Load(object sender, EventArgs e)
        {
            facultiesLoad();
            majorsLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string majorId = txtMajorId.Text.Trim();
            string majorName = txtMajorName.Text.Trim();

            if (string.IsNullOrEmpty(majorId))
            {
                MessageBox.Show("Nhập mã chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(majorName))
            {
                MessageBox.Show("Nhập tên chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorName.Focus();
                return;
            }
            if (cboFacuName.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string facuId = cboFacuName.SelectedValue.ToString();

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO major (major_id, major_name, facu_id) 
                                VALUES (@majorId, @majorName, @facuId)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@majorId", majorId);
                        cmd.Parameters.AddWithValue("@majorName", majorName);
                        cmd.Parameters.AddWithValue("@facuId", facuId);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        majorsLoad();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvMajor.Rows[e.RowIndex];
            txtMajorId.Text = row.Cells["dgvMajorId"].Value?.ToString();
            txtMajorName.Text = row.Cells["dgvMajorName"].Value?.ToString();
            cboFacuName.SelectedValue = row.Cells["dgvFacuId"].Value?.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string majorId = txtMajorId.Text.Trim();
            string majorName = txtMajorName.Text.Trim();
            string facuId = cboFacuName.SelectedValue.ToString();

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE major 
                                   SET major_name = @majorName, facu_id = @facuId
                                   WHERE major_id = @majorId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@majorId", majorId);
                        cmd.Parameters.AddWithValue("@majorName", majorName);
                        cmd.Parameters.AddWithValue("@facuId", facuId);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        majorsLoad();
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
            string id = txtMajorId.Text.Trim();

            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"delete from major where major_id = @id";
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
                            majorsLoad();
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
            string majorId = txtMajorIdSearch.Text.Trim();
            string majorName = txtMajorNameSearch.Text.Trim();
            string facuId = cboFacuNameSearch.SelectedValue.ToString() ?? "";

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"select major_id, major_name, facu_name, m.facu_id
                                    from major m
                                    join faculties f on f.facu_id = m.facu_id
                                    where (@majorId = '' or major_id like @majorId)
                                    and (@majorName = '' or major_name like @majorName)
                                    and (@facuId = '' or m.facu_id = @facuId)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@majorId", majorId);
                        cmd.Parameters.AddWithValue("@majorName", majorName);
                        cmd.Parameters.AddWithValue("@facuId", facuId);

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvMajor.DataSource = dt;
                            dgvMajor.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
