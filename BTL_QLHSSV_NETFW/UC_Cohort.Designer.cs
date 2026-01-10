namespace BTL_QLHSSV_NETFW
{
    partial class UC_Cohort
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFacuIDSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dgvCohort = new System.Windows.Forms.DataGridView();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFacuName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFacuId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEndDate = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtEndDateSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtStartDateSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dgvCohortId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCohortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuIDSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCohort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDateSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDateSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(936, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(12, 40);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(100, 21);
            this.autoLabel3.TabIndex = 30;
            this.autoLabel3.Text = "Khóa đào tạo";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEndDateSearch);
            this.groupBox3.Controls.Add(this.autoLabel2);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtStartDateSearch);
            this.groupBox3.Controls.Add(this.txtFacuIDSearch);
            this.groupBox3.Controls.Add(this.autoLabel5);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1263, 88);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtFacuIDSearch
            // 
            this.txtFacuIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFacuIDSearch.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtFacuIDSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtFacuIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacuIDSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFacuIDSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacuIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFacuIDSearch.Location = new System.Drawing.Point(119, 40);
            this.txtFacuIDSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtFacuIDSearch.Name = "txtFacuIDSearch";
            this.txtFacuIDSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFacuIDSearch.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtFacuIDSearch.Size = new System.Drawing.Size(305, 29);
            this.txtFacuIDSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtFacuIDSearch.TabIndex = 31;
            this.txtFacuIDSearch.ThemeName = "Office2007";
            // 
            // dgvCohort
            // 
            this.dgvCohort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCohort.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCohort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCohort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCohortId,
            this.dgvCohortName,
            this.dgvStartDate,
            this.dgvEndDate});
            this.dgvCohort.Location = new System.Drawing.Point(36, 298);
            this.dgvCohort.Name = "dgvCohort";
            this.dgvCohort.RowHeadersWidth = 51;
            this.dgvCohort.Size = new System.Drawing.Size(1263, 195);
            this.dgvCohort.TabIndex = 40;
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
            this.groupBox2.Location = new System.Drawing.Point(964, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 88);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Location = new System.Drawing.Point(251, 38);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(170, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(89, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtFacuName);
            this.groupBox1.Controls.Add(this.autoLabel12);
            this.groupBox1.Controls.Add(this.txtFacuId);
            this.groupBox1.Controls.Add(this.autoLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 88);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1052, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFacuName
            // 
            this.txtFacuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFacuName.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtFacuName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtFacuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacuName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFacuName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFacuName.Location = new System.Drawing.Point(543, 38);
            this.txtFacuName.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtFacuName.Name = "txtFacuName";
            this.txtFacuName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFacuName.Size = new System.Drawing.Size(102, 29);
            this.txtFacuName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtFacuName.TabIndex = 33;
            this.txtFacuName.ThemeName = "Office2007";
            // 
            // autoLabel12
            // 
            this.autoLabel12.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(455, 38);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(61, 21);
            this.autoLabel12.TabIndex = 32;
            this.autoLabel12.Text = "Từ năm";
            this.autoLabel12.ThemeName = "Managed";
            // 
            // txtFacuId
            // 
            this.txtFacuId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtFacuId.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtFacuId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtFacuId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacuId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFacuId.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacuId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFacuId.Location = new System.Drawing.Point(119, 38);
            this.txtFacuId.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtFacuId.Name = "txtFacuId";
            this.txtFacuId.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtFacuId.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.txtFacuId.Size = new System.Drawing.Size(305, 29);
            this.txtFacuId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtFacuId.TabIndex = 31;
            this.txtFacuId.ThemeName = "Office2007";
            // 
            // autoLabel11
            // 
            this.autoLabel11.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel11.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(12, 40);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(100, 21);
            this.autoLabel11.TabIndex = 30;
            this.autoLabel11.Text = "Khóa đào tạo";
            this.autoLabel11.ThemeName = "Managed";
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
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel1.Location = new System.Drawing.Point(36, 36);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(257, 37);
            this.autoLabel1.TabIndex = 37;
            this.autoLabel1.Text = "Quản lý khóa đào tạo";
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
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtEndDate.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEndDate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtEndDate.Location = new System.Drawing.Point(810, 38);
            this.txtEndDate.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtEndDate.Size = new System.Drawing.Size(102, 29);
            this.txtEndDate.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtEndDate.TabIndex = 35;
            this.txtEndDate.ThemeName = "Office2007";
            // 
            // autoLabel4
            // 
            this.autoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(703, 40);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(72, 21);
            this.autoLabel4.TabIndex = 34;
            this.autoLabel4.Text = "Đến năm";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // txtEndDateSearch
            // 
            this.txtEndDateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtEndDateSearch.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtEndDateSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtEndDateSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDateSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEndDateSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDateSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtEndDateSearch.Location = new System.Drawing.Point(810, 40);
            this.txtEndDateSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtEndDateSearch.Name = "txtEndDateSearch";
            this.txtEndDateSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtEndDateSearch.Size = new System.Drawing.Size(102, 29);
            this.txtEndDateSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtEndDateSearch.TabIndex = 39;
            this.txtEndDateSearch.ThemeName = "Office2007";
            // 
            // autoLabel2
            // 
            this.autoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel2.Location = new System.Drawing.Point(703, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(72, 21);
            this.autoLabel2.TabIndex = 38;
            this.autoLabel2.Text = "Đến năm";
            this.autoLabel2.ThemeName = "Managed";
            // 
            // txtStartDateSearch
            // 
            this.txtStartDateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtStartDateSearch.BeforeTouchSize = new System.Drawing.Size(102, 29);
            this.txtStartDateSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtStartDateSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDateSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStartDateSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDateSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtStartDateSearch.Location = new System.Drawing.Point(543, 40);
            this.txtStartDateSearch.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtStartDateSearch.Name = "txtStartDateSearch";
            this.txtStartDateSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtStartDateSearch.Size = new System.Drawing.Size(102, 29);
            this.txtStartDateSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtStartDateSearch.TabIndex = 37;
            this.txtStartDateSearch.ThemeName = "Office2007";
            // 
            // autoLabel5
            // 
            this.autoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(455, 40);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(61, 21);
            this.autoLabel5.TabIndex = 36;
            this.autoLabel5.Text = "Từ năm";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // dgvCohortId
            // 
            this.dgvCohortId.HeaderText = "Mã khóa đào tạo";
            this.dgvCohortId.MinimumWidth = 6;
            this.dgvCohortId.Name = "dgvCohortId";
            // 
            // dgvCohortName
            // 
            this.dgvCohortName.HeaderText = "Khóa đào tạo";
            this.dgvCohortName.MinimumWidth = 6;
            this.dgvCohortName.Name = "dgvCohortName";
            // 
            // dgvStartDate
            // 
            this.dgvStartDate.HeaderText = "Từ năm";
            this.dgvStartDate.Name = "dgvStartDate";
            // 
            // dgvEndDate
            // 
            this.dgvEndDate.HeaderText = "Đến năm";
            this.dgvEndDate.Name = "dgvEndDate";
            // 
            // UC_Cohort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvCohort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Cohort";
            this.Size = new System.Drawing.Size(1340, 857);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuIDSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCohort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacuId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDateSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDateSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFacuIDSearch;
        private System.Windows.Forms.DataGridView dgvCohort;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFacuName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFacuId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEndDateSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtStartDateSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEndDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCohortId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCohortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEndDate;
    }
}
