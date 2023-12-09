
namespace QLTV
{
    partial class formGiaoDien
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
            btnMuonSach = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            heThong_StripMenu = new ToolStripMenuItem();
            btnTaiKhoan = new ToolStripMenuItem();
            btnDangXuat = new ToolStripMenuItem();
            btnThoat = new ToolStripMenuItem();
            danhMuc_toolStripMenu = new ToolStripMenuItem();
            btnQuanLySach = new ToolStripMenuItem();
            btnQuanLyTacGia = new ToolStripMenuItem();
            btnQuanLyDocGia = new ToolStripMenuItem();
            btnQuanLyNhanVien = new ToolStripMenuItem();
            thểLoạiToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtBảnToolStripMenuItem = new ToolStripMenuItem();
            muonSach_StripMenu = new ToolStripMenuItem();
            mượnSáchToolStripMenuItem = new ToolStripMenuItem();
            trảSáchToolStripMenuItem = new ToolStripMenuItem();
            timKiem_StripMenu = new ToolStripMenuItem();
            btnTimKiemDocGia = new ToolStripMenuItem();
            baoCao_StripMenu = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMuonSach
            // 
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(224, 32);
            btnMuonSach.Text = "Mượn sách";
            btnMuonSach.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dddd, MMMM dd, yyyy HH:mm tt";
            dateTimePicker1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(850, 4);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(366, 29);
            dateTimePicker1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 37);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 845);
            panel1.TabIndex = 2;
            // 
            // heThong_StripMenu
            // 
            heThong_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnTaiKhoan, btnDangXuat, btnThoat });
            heThong_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heThong_StripMenu.Name = "heThong_StripMenu";
            heThong_StripMenu.Size = new Size(90, 25);
            heThong_StripMenu.Text = "Hệ thống";
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(160, 26);
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Image = _3.GUI.Properties.Resources.account_25;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(160, 26);
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 26);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // danhMuc_toolStripMenu
            // 
            danhMuc_toolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnQuanLySach, btnQuanLyTacGia, btnQuanLyDocGia, btnQuanLyNhanVien, thểLoạiToolStripMenuItem, nhàXuấtBảnToolStripMenuItem });
            danhMuc_toolStripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            danhMuc_toolStripMenu.Name = "danhMuc_toolStripMenu";
            danhMuc_toolStripMenu.Size = new Size(98, 25);
            danhMuc_toolStripMenu.Text = "Danh mục";
            danhMuc_toolStripMenu.Click += danhMuc_toolStripMenu_Click;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(213, 26);
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.Click += quảnLýSáchToolStripMenuItem_Click;
            // 
            // btnQuanLyTacGia
            // 
            btnQuanLyTacGia.Name = "btnQuanLyTacGia";
            btnQuanLyTacGia.Size = new Size(213, 26);
            btnQuanLyTacGia.Text = "Quản lý tác giả";
            btnQuanLyTacGia.Click += menuTacGia_Click;
            // 
            // btnQuanLyDocGia
            // 
            btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            btnQuanLyDocGia.Size = new Size(213, 26);
            btnQuanLyDocGia.Text = "Quản lý độc giả";
            btnQuanLyDocGia.Click += độcGiảToolStripMenuItem_Click;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(213, 26);
            btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            btnQuanLyNhanVien.Click += nhânViênToolStripMenuItem_Click;
            // 
            // thểLoạiToolStripMenuItem
            // 
            thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            thểLoạiToolStripMenuItem.Size = new Size(213, 26);
            thểLoạiToolStripMenuItem.Text = "Thể loại";
            thểLoạiToolStripMenuItem.Click += thểLoạiToolStripMenuItem_Click;
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            nhàXuấtBảnToolStripMenuItem.Size = new Size(213, 26);
            nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            nhàXuấtBảnToolStripMenuItem.Click += nhàXuấtBảnToolStripMenuItem_Click;
            // 
            // muonSach_StripMenu
            // 
            muonSach_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem, trảSáchToolStripMenuItem });
            muonSach_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            muonSach_StripMenu.Name = "muonSach_StripMenu";
            muonSach_StripMenu.Size = new Size(130, 25);
            muonSach_StripMenu.Text = "Mượn trả sách";
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(164, 26);
            mượnSáchToolStripMenuItem.Text = "Mượn sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click_1;
            // 
            // trảSáchToolStripMenuItem
            // 
            trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            trảSáchToolStripMenuItem.Size = new Size(164, 26);
            trảSáchToolStripMenuItem.Text = "Trả sách";
            trảSáchToolStripMenuItem.Click += trảSáchToolStripMenuItem_Click;
            // 
            // timKiem_StripMenu
            // 
            timKiem_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnTimKiemDocGia });
            timKiem_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timKiem_StripMenu.Name = "timKiem_StripMenu";
            timKiem_StripMenu.Size = new Size(94, 25);
            timKiem_StripMenu.Text = "Tìm kiếm";
            // 
            // btnTimKiemDocGia
            // 
            btnTimKiemDocGia.Name = "btnTimKiemDocGia";
            btnTimKiemDocGia.Size = new Size(212, 26);
            btnTimKiemDocGia.Text = "Tìm kiếm độc giả";
            btnTimKiemDocGia.Click += tìmKiếmĐộcGiảToolStripMenuItem_Click;
            // 
            // baoCao_StripMenu
            // 
            baoCao_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            baoCao_StripMenu.Name = "baoCao_StripMenu";
            baoCao_StripMenu.Size = new Size(84, 25);
            baoCao_StripMenu.Text = "Báo cáo";
            baoCao_StripMenu.Click += baoCao_StripMenu_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThong_StripMenu, danhMuc_toolStripMenu, muonSach_StripMenu, timKiem_StripMenu, baoCao_StripMenu, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1222, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 660);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "formGiaoDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao diện";
            FormClosing += formGiaoDien_FormClosing;
            FormClosed += formGiaoDien_FormClosed;
            Load += formGiaoDien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem btnMuonSach;
        private Panel panel1;
        private ToolStripMenuItem heThong_StripMenu;
        private ToolStripMenuItem btnTaiKhoan;
        private ToolStripMenuItem btnDangXuat;
        private ToolStripMenuItem btnThoat;
        private ToolStripMenuItem danhMuc_toolStripMenu;
        private ToolStripMenuItem btnQuanLySach;
        private ToolStripMenuItem btnQuanLyTacGia;
        private ToolStripMenuItem btnQuanLyDocGia;
        private ToolStripMenuItem btnQuanLyNhanVien;
        private ToolStripMenuItem thểLoạiToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem muonSach_StripMenu;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ToolStripMenuItem trảSáchToolStripMenuItem;
        private ToolStripMenuItem timKiem_StripMenu;
        private ToolStripMenuItem btnTimKiemDocGia;
        private ToolStripMenuItem baoCao_StripMenu;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
    }
}