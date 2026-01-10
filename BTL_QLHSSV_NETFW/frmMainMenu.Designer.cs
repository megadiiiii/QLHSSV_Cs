using System.Drawing;

namespace BTL_QLHSSV_NETFW
{
    partial class QLHSSV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.navMajor = new Syncfusion.WinForms.Controls.SfButton();
            this.navFaculties = new Syncfusion.WinForms.Controls.SfButton();
            this.navClass = new Syncfusion.WinForms.Controls.SfButton();
            this.navStudent = new Syncfusion.WinForms.Controls.SfButton();
            this.navDashboard = new Syncfusion.WinForms.Controls.SfButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navKhenThuong = new Syncfusion.WinForms.Controls.SfButton();
            this.navKyLuat = new Syncfusion.WinForms.Controls.SfButton();
            this.navScholarship = new Syncfusion.WinForms.Controls.SfButton();
            this.navTeacher = new Syncfusion.WinForms.Controls.SfButton();
            this.navSuspension = new Syncfusion.WinForms.Controls.SfButton();
            this.navRole = new Syncfusion.WinForms.Controls.SfButton();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navCohort = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExit = new Syncfusion.WinForms.Controls.SfButton();
            this.uC_Dashboard1 = new BTL_QLHSSV_NETFW.UC_Dashboard();
            this.uC_Student1 = new BTL_QLHSSV_NETFW.UC_Student();
            this.uC_Class1 = new BTL_QLHSSV_NETFW.UC_Class();
            this.uC_Faculties1 = new BTL_QLHSSV_NETFW.UC_Faculties();
            this.uC_Major1 = new BTL_QLHSSV_NETFW.UC_Major();
            this.uC_KhenThuong1 = new BTL_QLHSSV_NETFW.UC_KhenThuong();
            this.uC_KyLuat1 = new BTL_QLHSSV_NETFW.UC_KyLuat();
            this.uC_Scholarship1 = new BTL_QLHSSV_NETFW.UC_Scholarship();
            this.uC_Teacher1 = new BTL_QLHSSV_NETFW.UC_Teacher();
            this.uC_Suspension1 = new BTL_QLHSSV_NETFW.UC_Suspension();
            this.uC_Role1 = new BTL_QLHSSV_NETFW.UC_Role();
            this.uC_Cohort1 = new BTL_QLHSSV_NETFW.UC_Cohort();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoScroll = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.gradientPanel1.Controls.Add(this.uC_Dashboard1);
            this.gradientPanel1.Controls.Add(this.uC_Student1);
            this.gradientPanel1.Controls.Add(this.uC_Class1);
            this.gradientPanel1.Controls.Add(this.uC_Faculties1);
            this.gradientPanel1.Controls.Add(this.uC_Major1);
            this.gradientPanel1.Controls.Add(this.uC_KhenThuong1);
            this.gradientPanel1.Controls.Add(this.uC_KyLuat1);
            this.gradientPanel1.Controls.Add(this.uC_Scholarship1);
            this.gradientPanel1.Controls.Add(this.uC_Teacher1);
            this.gradientPanel1.Controls.Add(this.uC_Suspension1);
            this.gradientPanel1.Controls.Add(this.uC_Role1);
            this.gradientPanel1.Controls.Add(this.uC_Cohort1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(240, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1344, 861);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.ThemeName = "Office2019";
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // navMajor
            // 
            this.navMajor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navMajor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navMajor.Location = new System.Drawing.Point(0, 328);
            this.navMajor.Margin = new System.Windows.Forms.Padding(0);
            this.navMajor.Name = "navMajor";
            this.navMajor.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navMajor.Size = new System.Drawing.Size(240, 47);
            this.navMajor.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navMajor.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navMajor.Style.HoverForeColor = System.Drawing.Color.White;
            this.navMajor.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navMajor.Style.PressedForeColor = System.Drawing.Color.White;
            this.navMajor.TabIndex = 6;
            this.navMajor.Text = "Quản lý chuyên ngành";
            this.navMajor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navMajor.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navMajor.ThemeName = "Office2019";
            this.navMajor.Click += new System.EventHandler(this.navMajor_Click);
            // 
            // navFaculties
            // 
            this.navFaculties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navFaculties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navFaculties.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navFaculties.Location = new System.Drawing.Point(0, 281);
            this.navFaculties.Margin = new System.Windows.Forms.Padding(0);
            this.navFaculties.Name = "navFaculties";
            this.navFaculties.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navFaculties.Size = new System.Drawing.Size(240, 47);
            this.navFaculties.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navFaculties.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navFaculties.Style.HoverForeColor = System.Drawing.Color.White;
            this.navFaculties.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navFaculties.Style.PressedForeColor = System.Drawing.Color.White;
            this.navFaculties.TabIndex = 4;
            this.navFaculties.Text = "Quản lý khoa";
            this.navFaculties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navFaculties.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navFaculties.ThemeName = "Office2019";
            this.navFaculties.Click += new System.EventHandler(this.navFaculties_Click);
            // 
            // navClass
            // 
            this.navClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navClass.Location = new System.Drawing.Point(0, 234);
            this.navClass.Margin = new System.Windows.Forms.Padding(0);
            this.navClass.Name = "navClass";
            this.navClass.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navClass.Size = new System.Drawing.Size(240, 47);
            this.navClass.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navClass.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navClass.Style.HoverForeColor = System.Drawing.Color.White;
            this.navClass.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navClass.Style.PressedForeColor = System.Drawing.Color.White;
            this.navClass.TabIndex = 3;
            this.navClass.Text = "Quản lý lớp";
            this.navClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navClass.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navClass.ThemeName = "Office2019";
            this.navClass.Click += new System.EventHandler(this.navClass_Click);
            // 
            // navStudent
            // 
            this.navStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navStudent.Location = new System.Drawing.Point(0, 187);
            this.navStudent.Margin = new System.Windows.Forms.Padding(0);
            this.navStudent.Name = "navStudent";
            this.navStudent.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navStudent.Size = new System.Drawing.Size(240, 47);
            this.navStudent.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navStudent.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navStudent.Style.HoverForeColor = System.Drawing.Color.White;
            this.navStudent.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navStudent.Style.PressedForeColor = System.Drawing.Color.White;
            this.navStudent.TabIndex = 2;
            this.navStudent.Text = "Thông tin sinh viên";
            this.navStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navStudent.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navStudent.ThemeName = "Office2019";
            this.navStudent.Click += new System.EventHandler(this.navStudent_Click);
            // 
            // navDashboard
            // 
            this.navDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navDashboard.Location = new System.Drawing.Point(0, 140);
            this.navDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navDashboard.Size = new System.Drawing.Size(240, 47);
            this.navDashboard.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navDashboard.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navDashboard.Style.HoverForeColor = System.Drawing.Color.White;
            this.navDashboard.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navDashboard.Style.PressedForeColor = System.Drawing.Color.White;
            this.navDashboard.TabIndex = 1;
            this.navDashboard.Text = "Thống kê";
            this.navDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDashboard.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navDashboard.ThemeName = "Office2019";
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.navDashboard);
            this.flowLayoutPanel1.Controls.Add(this.navStudent);
            this.flowLayoutPanel1.Controls.Add(this.navClass);
            this.flowLayoutPanel1.Controls.Add(this.navFaculties);
            this.flowLayoutPanel1.Controls.Add(this.navMajor);
            this.flowLayoutPanel1.Controls.Add(this.navKhenThuong);
            this.flowLayoutPanel1.Controls.Add(this.navKyLuat);
            this.flowLayoutPanel1.Controls.Add(this.navScholarship);
            this.flowLayoutPanel1.Controls.Add(this.navTeacher);
            this.flowLayoutPanel1.Controls.Add(this.navSuspension);
            this.flowLayoutPanel1.Controls.Add(this.navRole);
            this.flowLayoutPanel1.Controls.Add(this.navCohort);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 861);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // navKhenThuong
            // 
            this.navKhenThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navKhenThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navKhenThuong.Location = new System.Drawing.Point(0, 375);
            this.navKhenThuong.Margin = new System.Windows.Forms.Padding(0);
            this.navKhenThuong.Name = "navKhenThuong";
            this.navKhenThuong.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navKhenThuong.Size = new System.Drawing.Size(240, 47);
            this.navKhenThuong.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navKhenThuong.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navKhenThuong.Style.HoverForeColor = System.Drawing.Color.White;
            this.navKhenThuong.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navKhenThuong.Style.PressedForeColor = System.Drawing.Color.White;
            this.navKhenThuong.TabIndex = 7;
            this.navKhenThuong.Text = "Khen thưởng";
            this.navKhenThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navKhenThuong.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navKhenThuong.ThemeName = "Office2019";
            this.navKhenThuong.Click += new System.EventHandler(this.navKhenThuong_Click);
            // 
            // navKyLuat
            // 
            this.navKyLuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navKyLuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navKyLuat.Location = new System.Drawing.Point(0, 422);
            this.navKyLuat.Margin = new System.Windows.Forms.Padding(0);
            this.navKyLuat.Name = "navKyLuat";
            this.navKyLuat.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navKyLuat.Size = new System.Drawing.Size(240, 47);
            this.navKyLuat.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navKyLuat.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navKyLuat.Style.HoverForeColor = System.Drawing.Color.White;
            this.navKyLuat.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navKyLuat.Style.PressedForeColor = System.Drawing.Color.White;
            this.navKyLuat.TabIndex = 8;
            this.navKyLuat.Text = "Kỷ luật";
            this.navKyLuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navKyLuat.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navKyLuat.ThemeName = "Office2019";
            this.navKyLuat.Click += new System.EventHandler(this.navKyLuat_Click);
            // 
            // navScholarship
            // 
            this.navScholarship.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navScholarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navScholarship.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navScholarship.Location = new System.Drawing.Point(0, 469);
            this.navScholarship.Margin = new System.Windows.Forms.Padding(0);
            this.navScholarship.Name = "navScholarship";
            this.navScholarship.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navScholarship.Size = new System.Drawing.Size(240, 47);
            this.navScholarship.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navScholarship.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navScholarship.Style.HoverForeColor = System.Drawing.Color.White;
            this.navScholarship.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navScholarship.Style.PressedForeColor = System.Drawing.Color.White;
            this.navScholarship.TabIndex = 11;
            this.navScholarship.Text = "Học bổng";
            this.navScholarship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navScholarship.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navScholarship.ThemeName = "Office2019";
            this.navScholarship.Click += new System.EventHandler(this.navScholarship_Click);
            // 
            // navTeacher
            // 
            this.navTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navTeacher.Location = new System.Drawing.Point(0, 516);
            this.navTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.navTeacher.Name = "navTeacher";
            this.navTeacher.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navTeacher.Size = new System.Drawing.Size(240, 47);
            this.navTeacher.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navTeacher.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navTeacher.Style.HoverForeColor = System.Drawing.Color.White;
            this.navTeacher.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navTeacher.Style.PressedForeColor = System.Drawing.Color.White;
            this.navTeacher.TabIndex = 13;
            this.navTeacher.Text = "Thông tin giảng viên";
            this.navTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navTeacher.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navTeacher.ThemeName = "Office2019";
            this.navTeacher.Click += new System.EventHandler(this.navTeacher_Click);
            // 
            // navSuspension
            // 
            this.navSuspension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navSuspension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSuspension.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navSuspension.Location = new System.Drawing.Point(0, 563);
            this.navSuspension.Margin = new System.Windows.Forms.Padding(0);
            this.navSuspension.Name = "navSuspension";
            this.navSuspension.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navSuspension.Size = new System.Drawing.Size(240, 47);
            this.navSuspension.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navSuspension.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navSuspension.Style.HoverForeColor = System.Drawing.Color.White;
            this.navSuspension.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navSuspension.Style.PressedForeColor = System.Drawing.Color.White;
            this.navSuspension.TabIndex = 15;
            this.navSuspension.Text = "Quản lý bảo lưu";
            this.navSuspension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSuspension.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navSuspension.ThemeName = "Office2019";
            this.navSuspension.Click += new System.EventHandler(this.navSuspension_Click);
            // 
            // navRole
            // 
            this.navRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navRole.Location = new System.Drawing.Point(0, 610);
            this.navRole.Margin = new System.Windows.Forms.Padding(0);
            this.navRole.Name = "navRole";
            this.navRole.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navRole.Size = new System.Drawing.Size(240, 47);
            this.navRole.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navRole.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navRole.Style.HoverForeColor = System.Drawing.Color.White;
            this.navRole.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navRole.Style.PressedForeColor = System.Drawing.Color.White;
            this.navRole.TabIndex = 16;
            this.navRole.Text = "Quản lý cán bộ lớp";
            this.navRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navRole.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navRole.ThemeName = "Office2019";
            this.navRole.Click += new System.EventHandler(this.navRole_Click);
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = this;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = "Office2019";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // navCohort
            // 
            this.navCohort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navCohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCohort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navCohort.Location = new System.Drawing.Point(0, 657);
            this.navCohort.Margin = new System.Windows.Forms.Padding(0);
            this.navCohort.Name = "navCohort";
            this.navCohort.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.navCohort.Size = new System.Drawing.Size(240, 47);
            this.navCohort.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.navCohort.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.navCohort.Style.HoverForeColor = System.Drawing.Color.White;
            this.navCohort.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.navCohort.Style.PressedForeColor = System.Drawing.Color.White;
            this.navCohort.TabIndex = 18;
            this.navCohort.Text = "Quản lý khóa đào tạo";
            this.navCohort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCohort.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.navCohort.ThemeName = "Office2019";
            this.navCohort.Click += new System.EventHandler(this.navCohort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(0, 704);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnExit.Size = new System.Drawing.Size(240, 47);
            this.btnExit.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnExit.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnExit.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnExit.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnExit.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnExit.ThemeName = "Office2019";
            this.btnExit.UseWaitCursor = true;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // uC_Student1
            // 
            this.uC_Student1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_Student1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uC_Student1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Student1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uC_Student1.Location = new System.Drawing.Point(0, 0);
            this.uC_Student1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Student1.Name = "uC_Student1";
            this.uC_Student1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Student1.TabIndex = 1;
            // 
            // uC_Class1
            // 
            this.uC_Class1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Class1.Location = new System.Drawing.Point(0, 0);
            this.uC_Class1.Name = "uC_Class1";
            this.uC_Class1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Class1.TabIndex = 6;
            // 
            // uC_Faculties1
            // 
            this.uC_Faculties1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Faculties1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Faculties1.Location = new System.Drawing.Point(0, 0);
            this.uC_Faculties1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uC_Faculties1.Name = "uC_Faculties1";
            this.uC_Faculties1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Faculties1.TabIndex = 2;
            // 
            // uC_Major1
            // 
            this.uC_Major1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Major1.Location = new System.Drawing.Point(0, 0);
            this.uC_Major1.Name = "uC_Major1";
            this.uC_Major1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Major1.TabIndex = 3;
            // 
            // uC_KhenThuong1
            // 
            this.uC_KhenThuong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_KhenThuong1.Location = new System.Drawing.Point(0, 0);
            this.uC_KhenThuong1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_KhenThuong1.Name = "uC_KhenThuong1";
            this.uC_KhenThuong1.Size = new System.Drawing.Size(1340, 857);
            this.uC_KhenThuong1.TabIndex = 4;
            // 
            // uC_KyLuat1
            // 
            this.uC_KyLuat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_KyLuat1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.uC_KyLuat1.Location = new System.Drawing.Point(0, 0);
            this.uC_KyLuat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_KyLuat1.Name = "uC_KyLuat1";
            this.uC_KyLuat1.Size = new System.Drawing.Size(1340, 857);
            this.uC_KyLuat1.TabIndex = 5;
            // 
            // uC_Scholarship1
            // 
            this.uC_Scholarship1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Scholarship1.Location = new System.Drawing.Point(0, 0);
            this.uC_Scholarship1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uC_Scholarship1.Name = "uC_Scholarship1";
            this.uC_Scholarship1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Scholarship1.TabIndex = 7;
            // 
            // uC_Teacher1
            // 
            this.uC_Teacher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Teacher1.Location = new System.Drawing.Point(0, 0);
            this.uC_Teacher1.Name = "uC_Teacher1";
            this.uC_Teacher1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Teacher1.TabIndex = 9;
            // 
            // uC_Suspension1
            // 
            this.uC_Suspension1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Suspension1.Location = new System.Drawing.Point(0, 0);
            this.uC_Suspension1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uC_Suspension1.Name = "uC_Suspension1";
            this.uC_Suspension1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Suspension1.TabIndex = 10;
            // 
            // uC_Role1
            // 
            this.uC_Role1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Role1.Location = new System.Drawing.Point(0, 0);
            this.uC_Role1.Name = "uC_Role1";
            this.uC_Role1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Role1.TabIndex = 8;
            // 
            // uC_Cohort1
            // 
            this.uC_Cohort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Cohort1.Location = new System.Drawing.Point(0, 0);
            this.uC_Cohort1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uC_Cohort1.Name = "uC_Cohort1";
            this.uC_Cohort1.Size = new System.Drawing.Size(1340, 857);
            this.uC_Cohort1.TabIndex = 11;
            // 
            // QLHSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLHSSV";
            this.Text = "QLHSSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton navMajor;
        private Syncfusion.WinForms.Controls.SfButton navFaculties;
        private Syncfusion.WinForms.Controls.SfButton navClass;
        private Syncfusion.WinForms.Controls.SfButton navStudent;
        private Syncfusion.WinForms.Controls.SfButton navDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UC_Dashboard uC_Dashboard1;
        private UC_Student uC_Student1;
        private UC_Faculties uC_Faculties1;
        private Syncfusion.WinForms.Controls.SfButton navKhenThuong;
        private Syncfusion.WinForms.Controls.SfButton navKyLuat;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private UC_Major uC_Major1;
        private UC_KhenThuong uC_KhenThuong1;
        private UC_KyLuat uC_KyLuat1;
        private UC_Class uC_Class1;
        private Syncfusion.WinForms.Controls.SfButton navScholarship;
        private Syncfusion.WinForms.Controls.SfButton navTeacher;
        private Syncfusion.WinForms.Controls.SfButton navSuspension;
        private Syncfusion.WinForms.Controls.SfButton navRole;
        private UC_Scholarship uC_Scholarship1;
        private UC_Teacher uC_Teacher1;
        private UC_Role uC_Role1;
        private UC_Suspension uC_Suspension1;
        private Syncfusion.WinForms.Controls.SfButton navCohort;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private UC_Cohort uC_Cohort1;
    }
}

