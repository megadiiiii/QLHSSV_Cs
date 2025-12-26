using System.Drawing;

namespace BTL_QLHSSV_NETFW
{
    partial class frmMainMenu
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
            this.uC_Dashboard1 = new BTL_QLHSSV_NETFW.UC_Dashboard();
            this.uC_Student1 = new BTL_QLHSSV_NETFW.UC_Student();
            this.uC_Class1 = new BTL_QLHSSV_NETFW.UC_Class();
            this.uC_Faculties1 = new BTL_QLHSSV_NETFW.UC_Faculties();
            this.uC_Major1 = new BTL_QLHSSV_NETFW.UC_Major();
            this.uC_KhenThuong1 = new BTL_QLHSSV_NETFW.UC_KhenThuong();
            this.uC_KyLuat1 = new BTL_QLHSSV_NETFW.UC_KyLuat();
            this.navMajor = new Syncfusion.WinForms.Controls.SfButton();
            this.navFaculties = new Syncfusion.WinForms.Controls.SfButton();
            this.navClass = new Syncfusion.WinForms.Controls.SfButton();
            this.navStudent = new Syncfusion.WinForms.Controls.SfButton();
            this.navDashboard = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nav_KhenThuong = new Syncfusion.WinForms.Controls.SfButton();
            this.nav_KyLuat = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Syncfusion.WinForms.Controls.SfButton();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(240, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1344, 861);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.ThemeName = "Office2019";
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
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
            this.uC_Class1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.uC_KhenThuong1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
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
            this.uC_KyLuat1.Location = new System.Drawing.Point(0, 0);
            this.uC_KyLuat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_KyLuat1.Name = "uC_KyLuat1";
            this.uC_KyLuat1.Size = new System.Drawing.Size(1340, 857);
            this.uC_KyLuat1.TabIndex = 5;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.flowLayoutPanel1.Controls.Add(this.nav_KhenThuong);
            this.flowLayoutPanel1.Controls.Add(this.nav_KyLuat);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 861);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // nav_KhenThuong
            // 
            this.nav_KhenThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_KhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_KhenThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nav_KhenThuong.Location = new System.Drawing.Point(0, 375);
            this.nav_KhenThuong.Margin = new System.Windows.Forms.Padding(0);
            this.nav_KhenThuong.Name = "nav_KhenThuong";
            this.nav_KhenThuong.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.nav_KhenThuong.Size = new System.Drawing.Size(240, 47);
            this.nav_KhenThuong.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.nav_KhenThuong.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.nav_KhenThuong.Style.HoverForeColor = System.Drawing.Color.White;
            this.nav_KhenThuong.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.nav_KhenThuong.Style.PressedForeColor = System.Drawing.Color.White;
            this.nav_KhenThuong.TabIndex = 7;
            this.nav_KhenThuong.Text = "Khen thưởng";
            this.nav_KhenThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_KhenThuong.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.nav_KhenThuong.ThemeName = "Office2019";
            this.nav_KhenThuong.Click += new System.EventHandler(this.nav_KhenThuong_Click);
            // 
            // nav_KyLuat
            // 
            this.nav_KyLuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_KyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_KyLuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nav_KyLuat.Location = new System.Drawing.Point(0, 422);
            this.nav_KyLuat.Margin = new System.Windows.Forms.Padding(0);
            this.nav_KyLuat.Name = "nav_KyLuat";
            this.nav_KyLuat.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.nav_KyLuat.Size = new System.Drawing.Size(240, 47);
            this.nav_KyLuat.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.nav_KyLuat.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.nav_KyLuat.Style.HoverForeColor = System.Drawing.Color.White;
            this.nav_KyLuat.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.nav_KyLuat.Style.PressedForeColor = System.Drawing.Color.White;
            this.nav_KyLuat.TabIndex = 8;
            this.nav_KyLuat.Text = "Kỷ luật";
            this.nav_KyLuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_KyLuat.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.nav_KyLuat.ThemeName = "Office2019";
            this.nav_KyLuat.Click += new System.EventHandler(this.nav_KyLuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 343);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(0, 818);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnLogout.Size = new System.Drawing.Size(240, 47);
            this.btnLogout.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnLogout.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.btnLogout.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnLogout.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btnLogout.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextMargin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnLogout.ThemeName = "Office2019";
            this.btnLogout.UseWaitCursor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = this;
            this.sfSkinManager1.Controls = null;
            this.sfSkinManager1.ThemeName = "Office2019";
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Syncfusion.WinForms.Controls.SfButton nav_KhenThuong;
        private Syncfusion.WinForms.Controls.SfButton nav_KyLuat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.WinForms.Controls.SfButton btnLogout;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private UC_Major uC_Major1;
        private UC_KhenThuong uC_KhenThuong1;
        private UC_Class uC_Class1;
        private UC_KyLuat uC_KyLuat1;
    }
}

