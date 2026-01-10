using ClosedXML.Excel;
using DocumentFormat.OpenXml.VariantTypes;
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
    public partial class UC_Scholarship : UserControl
    {
        public UC_Scholarship()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Học bổng");
            ws.Style.Font.FontName = "Times New Roman";

            //Title
            ws.Range(1, 1, 2, 7).Merge();
            ws.Cell(1, 1).Value = "DANH SÁCH HỌC BỔNG";
            ws.Cell(1, 1).Style.Font.SetBold().Font.FontSize = 16;
            ws.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell(1, 1).Style.Fill.SetBackgroundColor(XLColor.NoColor);

            //Header
            String[] headers = { "STT", "Mã SV", "Tên SV", "Học lực", "Rèn luyện", "Mức HB", "Học kỳ" };
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(4, i + 1).Value = headers[i];

                ws.Range(4, 1, 4, 7).Style.Font.SetBold().Font.FontSize = 14;
                ws.Range(4, 1, 4, 7).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Range(4, 1, 4, 7).Style.Fill.SetBackgroundColor(XLColor.LightGray);
            }


            //Data
            using (MySqlConnection conn = dbConn.GetConnection())
            {

                //Lấy data từ database
                string sql = @"
                        SELECT scholarship_id, st.student_id,
                               CONCAT(st.student_lastName, ' ', st.student_firstName) AS student_name,
                               score_level, drl_level, scholarship_level, semester 
                        FROM scholarship ss
                        JOIN student st on st.student_id = ss.student_id
                        ORDER BY scholarship_id";
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
                            ws.Cell(rowIndex, 4).Value = reader["score_level"].ToString();
                            ws.Cell(rowIndex, 5).Value = reader["drl_level"].ToString();
                            ws.Cell(rowIndex, 6).Value = reader["scholarship_level"].ToString();
                            ws.Cell(rowIndex, 7).Value = reader["semester"].ToString();

                            //Styling cột
                            ws.Range(rowIndex, 1, rowIndex, 7).Style.Font.FontSize = 13;
                            ws.Range(rowIndex, 1, rowIndex, 7).Style.Font.SetBold(false);

                            //Hàng tiếp theo
                            rowIndex++;
                        }
                        //Filter & Sort
                        var tableRange = ws.Range(4, 1, rowIndex - 1, 7);
                        var table = tableRange.CreateTable();
                        table.ShowAutoFilter = true;
                        table.Theme = XLTableTheme.None;

                        //Borders
                        // Border toàn bộ bảng (từ header đến dòng cuối)
                        var usedRange = ws.Range(4, 1, ws.LastRowUsed().RowNumber(), 7);

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
                    sfd.FileName = "Danh_sach_hoc_bong.xlsx"; // tên gợi ý

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

        }

        private void UC_Scholarship_Load(object sender, EventArgs e)
        {
            loadTable();
            LoadStudentId();
        }

        private void loadTable()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbConn.GetConnection())
            {
                string sql = @"
                        SELECT scholarship_id, st.student_id,
                               CONCAT(st.student_lastName, ' ', st.student_firstName) AS student_name,
                               score_level, drl_level, scholarship_level, semester 
                        FROM scholarship ss
                        JOIN student st on st.student_id = ss.student_id
                        ORDER BY scholarship_id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                dgvId.DataPropertyName = "scholarship_id";
                dgvStudentId.DataPropertyName = "student_id";
                dgvStudentName.DataPropertyName = "student_name";
                dgvScoreLevel.DataPropertyName = "score_level";
                dgvDrlLevel.DataPropertyName = "drl_level";
                dgvScholarshipLevel.DataPropertyName = "scholarship_level";
                dgvSemester.DataPropertyName = "semester";
                dgvScholarship.DataSource = dt;
                dgvScholarship.Refresh();

                dgvId.Visible = false;
            }
        }

        private void dgvScholarship_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvScholarship.Rows[e.RowIndex];
            cboStudentId.Text = row.Cells["dgvStudentId"].Value.ToString();
            txtFullName.Text = row.Cells["dgvStudentName"].Value.ToString();
            cboScoreLevel.Text = row.Cells["dgvScoreLevel"].Value.ToString();
            cboDrlLevel.Text = row.Cells["dgvDrlLevel"].Value.ToString();
            cboScholarshipLevel.Text = row.Cells["dgvScholarshipLevel"].Value.ToString();
            cboSemester.Text = row.Cells["dgvSemester"].Value.ToString();
        }

        private void LoadStudentId()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = dbConn.GetConnection())
                {
                    string sql = @"
                SELECT 
                    s.student_id,
                    CONCAT(s.student_lastName, ' ', s.student_firstName) AS student_name
                FROM student s
                ORDER BY s.student_id ASC";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }

                cboStudentId.DataSource = dt;
                cboStudentId.DisplayMember = "student_id";   // hiện mã
                cboStudentId.ValueMember = "student_id";     // value là mã

                // Auto complete
                cboStudentId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboStudentId.AutoCompleteSuggestMode = AutoCompleteSuggestMode.Contains;

                cboStudentId.SelectedIndex = -1;
                txtFullName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboStudentId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboStudentId.SelectedItem is DataRowView row)
            {
                txtFullName.Text = row["student_name"].ToString();
            }
            else
            {
                txtFullName.Clear();
            }
        }
    }
}
