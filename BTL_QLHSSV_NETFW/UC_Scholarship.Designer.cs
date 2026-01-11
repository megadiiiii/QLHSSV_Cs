namespace BTL_QLHSSV_NETFW
{
    partial class UC_Scholarship
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvScholarship = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScoreLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDrlLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScholarshipLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboScholarshipLevel = new System.Windows.Forms.ComboBox();
            this.cboDrlLevel = new System.Windows.Forms.ComboBox();
            this.cboScoreLevel = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboStudentId = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudentId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtStudentIdSearch);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 79);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1024, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentIdSearch
            // 
            this.txtStudentIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStudentIdSearch.BeforeTouchSize = new System.Drawing.Size(300, 34);
            this.txtStudentIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtStudentIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentIdSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStudentIdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStudentIdSearch.Location = new System.Drawing.Point(169, 34);
            this.txtStudentIdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtStudentIdSearch.Name = "txtStudentIdSearch";
            this.txtStudentIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStudentIdSearch.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtStudentIdSearch.Size = new System.Drawing.Size(797, 34);
            this.txtStudentIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtStudentIdSearch.TabIndex = 39;
            this.txtStudentIdSearch.ThemeName = "Office2016Colorful";
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(12, 40);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(66, 28);
            this.autoLabel3.TabIndex = 38;
            this.autoLabel3.Text = "Mã SV";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1052, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 181);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(127, 81);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(8, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(113, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(127, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel1.Location = new System.Drawing.Point(36, 36);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(275, 46);
            this.autoLabel1.TabIndex = 44;
            this.autoLabel1.Text = "Quản lý học bổng";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(12, 34);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(66, 28);
            this.autoLabel4.TabIndex = 34;
            this.autoLabel4.Text = "Mã SV";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1052, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvScholarship
            // 
            this.dgvScholarship.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScholarship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScholarship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvStudentId,
            this.dgvStudentName,
            this.dgvScoreLevel,
            this.dgvDrlLevel,
            this.dgvScholarshipLevel,
            this.dgvSemester});
            this.dgvScholarship.Location = new System.Drawing.Point(36, 391);
            this.dgvScholarship.Name = "dgvScholarship";
            this.dgvScholarship.RowHeadersWidth = 72;
            this.dgvScholarship.Size = new System.Drawing.Size(1268, 195);
            this.dgvScholarship.TabIndex = 47;
            this.dgvScholarship.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScholarship_CellClick);
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.MinimumWidth = 6;
            this.dgvId.Name = "dgvId";
            this.dgvId.Visible = false;
            // 
            // dgvStudentId
            // 
            this.dgvStudentId.HeaderText = "Mã SV";
            this.dgvStudentId.MinimumWidth = 9;
            this.dgvStudentId.Name = "dgvStudentId";
            // 
            // dgvStudentName
            // 
            this.dgvStudentName.HeaderText = "Tên SV";
            this.dgvStudentName.MinimumWidth = 9;
            this.dgvStudentName.Name = "dgvStudentName";
            // 
            // dgvScoreLevel
            // 
            this.dgvScoreLevel.HeaderText = "Học lực";
            this.dgvScoreLevel.MinimumWidth = 9;
            this.dgvScoreLevel.Name = "dgvScoreLevel";
            // 
            // dgvDrlLevel
            // 
            this.dgvDrlLevel.HeaderText = "Rèn luyện";
            this.dgvDrlLevel.MinimumWidth = 9;
            this.dgvDrlLevel.Name = "dgvDrlLevel";
            // 
            // dgvScholarshipLevel
            // 
            this.dgvScholarshipLevel.HeaderText = "Mức học bổng";
            this.dgvScholarshipLevel.MinimumWidth = 6;
            this.dgvScholarshipLevel.Name = "dgvScholarshipLevel";
            // 
            // dgvSemester
            // 
            this.dgvSemester.HeaderText = "Học kì";
            this.dgvSemester.MinimumWidth = 6;
            this.dgvSemester.Name = "dgvSemester";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFullName.BeforeTouchSize = new System.Drawing.Size(300, 34);
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFullName.Location = new System.Drawing.Point(666, 28);
            this.txtFullName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFullName.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtFullName.Size = new System.Drawing.Size(300, 34);
            this.txtFullName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtFullName.TabIndex = 37;
            this.txtFullName.ThemeName = "Office2016Colorful";
            // 
            // autoLabel5
            // 
            this.autoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(509, 34);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(67, 28);
            this.autoLabel5.TabIndex = 36;
            this.autoLabel5.Text = "Tên SV";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboScholarshipLevel);
            this.groupBox1.Controls.Add(this.cboDrlLevel);
            this.groupBox1.Controls.Add(this.cboScoreLevel);
            this.groupBox1.Controls.Add(this.cboSemester);
            this.groupBox1.Controls.Add(this.autoLabel9);
            this.groupBox1.Controls.Add(this.autoLabel10);
            this.groupBox1.Controls.Add(this.autoLabel8);
            this.groupBox1.Controls.Add(this.autoLabel7);
            this.groupBox1.Controls.Add(this.cboStudentId);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 181);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyên ngành";
            // 
            // cboScholarshipLevel
            // 
            this.cboScholarshipLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScholarshipLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboScholarshipLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboScholarshipLevel.FormattingEnabled = true;
            this.cboScholarshipLevel.Items.AddRange(new object[] {
            "Khá",
            "Giỏi",
            "Xuất sắc"});
            this.cboScholarshipLevel.Location = new System.Drawing.Point(169, 135);
            this.cboScholarshipLevel.Name = "cboScholarshipLevel";
            this.cboScholarshipLevel.Size = new System.Drawing.Size(300, 36);
            this.cboScholarshipLevel.TabIndex = 51;
            // 
            // cboDrlLevel
            // 
            this.cboDrlLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrlLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDrlLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboDrlLevel.FormattingEnabled = true;
            this.cboDrlLevel.Items.AddRange(new object[] {
            "Khá",
            "Tốt",
            "Xuất sắc"});
            this.cboDrlLevel.Location = new System.Drawing.Point(666, 81);
            this.cboDrlLevel.Name = "cboDrlLevel";
            this.cboDrlLevel.Size = new System.Drawing.Size(300, 36);
            this.cboDrlLevel.TabIndex = 50;
            // 
            // cboScoreLevel
            // 
            this.cboScoreLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScoreLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboScoreLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboScoreLevel.FormattingEnabled = true;
            this.cboScoreLevel.Items.AddRange(new object[] {
            "Khá",
            "Giỏi",
            "Xuất sắc"});
            this.cboScoreLevel.Location = new System.Drawing.Point(169, 81);
            this.cboScoreLevel.Name = "cboScoreLevel";
            this.cboScoreLevel.Size = new System.Drawing.Size(300, 36);
            this.cboScoreLevel.TabIndex = 49;
            // 
            // cboSemester
            // 
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSemester.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "Kì 1",
            "Kì 2",
            "Kì 3",
            "Kì 4",
            "Kì 5",
            "Kì 6",
            "Kì 7",
            "Kì 8"});
            this.cboSemester.Location = new System.Drawing.Point(666, 129);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(300, 36);
            this.cboSemester.TabIndex = 47;
            // 
            // autoLabel9
            // 
            this.autoLabel9.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel9.Location = new System.Drawing.Point(509, 135);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(64, 28);
            this.autoLabel9.TabIndex = 45;
            this.autoLabel9.Text = "Học kì";
            this.autoLabel9.ThemeName = "Managed";
            // 
            // autoLabel10
            // 
            this.autoLabel10.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel10.Location = new System.Drawing.Point(12, 135);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(161, 28);
            this.autoLabel10.TabIndex = 43;
            this.autoLabel10.Text = "Kết quả học bổng";
            this.autoLabel10.ThemeName = "Managed";
            // 
            // autoLabel8
            // 
            this.autoLabel8.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel8.Location = new System.Drawing.Point(509, 85);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(159, 28);
            this.autoLabel8.TabIndex = 41;
            this.autoLabel8.Text = "Kết quả rèn luyện";
            this.autoLabel8.ThemeName = "Managed";
            // 
            // autoLabel7
            // 
            this.autoLabel7.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel7.Location = new System.Drawing.Point(12, 85);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(144, 28);
            this.autoLabel7.TabIndex = 39;
            this.autoLabel7.Text = "Kết quả học tập";
            this.autoLabel7.ThemeName = "Managed";
            // 
            // cboStudentId
            // 
            this.cboStudentId.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStudentId.Location = new System.Drawing.Point(169, 28);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(300, 29);
            this.cboStudentId.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStudentId.TabIndex = 38;
            this.cboStudentId.TabStop = false;
            this.cboStudentId.SelectedValueChanged += new System.EventHandler(this.cboStudentId_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(30, 857);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 857);
            this.panel1.TabIndex = 42;
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // UC_Scholarship
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.dgvScholarship);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Scholarship";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_Scholarship_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScholarship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudentId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvScholarship;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFullName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.WinForms.ListView.SfComboBox cboStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvScoreLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDrlLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvScholarshipLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSemester;
        private System.Windows.Forms.ComboBox cboScholarshipLevel;
        private System.Windows.Forms.ComboBox cboDrlLevel;
        private System.Windows.Forms.ComboBox cboScoreLevel;
        private System.Windows.Forms.ComboBox cboSemester;
    }
}
