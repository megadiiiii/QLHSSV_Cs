using ClosedXML.Excel;
using MySql.Data.MySqlClient;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Authors");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 5).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH CHUYÊN NGÀNH";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã chuyên ngành", "Tên chuyên ngành", "Mã khoa", "Tên khoa" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 5).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 5).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"select m.*, f.facu_name
                            from major m
                            join faculties f on f.facu_id = m.facu_id
                            order by f.facu_name ASC 
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
                            ws.Cell(rowIndex, 2).Value = reader["major_id"].ToString();
                            ws.Cell(rowIndex, 3).Value = reader["major_name"].ToString();
                            ws.Cell(rowIndex, 4).Value = reader["facu_id"].ToString();
                            ws.Cell(rowIndex, 5).Value = reader["facu_name"].ToString();


                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 5).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 5).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 5);
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
