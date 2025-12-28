namespace BTL_QLHSSV_NETFW
{
    partial class UC_KyLuat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReason = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboStudentId = new System.Windows.Forms.ComboBox();
            this.txtSoQuyetDinh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel16 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel15 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cbbKyLuatType = new System.Windows.Forms.ComboBox();
            this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtKyLuatId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.dtgvKyLuat = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtKyLuatIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dateTimePicker1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpKyLuatDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtgvKyLuatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvKyLuatTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvKyLuatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDecisionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvNgaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvNgayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQuyetDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyLuatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKyLuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyLuatIdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1129, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 180);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(8, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(94, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(8, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(94, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtpKyLuatDate);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.txtTenSinhVien);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.cboStudentId);
            this.groupBox1.Controls.Add(this.txtSoQuyetDinh);
            this.groupBox1.Controls.Add(this.autoLabel16);
            this.groupBox1.Controls.Add(this.autoLabel15);
            this.groupBox1.Controls.Add(this.cbbKyLuatType);
            this.groupBox1.Controls.Add(this.autoLabel14);
            this.groupBox1.Controls.Add(this.autoLabel13);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.txtKyLuatId);
            this.groupBox1.Controls.Add(this.autoLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(35, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kỉ luật";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtReason.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtReason.Location = new System.Drawing.Point(119, 130);
            this.txtReason.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtReason.Name = "txtReason";
            this.txtReason.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(459, 29);
            this.txtReason.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtReason.TabIndex = 48;
            this.txtReason.ThemeName = "Office2007";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(405, 84);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(173, 29);
            this.txtTenSinhVien.TabIndex = 47;
            // 
            // autoLabel5
            // 
            this.autoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(610, 136);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(101, 21);
            this.autoLabel5.TabIndex = 45;
            this.autoLabel5.Text = "Ngày hết hạn";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(321, 84);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(54, 21);
            this.autoLabel4.TabIndex = 44;
            this.autoLabel4.Text = "Tên SV";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // cboStudentId
            // 
            this.cboStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboStudentId.FormattingEnabled = true;
            this.cboStudentId.IntegralHeight = false;
            this.cboStudentId.Location = new System.Drawing.Point(119, 84);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(175, 29);
            this.cboStudentId.TabIndex = 33;
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtSoQuyetDinh.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtSoQuyetDinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtSoQuyetDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoQuyetDinh.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtSoQuyetDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(752, 39);
            this.txtSoQuyetDinh.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(156, 29);
            this.txtSoQuyetDinh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtSoQuyetDinh.TabIndex = 42;
            this.txtSoQuyetDinh.ThemeName = "Office2007";
            // 
            // autoLabel16
            // 
            this.autoLabel16.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel16.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel16.Location = new System.Drawing.Point(12, 136);
            this.autoLabel16.Name = "autoLabel16";
            this.autoLabel16.Size = new System.Drawing.Size(45, 21);
            this.autoLabel16.TabIndex = 40;
            this.autoLabel16.Text = "Lý do";
            this.autoLabel16.ThemeName = "Managed";
            // 
            // autoLabel15
            // 
            this.autoLabel15.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel15.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel15.Location = new System.Drawing.Point(610, 40);
            this.autoLabel15.Name = "autoLabel15";
            this.autoLabel15.Size = new System.Drawing.Size(54, 21);
            this.autoLabel15.TabIndex = 38;
            this.autoLabel15.Text = "Số QĐ";
            this.autoLabel15.ThemeName = "Managed";
            // 
            // cbbKyLuatType
            // 
            this.cbbKyLuatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKyLuatType.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cbbKyLuatType.FormattingEnabled = true;
            this.cbbKyLuatType.Location = new System.Drawing.Point(405, 39);
            this.cbbKyLuatType.Name = "cbbKyLuatType";
            this.cbbKyLuatType.Size = new System.Drawing.Size(173, 29);
            this.cbbKyLuatType.TabIndex = 37;
            // 
            // autoLabel14
            // 
            this.autoLabel14.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel14.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel14.Location = new System.Drawing.Point(321, 39);
            this.autoLabel14.Name = "autoLabel14";
            this.autoLabel14.Size = new System.Drawing.Size(76, 21);
            this.autoLabel14.TabIndex = 36;
            this.autoLabel14.Text = "Hình thức";
            this.autoLabel14.ThemeName = "Managed";
            // 
            // autoLabel13
            // 
            this.autoLabel13.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel13.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel13.Location = new System.Drawing.Point(610, 84);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(88, 21);
            this.autoLabel13.TabIndex = 34;
            this.autoLabel13.Text = "Ngày kỉ luật";
            this.autoLabel13.ThemeName = "Managed";
            // 
            // autoLabel12
            // 
            this.autoLabel12.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel12.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(12, 84);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(53, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Mã SV";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // txtKyLuatId
            // 
            this.txtKyLuatId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtKyLuatId.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtKyLuatId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtKyLuatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKyLuatId.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtKyLuatId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtKyLuatId.Location = new System.Drawing.Point(119, 39);
            this.txtKyLuatId.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtKyLuatId.Name = "txtKyLuatId";
            this.txtKyLuatId.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtKyLuatId.ReadOnly = true;
            this.txtKyLuatId.Size = new System.Drawing.Size(175, 29);
            this.txtKyLuatId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtKyLuatId.TabIndex = 31;
            this.txtKyLuatId.ThemeName = "Office2007";
            // 
            // autoLabel11
            // 
            this.autoLabel11.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel11.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(12, 40);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(74, 21);
            this.autoLabel11.TabIndex = 30;
            this.autoLabel11.Text = "Mã kỉ luật";
            this.autoLabel11.ThemeName = "Managed";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 857);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 857);
            this.panel1.TabIndex = 9;
            // 
            // autoLabel1
            // 
            this.autoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel1.Location = new System.Drawing.Point(36, 36);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(176, 37);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Quản lý kỉ luật";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = this;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // dtgvKyLuat
            // 
            this.dtgvKyLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvKyLuatId,
            this.dtgvStudentId,
            this.dtgvKyLuatTenSV,
            this.dtgvKyLuatType,
            this.dtgvDecisionNo,
            this.dtgvReason,
            this.dtgvNgaybatdau,
            this.dtgvNgayketthuc});
            this.dtgvKyLuat.Location = new System.Drawing.Point(35, 388);
            this.dtgvKyLuat.Name = "dtgvKyLuat";
            this.dtgvKyLuat.RowHeadersWidth = 51;
            this.dtgvKyLuat.Size = new System.Drawing.Size(1263, 195);
            this.dtgvKyLuat.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtStudentIdSearch);
            this.groupBox3.Controls.Add(this.autoLabel2);
            this.groupBox3.Controls.Add(this.txtKyLuatIdSearch);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox3.Location = new System.Drawing.Point(35, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 88);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1024, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtStudentIdSearch
            // 
            this.txtStudentIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtStudentIdSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtStudentIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtStudentIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentIdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtStudentIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStudentIdSearch.Location = new System.Drawing.Point(619, 40);
            this.txtStudentIdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtStudentIdSearch.Name = "txtStudentIdSearch";
            this.txtStudentIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStudentIdSearch.Size = new System.Drawing.Size(250, 29);
            this.txtStudentIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtStudentIdSearch.TabIndex = 33;
            this.txtStudentIdSearch.ThemeName = "Office2007";
            // 
            // autoLabel2
            // 
            this.autoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel2.Location = new System.Drawing.Point(512, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(53, 21);
            this.autoLabel2.TabIndex = 32;
            this.autoLabel2.Text = "Mã SV";
            this.autoLabel2.ThemeName = "Managed";
            // 
            // txtKyLuatIdSearch
            // 
            this.txtKyLuatIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtKyLuatIdSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtKyLuatIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtKyLuatIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKyLuatIdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtKyLuatIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtKyLuatIdSearch.Location = new System.Drawing.Point(119, 40);
            this.txtKyLuatIdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtKyLuatIdSearch.Name = "txtKyLuatIdSearch";
            this.txtKyLuatIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtKyLuatIdSearch.Size = new System.Drawing.Size(175, 29);
            this.txtKyLuatIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtKyLuatIdSearch.TabIndex = 31;
            this.txtKyLuatIdSearch.ThemeName = "Office2007";
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(12, 40);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(74, 21);
            this.autoLabel3.TabIndex = 30;
            this.autoLabel3.Text = "Mã kỉ luật";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowValueChangeOnMouseWheel = true;
            this.dateTimePicker1.DateTimeIcon = null;
            this.dateTimePicker1.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dateTimePicker1.Format = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 29);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.ThemeName = "Managed";
            this.dateTimePicker1.ToolTipText = "";
            this.dateTimePicker1.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // dtpKyLuatDate
            // 
            this.dtpKyLuatDate.AllowValueChangeOnMouseWheel = true;
            this.dtpKyLuatDate.DateTimeIcon = null;
            this.dtpKyLuatDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtpKyLuatDate.Format = "dd/MM/yyyy";
            this.dtpKyLuatDate.Location = new System.Drawing.Point(752, 84);
            this.dtpKyLuatDate.Name = "dtpKyLuatDate";
            this.dtpKyLuatDate.Size = new System.Drawing.Size(156, 29);
            this.dtpKyLuatDate.TabIndex = 36;
            this.dtpKyLuatDate.ThemeName = "Managed";
            this.dtpKyLuatDate.ToolTipText = "";
            this.dtpKyLuatDate.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // dtgvKyLuatId
            // 
            this.dtgvKyLuatId.HeaderText = "Mã kỉ luật";
            this.dtgvKyLuatId.MinimumWidth = 6;
            this.dtgvKyLuatId.Name = "dtgvKyLuatId";
            // 
            // dtgvStudentId
            // 
            this.dtgvStudentId.HeaderText = "Mã SV";
            this.dtgvStudentId.MinimumWidth = 6;
            this.dtgvStudentId.Name = "dtgvStudentId";
            // 
            // dtgvKyLuatTenSV
            // 
            this.dtgvKyLuatTenSV.HeaderText = "Tên SV";
            this.dtgvKyLuatTenSV.MinimumWidth = 6;
            this.dtgvKyLuatTenSV.Name = "dtgvKyLuatTenSV";
            // 
            // dtgvKyLuatType
            // 
            this.dtgvKyLuatType.HeaderText = "Hình thức";
            this.dtgvKyLuatType.MinimumWidth = 6;
            this.dtgvKyLuatType.Name = "dtgvKyLuatType";
            // 
            // dtgvDecisionNo
            // 
            this.dtgvDecisionNo.HeaderText = "Số QĐ";
            this.dtgvDecisionNo.MinimumWidth = 6;
            this.dtgvDecisionNo.Name = "dtgvDecisionNo";
            // 
            // dtgvReason
            // 
            this.dtgvReason.HeaderText = "Lý do";
            this.dtgvReason.MinimumWidth = 6;
            this.dtgvReason.Name = "dtgvReason";
            // 
            // dtgvNgaybatdau
            // 
            this.dtgvNgaybatdau.HeaderText = "Ngày bắt đầu";
            this.dtgvNgaybatdau.MinimumWidth = 6;
            this.dtgvNgaybatdau.Name = "dtgvNgaybatdau";
            // 
            // dtgvNgayketthuc
            // 
            this.dtgvNgayketthuc.HeaderText = "Ngày kết thúc";
            this.dtgvNgayketthuc.MinimumWidth = 6;
            this.dtgvNgayketthuc.Name = "dtgvNgayketthuc";
            // 
            // UC_KyLuat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvKyLuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.Name = "UC_KyLuat";
            this.Size = new System.Drawing.Size(1340, 857);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQuyetDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyLuatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKyLuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKyLuatIdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.ComboBox cboStudentId;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSoQuyetDinh;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel16;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel15;
        private System.Windows.Forms.ComboBox cbbKyLuatType;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKyLuatId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private System.Windows.Forms.DataGridView dtgvKyLuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKyLuatIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtReason;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpKyLuatDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvKyLuatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvKyLuatTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvKyLuatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvDecisionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNgaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNgayketthuc;
    }
}
