namespace BTL_QLHSSV_NETFW
{
    partial class UC_Role
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRole;

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
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClassId = new System.Windows.Forms.ComboBox();
            this.cboStudentId = new System.Windows.Forms.ComboBox();
            this.cboStudentRole = new System.Windows.Forms.ComboBox();
            this.txtClassName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtStudentName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.dtgvRole = new System.Windows.Forms.DataGridView();
            this.dtgvRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvStudentRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboRoleSearch = new System.Windows.Forms.ComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeight = 29;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.Size = new System.Drawing.Size(240, 150);
            this.dgvRole.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
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
            this.btnExport.Location = new System.Drawing.Point(8, 85);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.groupBox1.Controls.Add(this.autoLabel3);
            this.groupBox1.Controls.Add(this.cboClassId);
            this.groupBox1.Controls.Add(this.cboStudentId);
            this.groupBox1.Controls.Add(this.cboStudentRole);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.autoLabel14);
            this.groupBox1.Controls.Add(this.autoLabel13);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.autoLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(35, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cboClassId
            // 
            this.cboClassId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboClassId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboClassId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.IntegralHeight = false;
            this.cboClassId.Location = new System.Drawing.Point(119, 39);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(276, 29);
            this.cboClassId.TabIndex = 0;
            this.cboClassId.SelectedValueChanged += new System.EventHandler(this.cboClassId_SelectedValueChanged);
            // 
            // cboStudentId
            // 
            this.cboStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStudentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboStudentId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboStudentId.FormattingEnabled = true;
            this.cboStudentId.IntegralHeight = false;
            this.cboStudentId.Location = new System.Drawing.Point(119, 84);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(276, 29);
            this.cboStudentId.TabIndex = 2;
            this.cboStudentId.SelectedValueChanged += new System.EventHandler(this.cboStudentId_SelectedValueChanged);
            // 
            // cboStudentRole
            // 
            this.cboStudentRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboStudentRole.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboStudentRole.FormattingEnabled = true;
            this.cboStudentRole.Items.AddRange(new object[] {
            "Lớp trưởng",
            "Lớp phó",
            "Bí thư"});
            this.cboStudentRole.Location = new System.Drawing.Point(119, 128);
            this.cboStudentRole.Name = "cboStudentRole";
            this.cboStudentRole.Size = new System.Drawing.Size(276, 29);
            this.cboStudentRole.TabIndex = 5;
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtClassName.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtClassName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtClassName.Location = new System.Drawing.Point(584, 39);
            this.txtClassName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(464, 29);
            this.txtClassName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtClassName.TabIndex = 1;
            this.txtClassName.ThemeName = "Office2007";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtStudentName.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtStudentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStudentName.Location = new System.Drawing.Point(584, 83);
            this.txtStudentName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(464, 29);
            this.txtStudentName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.ThemeName = "Office2007";
            // 
            // autoLabel14
            // 
            this.autoLabel14.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel14.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel14.Location = new System.Drawing.Point(487, 88);
            this.autoLabel14.Name = "autoLabel14";
            this.autoLabel14.Size = new System.Drawing.Size(54, 21);
            this.autoLabel14.TabIndex = 36;
            this.autoLabel14.Text = "Tên SV";
            this.autoLabel14.ThemeName = "Managed";
            // 
            // autoLabel13
            // 
            this.autoLabel13.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel13.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel13.Location = new System.Drawing.Point(12, 84);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(53, 21);
            this.autoLabel13.TabIndex = 34;
            this.autoLabel13.Text = "Mã SV";
            this.autoLabel13.ThemeName = "Managed";
            // 
            // autoLabel12
            // 
            this.autoLabel12.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel12.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(483, 40);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(57, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Tên lớp";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // autoLabel11
            // 
            this.autoLabel11.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel11.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(12, 40);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(56, 21);
            this.autoLabel11.TabIndex = 30;
            this.autoLabel11.Text = "Mã lớp";
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
            this.autoLabel1.Size = new System.Drawing.Size(179, 37);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Quản lý vai trò";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = this;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // dtgvRole
            // 
            this.dtgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvRoleId,
            this.dtgvStudentId,
            this.dtgvStudentName,
            this.dtgvClassId,
            this.dtgvClassName,
            this.dtgvStudentRole});
            this.dtgvRole.Location = new System.Drawing.Point(35, 388);
            this.dtgvRole.Name = "dtgvRole";
            this.dtgvRole.RowHeadersWidth = 51;
            this.dtgvRole.Size = new System.Drawing.Size(1263, 195);
            this.dtgvRole.TabIndex = 15;
            this.dtgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRole_CellClick);
            // 
            // dtgvRoleId
            // 
            this.dtgvRoleId.HeaderText = "Role ID";
            this.dtgvRoleId.MinimumWidth = 6;
            this.dtgvRoleId.Name = "dtgvRoleId";
            // 
            // dtgvStudentId
            // 
            this.dtgvStudentId.HeaderText = "Mã SV";
            this.dtgvStudentId.MinimumWidth = 6;
            this.dtgvStudentId.Name = "dtgvStudentId";
            // 
            // dtgvStudentName
            // 
            this.dtgvStudentName.HeaderText = "Tên SV";
            this.dtgvStudentName.MinimumWidth = 6;
            this.dtgvStudentName.Name = "dtgvStudentName";
            // 
            // dtgvClassId
            // 
            this.dtgvClassId.HeaderText = "Mã lớp";
            this.dtgvClassId.MinimumWidth = 6;
            this.dtgvClassId.Name = "dtgvClassId";
            // 
            // dtgvClassName
            // 
            this.dtgvClassName.HeaderText = "Tên lớp";
            this.dtgvClassName.MinimumWidth = 6;
            this.dtgvClassName.Name = "dtgvClassName";
            // 
            // dtgvStudentRole
            // 
            this.dtgvStudentRole.HeaderText = "Vai trò";
            this.dtgvStudentRole.MinimumWidth = 6;
            this.dtgvStudentRole.Name = "dtgvStudentRole";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboRoleSearch);
            this.groupBox3.Controls.Add(this.autoLabel4);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtStudentIdSearch);
            this.groupBox3.Controls.Add(this.autoLabel2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox3.Location = new System.Drawing.Point(35, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 88);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cboRoleSearch
            // 
            this.cboRoleSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboRoleSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboRoleSearch.FormattingEnabled = true;
            this.cboRoleSearch.Items.AddRange(new object[] {
            "",
            "Bí thư",
            "Lớp trưởng",
            "Lớp phó"});
            this.cboRoleSearch.Location = new System.Drawing.Point(584, 40);
            this.cboRoleSearch.Name = "cboRoleSearch";
            this.cboRoleSearch.Size = new System.Drawing.Size(464, 29);
            this.cboRoleSearch.TabIndex = 34;
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(483, 40);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(52, 21);
            this.autoLabel4.TabIndex = 35;
            this.autoLabel4.Text = "Vai trò";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1102, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentIdSearch
            // 
            this.txtStudentIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtStudentIdSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtStudentIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtStudentIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentIdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtStudentIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStudentIdSearch.Location = new System.Drawing.Point(119, 40);
            this.txtStudentIdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtStudentIdSearch.Name = "txtStudentIdSearch";
            this.txtStudentIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStudentIdSearch.Size = new System.Drawing.Size(276, 29);
            this.txtStudentIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtStudentIdSearch.TabIndex = 33;
            this.txtStudentIdSearch.ThemeName = "Office2007";
            // 
            // autoLabel2
            // 
            this.autoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel2.Location = new System.Drawing.Point(12, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(53, 21);
            this.autoLabel2.TabIndex = 32;
            this.autoLabel2.Text = "Mã SV";
            this.autoLabel2.ThemeName = "Managed";
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(12, 128);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(52, 21);
            this.autoLabel3.TabIndex = 36;
            this.autoLabel3.Text = "Vai trò";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // UC_Role
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvRole);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.Name = "UC_Role";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClassId;
        private System.Windows.Forms.ComboBox cboStudentId;
        private System.Windows.Forms.ComboBox cboStudentRole;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtClassName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;

        private System.Windows.Forms.DataGridView dtgvRole;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private System.Windows.Forms.ComboBox cboRoleSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvStudentRole;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
    }
}