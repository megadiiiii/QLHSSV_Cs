using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using Syncfusion.WinForms.ListView.Enums;
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
    public partial class UC_Role : UserControl
    {
        public UC_Role()
        {
            InitializeComponent();
        }

        private void UC_Role_Load(object sender, EventArgs e)
        {
            roleLoad();
            LoadClassId();
        }

        private void roleLoad()
        {
            try
            {
                DataTable dt = new DataTable();
                {
                    using (MySqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open();
                        string sql = @"
                        SELECT r.role_id,
                               s.class_id,
                               c.class_name,
                               r.student_id,
                               CONCAT(s.student_lastName,' ',s.student_firstName) AS student_name,
                               r.student_role
                        FROM role r
                        JOIN student s ON r.student_id = s.student_id
                        JOIN class c ON s.class_id = c.class_id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                adapter.Fill(dt);
                            }
                        }

                        dtgvRole.AutoGenerateColumns = false;

                        dtgvClassId.DataPropertyName = "class_id";
                        dtgvClassName.DataPropertyName = "class_name";
                        dtgvStudentId.DataPropertyName = "student_id";
                        dtgvStudentName.DataPropertyName = "student_name";
                        dtgvStudentRole.DataPropertyName = "student_role";
                        dtgvRoleId.DataPropertyName = "role_id";

                        dtgvRole.DataSource = dt;
                        dtgvRole.Refresh();

                        dtgvRoleId.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load role: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudentId.SelectedIndex == -1 || cboStudentRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Sinh viên và Vai trò!");
                return;
            }

            try
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO role(student_id, student_role) VALUES(@sid,@role)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@sid", cboStudentId.SelectedValue);
                    cmd.Parameters.AddWithValue("@role", cboStudentRole.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm vai trò thành công!");
                roleLoad();
                clearInput();
            }
            catch
            {
                MessageBox.Show("Sinh viên này đã có vai trò!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvRole.CurrentCell == null)
            {
                MessageBox.Show("Chọn dòng để xóa");
                return;
            }

            int rowIndex = dtgvRole.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Dòng không hợp lệ");
                return;
            }

            DataGridViewRow row = dtgvRole.Rows[rowIndex];

            int id = Convert.ToInt32(row.Cells["dtgvRoleId"].Value);

            if (MessageBox.Show("Xóa vai trò này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM role WHERE role_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Xóa thành công!");
                roleLoad();
            }
            clearInput();
        }

        private void LoadClassId()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"
                         SELECT class_id,class_name
                         FROM class
                         ORDER BY class_id";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboClassId.DataSource = dt;
                cboClassId.DisplayMember = "class_id";   // hiện mã
                cboClassId.ValueMember = "class_id";     // value là mã

                // Auto complete
                cboClassId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                cboClassId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboClassId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClassId.SelectedItem is DataRowView row)
            {
                string classId = row["class_id"].ToString();
                txtClassName.Text = row["class_name"].ToString();

                LoadStudentByClass(classId);
            }
            else
            {
                txtClassName.Clear();
            }
        }

        private void LoadStudentByClass(string classId)
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"
                SELECT 
                    student_id,
                    CONCAT(student_lastName,' ',student_firstName) AS student_name
                FROM student
                WHERE class_id = @classId
                ORDER BY student_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@classId", classId);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }

                cboStudentId.DataSource = dt;
                cboStudentId.DisplayMember = "student_id";   // hiện MSSV
                cboStudentId.ValueMember = "student_id";

                cboStudentId.SelectedIndex = -1;
                txtStudentName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load sinh viên: " + ex.Message);
            }
        }

        private void cboStudentId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboStudentId.SelectedItem is DataRowView row)
            {
                txtStudentName.Text = row["student_name"].ToString();
            }
            else
            {
                txtStudentName.Clear();
            }
        }

        public void clearInput()
        {
            cboClassId.SelectedIndex = -1;
            cboStudentId.SelectedIndex = -1;
            cboStudentRole.SelectedIndex = -1;
            txtClassName.Clear();
            txtStudentName.Clear();
        }

        private void dtgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dtgvRole.Rows[e.RowIndex];

            txtClassName.Text = row.Cells["dtgvClassName"].Value?.ToString();
            txtStudentName.Text = row.Cells["dtgvStudentName"].Value?.ToString();
            cboClassId.Text = row.Cells["dtgvClassId"].Value?.ToString();
            cboStudentId.Text = row.Cells["dtgvStudentId"].Value?.ToString();
            cboStudentRole.Text = row.Cells["dtgvStudentRole"].Value?.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgvRole.CurrentCell == null)
            {
                MessageBox.Show("Chọn dòng để cập nhật");
                return;
            }

            int rowIndex = dtgvRole.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Dòng không hợp lệ");
                return;
            }

            DataGridViewRow row = dtgvRole.Rows[rowIndex];

            int id = Convert.ToInt32(row.Cells["dtgvRoleId"].Value);

            if (cboStudentRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Vai trò!");
                return;
            }

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE role 
                       SET student_id = @sid, student_role = @role 
                       WHERE role_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", cboStudentId.SelectedValue);
                    cmd.Parameters.AddWithValue("@role", cboStudentRole.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        roleLoad();
                        clearInput();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được cập nhật!");
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("CBL");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 6).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH CÁN BỘ LỚP";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã lớp", "Tên lớp", "Mã sinh viên", "Tên sinh viên", "Vai trò" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 6).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 6).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 6).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"
                        SELECT r.role_id,
                               s.class_id,
                               c.class_name,
                               r.student_id,
                               CONCAT(s.student_lastName,' ',s.student_firstName) AS student_name,
                               r.student_role
                        FROM role r
                        JOIN student s ON r.student_id = s.student_id
                        JOIN class c ON s.class_id = c.class_id";
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
                            ws.Cell(rowIndex, 3).Value = reader["student_name"].ToString();
                            ws.Cell(rowIndex, 4).Value = reader["class_id"].ToString();
                            ws.Cell(rowIndex, 5).Value = reader["class_name"].ToString();
                            ws.Cell(rowIndex, 6).Value = reader["student_role"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 6).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 6).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 6);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 6);

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
                    sfd.Title = "Lưu danh sách";
                    sfd.FileName = "Danh_sach_can_bo lop.xlsx"; // tên gợi ý

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
            DataTable dt = new DataTable();

            using (MySqlConnection conn = dbConn.GetConnection())
            {
                StringBuilder sql = new StringBuilder(@"
                        SELECT r.role_id,
                               s.class_id,
                               c.class_name,
                               r.student_id,
                               CONCAT(s.student_lastName,' ',s.student_firstName) AS student_name,
                               r.student_role
                        FROM role r
                        JOIN student s ON r.student_id = s.student_id
                        JOIN class c ON s.class_id = c.class_id
                        WHERE 1=1
                    ");


                using (MySqlCommand cmd = new MySqlCommand(sql.ToString(), conn))
                {
                    string studentId = txtStudentIdSearch.Text.Trim();
                    if (!string.IsNullOrEmpty(studentId))
                    {
                        sql.Append(" AND s.student_id LIKE @studentId");
                        cmd.Parameters.AddWithValue("@studentId", "%" + studentId + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(cboRoleSearch.Text))
                    {
                        sql.Append(" AND r.student_role = @role");
                        cmd.Parameters.AddWithValue("@role", cboRoleSearch.Text);
                    }

                    cmd.CommandText = sql.ToString();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            dtgvRole.DataSource = dt;
        }
    }
}