using MySql.Data.MySqlClient;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLHSSV_NETFW
{
    public partial class UC_Faculties : UserControl
    {
        public UC_Faculties()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loadTable()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = "select * from faculties";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                dgvFacuID.DataPropertyName = "facu_id";
                dgvFacuName.DataPropertyName = "facu_name";
                dgvFacu.DataSource = dt;
                dgvFacu.Refresh();
                txtFacuId.Clear();
                txtFacuName.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtFacuId.Text.Trim();
            string name = txtFacuName.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Không được để trống dữ liệu");
                return;
            }
            try
            {
                using (var conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = @"insert into faculties (facu_id, facu_name) values (@id, @name)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    loadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFaculties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Faculties_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dgvFacu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvFacu.Rows[e.RowIndex];
            txtFacuId.Text = row.Cells["dgvFacuID"].Value?.ToString();
            txtFacuName.Text = row.Cells["dgvFacuName"].Value?.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtFacuId.Text.Trim();
            string name = txtFacuName.Text.Trim();

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE faculties SET facu_name = @name WHERE facu_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hỏng");
                    }
                }
            }
            loadTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtFacuId.Text.Trim();
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"delete from faculties where facu_id = @id";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                            loadTable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtFacuIDSearch.Text.Trim();
            string name = txtFacuNameSearch.Text.Trim();
            try
            {
                MySqlConnection conn = dbConn.GetConnection();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string sql = @"select * from faculties
                        WHERE (@id = '' OR facu_id LIKE @id)
                        AND (@name = '' OR facu_name LIKE @name)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", "%" + id + "%");
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFacu.DataSource = dt;
                        dgvFacu.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            }
}
