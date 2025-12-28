namespace BTL_QLHSSV_NETFW
{
    partial class UC_Class
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassID = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboFacu = new System.Windows.Forms.ComboBox();
            this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel19 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.txtClassName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCohort = new System.Windows.Forms.NumericUpDown();
            this.dgvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCohort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCohortSearch = new System.Windows.Forms.NumericUpDown();
            this.txtClassNameSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtClassIDSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCohort)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCohortSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassNameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassIDSearch)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(252, 132);
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
            this.btnExport.Size = new System.Drawing.Size(118, 29);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(8, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(127, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 29);
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
            this.autoLabel1.Size = new System.Drawing.Size(146, 37);
            this.autoLabel1.TabIndex = 44;
            this.autoLabel1.Text = "Quản lý lớp";
            this.autoLabel1.ThemeName = "Managed";
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
            // dgvClass
            // 
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClassID,
            this.dgvClassName,
            this.dgvCohort,
            this.dgvMajor,
            this.dgvFacu});
            this.dgvClass.Location = new System.Drawing.Point(36, 344);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 72;
            this.dgvClass.Size = new System.Drawing.Size(1268, 232);
            this.dgvClass.TabIndex = 47;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCohort);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.autoLabel5);
            this.groupBox1.Controls.Add(this.autoLabel4);
            this.groupBox1.Controls.Add(this.txtClassID);
            this.groupBox1.Controls.Add(this.cboMajor);
            this.groupBox1.Controls.Add(this.autoLabel10);
            this.groupBox1.Controls.Add(this.cboFacu);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.autoLabel14);
            this.groupBox1.Controls.Add(this.autoLabel19);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 132);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // txtClassID
            // 
            this.txtClassID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtClassID.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtClassID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtClassID.Location = new System.Drawing.Point(119, 81);
            this.txtClassID.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtClassID.Size = new System.Drawing.Size(175, 29);
            this.txtClassID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtClassID.TabIndex = 49;
            this.txtClassID.ThemeName = "Office2007";
            // 
            // cboMajor
            // 
            this.cboMajor.BackColor = System.Drawing.SystemColors.Control;
            this.cboMajor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMajor.FormattingEnabled = true;
            this.cboMajor.Items.AddRange(new object[] {
            "Logistics và quản lý chuỗi cung ứng (tăng cường tiếng Nhật, định hướng làm việc t" +
                "ại Nhật Bản)"});
            this.cboMajor.Location = new System.Drawing.Point(440, 35);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(492, 29);
            this.cboMajor.TabIndex = 49;
            this.cboMajor.Text = "Ngành";
            // 
            // autoLabel10
            // 
            this.autoLabel10.Location = new System.Drawing.Point(12, 85);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(56, 21);
            this.autoLabel10.TabIndex = 50;
            this.autoLabel10.Text = "Mã lớp";
            this.autoLabel10.ThemeName = "Managed";
            // 
            // cboFacu
            // 
            this.cboFacu.BackColor = System.Drawing.SystemColors.Control;
            this.cboFacu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboFacu.FormattingEnabled = true;
            this.cboFacu.Location = new System.Drawing.Point(119, 35);
            this.cboFacu.Name = "cboFacu";
            this.cboFacu.Size = new System.Drawing.Size(175, 29);
            this.cboFacu.TabIndex = 50;
            this.cboFacu.Text = "Khoa/Viện";
            this.cboFacu.SelectedIndexChanged += new System.EventHandler(this.cboFacu_SelectedIndexChanged);
            // 
            // autoLabel14
            // 
            this.autoLabel14.Location = new System.Drawing.Point(12, 39);
            this.autoLabel14.Name = "autoLabel14";
            this.autoLabel14.Size = new System.Drawing.Size(80, 21);
            this.autoLabel14.TabIndex = 52;
            this.autoLabel14.Text = "Khoa/Viện";
            this.autoLabel14.ThemeName = "Managed";
            // 
            // autoLabel19
            // 
            this.autoLabel19.Location = new System.Drawing.Point(331, 39);
            this.autoLabel19.Name = "autoLabel19";
            this.autoLabel19.Size = new System.Drawing.Size(56, 21);
            this.autoLabel19.TabIndex = 51;
            this.autoLabel19.Text = "Ngành";
            this.autoLabel19.ThemeName = "Managed";
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
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtClassName.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtClassName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtClassName.Location = new System.Drawing.Point(440, 81);
            this.txtClassName.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtClassName.Size = new System.Drawing.Size(371, 29);
            this.txtClassName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtClassName.TabIndex = 53;
            this.txtClassName.ThemeName = "Office2007";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Location = new System.Drawing.Point(331, 85);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(57, 21);
            this.autoLabel4.TabIndex = 54;
            this.autoLabel4.Text = "Tên lớp";
            this.autoLabel4.ThemeName = "Managed";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Location = new System.Drawing.Point(826, 85);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(44, 21);
            this.autoLabel5.TabIndex = 54;
            this.autoLabel5.Text = "Khóa";
            this.autoLabel5.ThemeName = "Managed";
            // 
            // txtCohort
            // 
            this.txtCohort.Location = new System.Drawing.Point(876, 81);
            this.txtCohort.Name = "txtCohort";
            this.txtCohort.Size = new System.Drawing.Size(56, 29);
            this.txtCohort.TabIndex = 55;
            this.txtCohort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCohort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvClassID
            // 
            this.dgvClassID.HeaderText = "Mã lớp";
            this.dgvClassID.Name = "dgvClassID";
            // 
            // dgvClassName
            // 
            this.dgvClassName.HeaderText = "Tên lớp";
            this.dgvClassName.Name = "dgvClassName";
            // 
            // dgvCohort
            // 
            this.dgvCohort.HeaderText = "Khóa";
            this.dgvCohort.Name = "dgvCohort";
            // 
            // dgvMajor
            // 
            this.dgvMajor.HeaderText = "Chuyên ngành";
            this.dgvMajor.Name = "dgvMajor";
            // 
            // dgvFacu
            // 
            this.dgvFacu.HeaderText = "Khoa";
            this.dgvFacu.Name = "dgvFacu";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCohortSearch);
            this.groupBox3.Controls.Add(this.txtClassNameSearch);
            this.groupBox3.Controls.Add(this.autoLabel2);
            this.groupBox3.Controls.Add(this.autoLabel3);
            this.groupBox3.Controls.Add(this.txtClassIDSearch);
            this.groupBox3.Controls.Add(this.autoLabel6);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 91);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtCohortSearch
            // 
            this.txtCohortSearch.Location = new System.Drawing.Point(876, 36);
            this.txtCohortSearch.Name = "txtCohortSearch";
            this.txtCohortSearch.Size = new System.Drawing.Size(56, 29);
            this.txtCohortSearch.TabIndex = 66;
            this.txtCohortSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCohortSearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtClassNameSearch
            // 
            this.txtClassNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtClassNameSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtClassNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtClassNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtClassNameSearch.Location = new System.Drawing.Point(440, 36);
            this.txtClassNameSearch.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtClassNameSearch.Name = "txtClassNameSearch";
            this.txtClassNameSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtClassNameSearch.Size = new System.Drawing.Size(371, 29);
            this.txtClassNameSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtClassNameSearch.TabIndex = 63;
            this.txtClassNameSearch.ThemeName = "Office2007";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(826, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(44, 21);
            this.autoLabel2.TabIndex = 64;
            this.autoLabel2.Text = "Khóa";
            this.autoLabel2.ThemeName = "Managed";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(331, 40);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(57, 21);
            this.autoLabel3.TabIndex = 65;
            this.autoLabel3.Text = "Tên lớp";
            this.autoLabel3.ThemeName = "Managed";
            // 
            // txtClassIDSearch
            // 
            this.txtClassIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.txtClassIDSearch.BeforeTouchSize = new System.Drawing.Size(175, 29);
            this.txtClassIDSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(229)))));
            this.txtClassIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassIDSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtClassIDSearch.Location = new System.Drawing.Point(119, 36);
            this.txtClassIDSearch.MinimumSize = new System.Drawing.Size(14, 10);
            this.txtClassIDSearch.Name = "txtClassIDSearch";
            this.txtClassIDSearch.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.txtClassIDSearch.Size = new System.Drawing.Size(175, 29);
            this.txtClassIDSearch.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2007;
            this.txtClassIDSearch.TabIndex = 57;
            this.txtClassIDSearch.ThemeName = "Office2007";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Location = new System.Drawing.Point(12, 40);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(56, 21);
            this.autoLabel6.TabIndex = 59;
            this.autoLabel6.Text = "Mã lớp";
            this.autoLabel6.ThemeName = "Managed";
            // 
            // UC_Class
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Class";
            this.Size = new System.Drawing.Size(1340, 857);
            this.Load += new System.EventHandler(this.UC_Class_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCohort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCohortSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassNameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassIDSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private System.Windows.Forms.ComboBox cboMajor;
        private System.Windows.Forms.ComboBox cboFacu;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel19;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtClassID;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private System.Windows.Forms.NumericUpDown txtCohort;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtClassName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCohort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFacu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtCohortSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtClassNameSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtClassIDSearch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
    }
}
