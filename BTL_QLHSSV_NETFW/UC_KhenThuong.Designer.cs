namespace BTL_QLHSSV_NETFW
{
    partial class UC_KhenThuong
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
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.dgvMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuyetDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRewardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMaSV = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtQuyetDinh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtLyDo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtMasvSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtMaqdSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyetDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaqdSearch)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSV,
            this.dgvHoDem,
            this.dgvTen,
            this.dgvLop,
            this.dgvDate,
            this.dgvQuyetDinh,
            this.dgvLyDo,
            this.dgvRewardId});
            this.dgvThongTin.Location = new System.Drawing.Point(36, 351);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.Size = new System.Drawing.Size(1261, 195);
            this.dgvThongTin.TabIndex = 40;
            this.dgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellClick);
            // 
            // dgvMaSV
            // 
            this.dgvMaSV.HeaderText = "Mã sinh viên";
            this.dgvMaSV.MinimumWidth = 6;
            this.dgvMaSV.Name = "dgvMaSV";
            // 
            // dgvHoDem
            // 
            this.dgvHoDem.HeaderText = "Họ đệm";
            this.dgvHoDem.MinimumWidth = 6;
            this.dgvHoDem.Name = "dgvHoDem";
            // 
            // dgvTen
            // 
            this.dgvTen.HeaderText = "Tên";
            this.dgvTen.MinimumWidth = 6;
            this.dgvTen.Name = "dgvTen";
            // 
            // dgvLop
            // 
            this.dgvLop.HeaderText = "Lớp";
            this.dgvLop.MinimumWidth = 6;
            this.dgvLop.Name = "dgvLop";
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Ngày khen thưởng";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            // 
            // dgvQuyetDinh
            // 
            this.dgvQuyetDinh.HeaderText = "Quyết định số";
            this.dgvQuyetDinh.MinimumWidth = 6;
            this.dgvQuyetDinh.Name = "dgvQuyetDinh";
            // 
            // dgvLyDo
            // 
            this.dgvLyDo.HeaderText = "Lý do";
            this.dgvLyDo.MinimumWidth = 6;
            this.dgvLyDo.Name = "dgvLyDo";
            // 
            // dgvRewardId
            // 
            this.dgvRewardId.HeaderText = "RewardId";
            this.dgvRewardId.MinimumWidth = 6;
            this.dgvRewardId.Name = "dgvRewardId";
            this.dgvRewardId.Visible = false;
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = null;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = "Office2019Theme";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1129, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 140);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(6, 87);
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
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(87, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtMaSV.BeforeTouchSize = new System.Drawing.Size(200, 29);
            this.txtMaSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMaSV.Location = new System.Drawing.Point(179, 42);
            this.txtMaSV.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtMaSV.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtMaSV.Size = new System.Drawing.Size(175, 29);
            this.txtMaSV.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtMaSV.TabIndex = 31;
            this.txtMaSV.ThemeName = "Office2007";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtQuyetDinh);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.autoLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 140);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // txtDate
            // 
            this.txtDate.AllowValueChangeOnMouseWheel = true;
            this.txtDate.DateTimeIcon = null;
            this.txtDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.txtDate.Format = "dd/MM/yyyy";
            this.txtDate.Location = new System.Drawing.Point(179, 88);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(175, 29);
            this.txtDate.TabIndex = 38;
            this.txtDate.ThemeName = "Managed";
            this.txtDate.ToolTipText = "";
            this.txtDate.Value = new System.DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // txtQuyetDinh
            // 
            this.txtQuyetDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtQuyetDinh.BeforeTouchSize = new System.Drawing.Size(200, 29);
            this.txtQuyetDinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtQuyetDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuyetDinh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtQuyetDinh.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyetDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtQuyetDinh.Location = new System.Drawing.Point(553, 42);
            this.txtQuyetDinh.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtQuyetDinh.Name = "txtQuyetDinh";
            this.txtQuyetDinh.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtQuyetDinh.Size = new System.Drawing.Size(200, 29);
            this.txtQuyetDinh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtQuyetDinh.TabIndex = 37;
            this.txtQuyetDinh.ThemeName = "Office2007";
            // 
            // autoLabel5
            // 
            this.autoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(440, 46);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(85, 21);
            this.autoLabel5.TabIndex = 36;
            this.autoLabel5.Text = "Quyết định";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(12, 92);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(136, 21);
            this.autoLabel4.TabIndex = 34;
            this.autoLabel4.Text = "Ngày khen thưởng";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // txtLyDo
            // 
            this.txtLyDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtLyDo.BeforeTouchSize = new System.Drawing.Size(200, 29);
            this.txtLyDo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyDo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLyDo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtLyDo.Location = new System.Drawing.Point(553, 88);
            this.txtLyDo.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtLyDo.Size = new System.Drawing.Size(200, 29);
            this.txtLyDo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtLyDo.TabIndex = 33;
            this.txtLyDo.ThemeName = "Office2007";
            // 
            // autoLabel12
            // 
            this.autoLabel12.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(440, 92);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(45, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Lý do";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // autoLabel11
            // 
            this.autoLabel11.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel11.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(12, 46);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(93, 21);
            this.autoLabel11.TabIndex = 30;
            this.autoLabel11.Text = "Mã sinh viên";
            this.autoLabel11.ThemeName = "Managed";
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
            this.autoLabel1.Size = new System.Drawing.Size(161, 37);
            this.autoLabel1.TabIndex = 37;
            this.autoLabel1.Text = "Khen thưởng";
            this.autoLabel1.ThemeName = "Managed";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(30, 857);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 857);
            this.panel1.TabIndex = 35;
            // 
            // autoLabel7
            // 
            this.autoLabel7.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel7.Location = new System.Drawing.Point(12, 40);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(93, 21);
            this.autoLabel7.TabIndex = 30;
            this.autoLabel7.Text = "Mã sinh viên";
            this.autoLabel7.ThemeName = "Managed";
            // 
            // txtMasvSearch
            // 
            this.txtMasvSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtMasvSearch.BeforeTouchSize = new System.Drawing.Size(200, 29);
            this.txtMasvSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtMasvSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasvSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMasvSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasvSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMasvSearch.Location = new System.Drawing.Point(179, 38);
            this.txtMasvSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtMasvSearch.Name = "txtMasvSearch";
            this.txtMasvSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtMasvSearch.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtMasvSearch.Size = new System.Drawing.Size(175, 29);
            this.txtMasvSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtMasvSearch.TabIndex = 31;
            this.txtMasvSearch.ThemeName = "Office2007";
            // 
            // autoLabel6
            // 
            this.autoLabel6.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel6.Location = new System.Drawing.Point(440, 40);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(107, 21);
            this.autoLabel6.TabIndex = 32;
            this.autoLabel6.Text = "Mã quyết định";
            this.autoLabel6.ThemeName = "Managed";
            // 
            // txtMaqdSearch
            // 
            this.txtMaqdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtMaqdSearch.BeforeTouchSize = new System.Drawing.Size(200, 29);
            this.txtMaqdSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtMaqdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaqdSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaqdSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaqdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtMaqdSearch.Location = new System.Drawing.Point(553, 38);
            this.txtMaqdSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtMaqdSearch.Name = "txtMaqdSearch";
            this.txtMaqdSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtMaqdSearch.Size = new System.Drawing.Size(200, 29);
            this.txtMaqdSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtMaqdSearch.TabIndex = 33;
            this.txtMaqdSearch.ThemeName = "Office2007";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Location = new System.Drawing.Point(1093, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(73, 31);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Controls.Add(this.txtMaqdSearch);
            this.groupBox4.Controls.Add(this.autoLabel6);
            this.groupBox4.Controls.Add(this.txtMasvSearch);
            this.groupBox4.Controls.Add(this.autoLabel7);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(36, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1261, 88);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Location = new System.Drawing.Point(87, 86);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // UC_KhenThuong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_KhenThuong";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_KhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyetDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaqdSearch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThongTin;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLyDo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQuyetDinh;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuyetDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRewardId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMasvSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMaqdSearch;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExport;
    }
}
