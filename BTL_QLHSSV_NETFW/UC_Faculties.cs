using ClosedXML.Excel;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Khoa");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 5).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH KHOA";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã khoa", "Tên khoa" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 3).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 3).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 3).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"select * from faculties
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
                            ws.Cell(rowIndex, 2).Value = reader["facu_id"].ToString();
                            ws.Cell(rowIndex, 3).Value = reader["facu_name"].ToString();


                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 3).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 3).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 3);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 5);

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
                    sfd.Title = "Lưu danh sách chuyên ngành";
                    sfd.FileName = "Danh_sach_chuyen_nganh.xlsx"; // tên gợi ý

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
