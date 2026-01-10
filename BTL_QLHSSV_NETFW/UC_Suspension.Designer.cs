namespace BTL_QLHSSV_NETFW
{
    partial class UC_Suspension
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
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStudentId = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtEndYear = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtReason = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboSusStatus = new System.Windows.Forms.ComboBox();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dgvSus = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSusStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboSusStatusSearch = new System.Windows.Forms.ComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtStudentIdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSus)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStudentId);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.txtEndYear);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.cboSusStatus);
            this.groupBox1.Controls.Add(this.autoLabel7);
            this.groupBox1.Controls.Add(this.autoLabel9);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.autoLabel13);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 173);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cboStudentId
            // 
            this.cboStudentId.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStudentId.Location = new System.Drawing.Point(119, 36);
            this.cboStudentId.Name = "cboStudentId";
            this.cboStudentId.Size = new System.Drawing.Size(298, 29);
            this.cboStudentId.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStudentId.TabIndex = 45;
            this.cboStudentId.TabStop = false;
            this.cboStudentId.SelectedValueChanged += new System.EventHandler(this.cboStudentId_SelectedValueChanged);
            // 
            // autoLabel5
            // 
            this.autoLabel5.Location = new System.Drawing.Point(535, 81);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(76, 21);
            this.autoLabel5.TabIndex = 44;
            this.autoLabel5.Text = "Ngày sinh";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // txtEndYear
            // 
            this.txtEndYear.AllowValueChangeOnMouseWheel = true;
            this.txtEndYear.DateTimeIcon = null;
            this.txtEndYear.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.txtEndYear.Format = "dd/MM/yyyy";
            this.txtEndYear.Location = new System.Drawing.Point(643, 77);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(298, 29);
            this.txtEndYear.TabIndex = 43;
            this.txtEndYear.ThemeName = "Managed";
            this.txtEndYear.ToolTipText = "";
            this.txtEndYear.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtReason.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtReason.Location = new System.Drawing.Point(643, 120);
            this.txtReason.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtReason.Name = "txtReason";
            this.txtReason.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtReason.Size = new System.Drawing.Size(298, 29);
            this.txtReason.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtReason.TabIndex = 38;
            this.txtReason.ThemeName = "Office2007";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFullName.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFullName.Location = new System.Drawing.Point(643, 36);
            this.txtFullName.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(298, 29);
            this.txtFullName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtFullName.TabIndex = 29;
            this.txtFullName.ThemeName = "Office2007";
            // 
            // cboSusStatus
            // 
            this.cboSusStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cboSusStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSusStatus.FormattingEnabled = true;
            this.cboSusStatus.Items.AddRange(new object[] {
            "Chờ duyệt",
            "Đã duyệt",
            "Từ chối"});
            this.cboSusStatus.Location = new System.Drawing.Point(119, 120);
            this.cboSusStatus.Name = "cboSusStatus";
            this.cboSusStatus.Size = new System.Drawing.Size(298, 29);
            this.cboSusStatus.TabIndex = 33;
            this.cboSusStatus.Text = "Trạng thái";
            // 
            // autoLabel7
            // 
            this.autoLabel7.Location = new System.Drawing.Point(12, 81);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(76, 21);
            this.autoLabel7.TabIndex = 37;
            this.autoLabel7.Text = "Ngày sinh";
            this.autoLabel7.ThemeName = "Managed";
            // 
            // autoLabel9
            // 
            this.autoLabel9.Location = new System.Drawing.Point(535, 124);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(45, 21);
            this.autoLabel9.TabIndex = 42;
            this.autoLabel9.Text = "Lý do";
            this.autoLabel9.ThemeName = "Managed";
            // 
            // txtStartDate
            // 
            this.txtStartDate.AllowValueChangeOnMouseWheel = true;
            this.txtStartDate.DateTimeIcon = null;
            this.txtStartDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.txtStartDate.Format = "dd/MM/yyyy";
            this.txtStartDate.Location = new System.Drawing.Point(119, 77);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(298, 29);
            this.txtStartDate.TabIndex = 31;
            this.txtStartDate.ThemeName = "Managed";
            this.txtStartDate.ToolTipText = "";
            this.txtStartDate.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // autoLabel4
            // 
            this.autoLabel4.Location = new System.Drawing.Point(12, 124);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(76, 21);
            this.autoLabel4.TabIndex = 40;
            this.autoLabel4.Text = "Trạng thái";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // autoLabel12
            // 
            this.autoLabel12.Location = new System.Drawing.Point(535, 38);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(54, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Tên SV";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // autoLabel13
            // 
            this.autoLabel13.Location = new System.Drawing.Point(12, 38);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(93, 21);
            this.autoLabel13.TabIndex = 27;
            this.autoLabel13.Text = "Mã sinh viên";
            this.autoLabel13.ThemeName = "Managed";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(30, 857);
            this.panel2.TabIndex = 50;
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
            this.autoLabel1.Size = new System.Drawing.Size(195, 37);
            this.autoLabel1.TabIndex = 51;
            this.autoLabel1.Text = "Quản lý bảo lưu";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // dgvSus
            // 
            this.dgvSus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvStudentID,
            this.dgvStudentName,
            this.dgvStartDate,
            this.dgvEndDate,
            this.dgvReason,
            this.dgvSusStatus});
            this.dgvSus.Location = new System.Drawing.Point(36, 375);
            this.dgvSus.Name = "dgvSus";
            this.dgvSus.RowHeadersWidth = 72;
            this.dgvSus.Size = new System.Drawing.Size(1268, 244);
            this.dgvSus.TabIndex = 54;
            this.dgvSus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSus_CellClick);
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            // 
            // dgvStudentID
            // 
            this.dgvStudentID.HeaderText = "Mã SV";
            this.dgvStudentID.MinimumWidth = 9;
            this.dgvStudentID.Name = "dgvStudentID";
            // 
            // dgvStudentName
            // 
            this.dgvStudentName.HeaderText = "Tên SV";
            this.dgvStudentName.MinimumWidth = 9;
            this.dgvStudentName.Name = "dgvStudentName";
            // 
            // dgvStartDate
            // 
            this.dgvStartDate.HeaderText = "Ngày bắt đầu";
            this.dgvStartDate.MinimumWidth = 9;
            this.dgvStartDate.Name = "dgvStartDate";
            // 
            // dgvEndDate
            // 
            this.dgvEndDate.HeaderText = "Ngày kết thúc";
            this.dgvEndDate.MinimumWidth = 9;
            this.dgvEndDate.Name = "dgvEndDate";
            // 
            // dgvReason
            // 
            this.dgvReason.HeaderText = "Lý do";
            this.dgvReason.Name = "dgvReason";
            // 
            // dgvSusStatus
            // 
            this.dgvSusStatus.HeaderText = "Trạng thái";
            this.dgvSusStatus.Name = "dgvSusStatus";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 857);
            this.panel1.TabIndex = 49;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSusStatusSearch);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Controls.Add(this.txtStudentIdSearch);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 77);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cboSusStatusSearch
            // 
            this.cboSusStatusSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cboSusStatusSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSusStatusSearch.FormattingEnabled = true;
            this.cboSusStatusSearch.Items.AddRange(new object[] {
            "Chờ duyệt",
            "Đã duyệt",
            "Từ chối"});
            this.cboSusStatusSearch.Location = new System.Drawing.Point(643, 28);
            this.cboSusStatusSearch.Name = "cboSusStatusSearch";
            this.cboSusStatusSearch.Size = new System.Drawing.Size(298, 29);
            this.cboSusStatusSearch.TabIndex = 46;
            this.cboSusStatusSearch.Text = "Trạng thái";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(535, 32);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(76, 21);
            this.autoLabel3.TabIndex = 47;
            this.autoLabel3.Text = "Trạng thái";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // txtStudentIdSearch
            // 
            this.txtStudentIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtStudentIdSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtStudentIdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtStudentIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentIdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStudentIdSearch.Location = new System.Drawing.Point(119, 28);
            this.txtStudentIdSearch.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtStudentIdSearch.Name = "txtStudentIdSearch";
            this.txtStudentIdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStudentIdSearch.Size = new System.Drawing.Size(298, 29);
            this.txtStudentIdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtStudentIdSearch.TabIndex = 46;
            this.txtStudentIdSearch.ThemeName = "Office2007";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(12, 32);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 21);
            this.lbl.TabIndex = 47;
            this.lbl.Text = "Mã SV";
            this.lbl.ThemeName = "Managed";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1024, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(8, 120);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 29);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(127, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(113, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReject);
            this.groupBox2.Controls.Add(this.btnApprove);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1052, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 173);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReject.Location = new System.Drawing.Point(127, 77);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(113, 29);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Từ chối";
            this.btnReject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApprove.Location = new System.Drawing.Point(8, 77);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnApprove.Size = new System.Drawing.Size(113, 29);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Duyệt";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UC_Suspension
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.dgvSus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_Suspension";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_Suspension_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentIdSearch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.DataGridView dgvSus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtReason;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFullName;
        private System.Windows.Forms.ComboBox cboSusStatus;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txtStartDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txtEndYear;
        private System.Windows.Forms.ComboBox cboSusStatusSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentIdSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lbl;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private Syncfusion.WinForms.ListView.SfComboBox cboStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSusStatus;
    }
}
