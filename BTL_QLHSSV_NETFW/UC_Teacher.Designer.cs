namespace BTL_QLHSSV_NETFW
{
    partial class UC_Teacher
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTeacherId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTeacherName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboFacuId = new System.Windows.Forms.ComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFacuName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.dtgvTeacher = new System.Windows.Forms.DataGridView();
            this.dtgvTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFacuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvFacuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTeacherIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTeacherNameSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboFacuIdSearch = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherIdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherNameSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
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
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Location = new System.Drawing.Point(8, 130);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTeacherId);
            this.groupBox1.Controls.Add(this.autoLabel14);
            this.groupBox1.Controls.Add(this.txtTeacherName);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.cboFacuId);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.txtFacuName);
            this.groupBox1.Controls.Add(this.autoLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 180);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng viên";
            // 
            // autoLabel11
            // 
            this.autoLabel11.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel11.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(12, 35);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(104, 21);
            this.autoLabel11.TabIndex = 30;
            this.autoLabel11.Text = "Mã giảng viên";
            this.autoLabel11.ThemeName = "Managed";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtTeacherId.BeforeTouchSize = new System.Drawing.Size(290, 29);
            this.txtTeacherId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtTeacherId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherId.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTeacherId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtTeacherId.Location = new System.Drawing.Point(150, 34);
            this.txtTeacherId.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtTeacherId.Size = new System.Drawing.Size(259, 29);
            this.txtTeacherId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtTeacherId.TabIndex = 31;
            this.txtTeacherId.ThemeName = "Office2007";
            // 
            // autoLabel14
            // 
            this.autoLabel14.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel14.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel14.Location = new System.Drawing.Point(429, 36);
            this.autoLabel14.Name = "autoLabel14";
            this.autoLabel14.Size = new System.Drawing.Size(105, 21);
            this.autoLabel14.TabIndex = 36;
            this.autoLabel14.Text = "Tên giảng viên";
            this.autoLabel14.ThemeName = "Managed";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtTeacherName.BeforeTouchSize = new System.Drawing.Size(290, 29);
            this.txtTeacherName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtTeacherName.Location = new System.Drawing.Point(559, 34);
            this.txtTeacherName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtTeacherName.Size = new System.Drawing.Size(290, 29);
            this.txtTeacherName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtTeacherName.TabIndex = 37;
            this.txtTeacherName.ThemeName = "Office2007";
            // 
            // autoLabel12
            // 
            this.autoLabel12.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel12.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(12, 78);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(68, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Mã khoa";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // cboFacuId
            // 
            this.cboFacuId.FormattingEnabled = true;
            this.cboFacuId.IntegralHeight = false;
            this.cboFacuId.Location = new System.Drawing.Point(150, 76);
            this.cboFacuId.Name = "cboFacuId";
            this.cboFacuId.Size = new System.Drawing.Size(259, 29);
            this.cboFacuId.TabIndex = 33;
            this.cboFacuId.SelectionChangeCommitted += new System.EventHandler(this.cboFacuId_SelectionChangeCommitted);
            this.cboFacuId.TextChanged += new System.EventHandler(this.cboFacuId_TextChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(429, 78);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(69, 21);
            this.autoLabel4.TabIndex = 44;
            this.autoLabel4.Text = "Tên khoa";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // txtFacuName
            // 
            this.txtFacuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFacuName.BeforeTouchSize = new System.Drawing.Size(290, 29);
            this.txtFacuName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtFacuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacuName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtFacuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFacuName.Location = new System.Drawing.Point(559, 78);
            this.txtFacuName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtFacuName.Name = "txtFacuName";
            this.txtFacuName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFacuName.ReadOnly = true;
            this.txtFacuName.Size = new System.Drawing.Size(290, 29);
            this.txtFacuName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtFacuName.TabIndex = 49;
            this.txtFacuName.ThemeName = "Office2007";
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
            this.autoLabel1.Size = new System.Drawing.Size(226, 37);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Quản lý giảng viên";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = this;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // dtgvTeacher
            // 
            this.dtgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvTeacherId,
            this.dtgvTeacherName,
            this.dtgvFacuId,
            this.dtgvFacuName});
            this.dtgvTeacher.Location = new System.Drawing.Point(35, 388);
            this.dtgvTeacher.Name = "dtgvTeacher";
            this.dtgvTeacher.RowHeadersWidth = 51;
            this.dtgvTeacher.Size = new System.Drawing.Size(1263, 195);
            this.dtgvTeacher.TabIndex = 15;
            this.dtgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTeacher_CellClick);
            // 
            // dtgvTeacherId
            // 
            this.dtgvTeacherId.HeaderText = "Mã giảng viên";
            this.dtgvTeacherId.MinimumWidth = 6;
            this.dtgvTeacherId.Name = "dtgvTeacherId";
            // 
            // dtgvTeacherName
            // 
            this.dtgvTeacherName.HeaderText = "Tên giảng viên";
            this.dtgvTeacherName.MinimumWidth = 6;
            this.dtgvTeacherName.Name = "dtgvTeacherName";
            // 
            // dtgvFacuId
            // 
            this.dtgvFacuId.HeaderText = "Mã khoa";
            this.dtgvFacuId.MinimumWidth = 6;
            this.dtgvFacuId.Name = "dtgvFacuId";
            // 
            // dtgvFacuName
            // 
            this.dtgvFacuName.HeaderText = "Tên khoa";
            this.dtgvFacuName.MinimumWidth = 6;
            this.dtgvFacuName.Name = "dtgvFacuName";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Controls.Add(this.txtTeacherIdSearch);
            this.groupBox3.Controls.Add(this.autoLabel2);
            this.groupBox3.Controls.Add(this.txtTeacherNameSearch);
            this.groupBox3.Controls.Add(this.autoLabel5);
            this.groupBox3.Controls.Add(this.cboFacuIdSearch);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox3.Location = new System.Drawing.Point(35, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 109);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1120, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(12, 40);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(104, 21);
            this.autoLabel3.TabIndex = 30;
            this.autoLabel3.Text = "Mã giảng viên";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // txtTeacherIdSearch
            // 
            this.txtTeacherIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtTeacherIdSearch.BeforeTouchSize = new System.Drawing.Size(290, 29);
            this.txtTeacherIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtTeacherIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherIdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTeacherIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtTeacherIdSearch.Location = new System.Drawing.Point(150, 38);
            this.txtTeacherIdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtTeacherIdSearch.Name = "txtTeacherIdSearch";
            this.txtTeacherIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtTeacherIdSearch.Size = new System.Drawing.Size(260, 29);
            this.txtTeacherIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtTeacherIdSearch.TabIndex = 31;
            this.txtTeacherIdSearch.ThemeName = "Office2007";
            // 
            // autoLabel2
            // 
            this.autoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel2.Location = new System.Drawing.Point(430, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(105, 21);
            this.autoLabel2.TabIndex = 32;
            this.autoLabel2.Text = "Tên giảng viên";
            this.autoLabel2.ThemeName = "Managed";
            // 
            // txtTeacherNameSearch
            // 
            this.txtTeacherNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtTeacherNameSearch.BeforeTouchSize = new System.Drawing.Size(290, 29);
            this.txtTeacherNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtTeacherNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherNameSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTeacherNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtTeacherNameSearch.Location = new System.Drawing.Point(560, 38);
            this.txtTeacherNameSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtTeacherNameSearch.Name = "txtTeacherNameSearch";
            this.txtTeacherNameSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtTeacherNameSearch.Size = new System.Drawing.Size(290, 29);
            this.txtTeacherNameSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtTeacherNameSearch.TabIndex = 33;
            this.txtTeacherNameSearch.ThemeName = "Office2007";
            // 
            // autoLabel5
            // 
            this.autoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(870, 40);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(68, 21);
            this.autoLabel5.TabIndex = 45;
            this.autoLabel5.Text = "Mã khoa";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // cboFacuIdSearch
            // 
            this.cboFacuIdSearch.FormattingEnabled = true;
            this.cboFacuIdSearch.IntegralHeight = false;
            this.cboFacuIdSearch.Location = new System.Drawing.Point(950, 38);
            this.cboFacuIdSearch.Name = "cboFacuIdSearch";
            this.cboFacuIdSearch.Size = new System.Drawing.Size(150, 29);
            this.cboFacuIdSearch.TabIndex = 46;
            // 
            // UC_Teacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvTeacher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.Name = "UC_Teacher";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_Teacher_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherIdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherNameSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTeacherId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTeacherName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private System.Windows.Forms.ComboBox cboFacuId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFacuName;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;

        private System.Windows.Forms.DataGridView dtgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFacuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFacuName;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTeacherIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTeacherNameSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private System.Windows.Forms.ComboBox cboFacuIdSearch;
    }
}
