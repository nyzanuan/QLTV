
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
            menuStrip1 = new MenuStrip();
            heThong_StripMenu = new ToolStripMenuItem();
            btnDangXuat = new ToolStripMenuItem();
            btnTaiKhoan = new ToolStripMenuItem();
            btnThoat = new ToolStripMenuItem();
            danhMuc_toolStripMenu = new ToolStripMenuItem();
            btnQuanLySach = new ToolStripMenuItem();
            btnQuanLyTacGia = new ToolStripMenuItem();
            btnQuanLyDocGia = new ToolStripMenuItem();
            btnQuanLyNhanVien = new ToolStripMenuItem();
            muonSach_StripMenu = new ToolStripMenuItem();
            btnMuonSach = new ToolStripMenuItem();
            timKiem_StripMenu = new ToolStripMenuItem();
            btnTimKiemDocGia = new ToolStripMenuItem();
            baoCao_StripMenu = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThong_StripMenu, danhMuc_toolStripMenu, muonSach_StripMenu, timKiem_StripMenu, baoCao_StripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1397, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThong_StripMenu
            // 
            heThong_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnDangXuat, btnTaiKhoan, btnThoat });
            heThong_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heThong_StripMenu.Name = "heThong_StripMenu";
            heThong_StripMenu.Size = new Size(114, 31);
            heThong_StripMenu.Text = "Hệ thống";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Image = _3.GUI.Properties.Resources.account_25;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(224, 32);
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(224, 32);
            btnTaiKhoan.Text = "Tài khoản";
            // 
            // btnThoat
            // 
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(224, 32);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // danhMuc_toolStripMenu
            // 
            danhMuc_toolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnQuanLySach, btnQuanLyTacGia, btnQuanLyDocGia, btnQuanLyNhanVien });
            danhMuc_toolStripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            danhMuc_toolStripMenu.Name = "danhMuc_toolStripMenu";
            danhMuc_toolStripMenu.Size = new Size(125, 31);
            danhMuc_toolStripMenu.Text = "Danh mục";
            danhMuc_toolStripMenu.Click += danhMuc_toolStripMenu_Click;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(274, 32);
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.Click += quảnLýSáchToolStripMenuItem_Click;
            // 
            // btnQuanLyTacGia
            // 
            btnQuanLyTacGia.Name = "btnQuanLyTacGia";
            btnQuanLyTacGia.Size = new Size(274, 32);
            btnQuanLyTacGia.Text = "Quản lý tác giả";
            btnQuanLyTacGia.Click += menuTacGia_Click;
            // 
            // btnQuanLyDocGia
            // 
            btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            btnQuanLyDocGia.Size = new Size(274, 32);
            btnQuanLyDocGia.Text = "Quản lý độc giả";
            btnQuanLyDocGia.Click += độcGiảToolStripMenuItem_Click;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(274, 32);
            btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            btnQuanLyNhanVien.Click += nhânViênToolStripMenuItem_Click;
            // 
            // muonSach_StripMenu
            // 
            muonSach_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnMuonSach });
            muonSach_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            muonSach_StripMenu.Name = "muonSach_StripMenu";
            muonSach_StripMenu.Size = new Size(166, 31);
            muonSach_StripMenu.Text = "Mượn trả sách";
            // 
            // btnMuonSach
            // 
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(224, 32);
            btnMuonSach.Text = "Mượn sách";
            btnMuonSach.Click += mượnSáchToolStripMenuItem_Click;
            // 
            // timKiem_StripMenu
            // 
            timKiem_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnTimKiemDocGia });
            timKiem_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timKiem_StripMenu.Name = "timKiem_StripMenu";
            timKiem_StripMenu.Size = new Size(117, 31);
            timKiem_StripMenu.Text = "Tìm kiếm";
            // 
            // btnTimKiemDocGia
            // 
            btnTimKiemDocGia.Name = "btnTimKiemDocGia";
            btnTimKiemDocGia.Size = new Size(264, 32);
            btnTimKiemDocGia.Text = "Tìm kiếm độc giả";
            btnTimKiemDocGia.Click += tìmKiếmĐộcGiảToolStripMenuItem_Click;
            // 
            // baoCao_StripMenu
            // 
            baoCao_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            baoCao_StripMenu.Name = "baoCao_StripMenu";
            baoCao_StripMenu.Size = new Size(105, 31);
            baoCao_StripMenu.Text = "Báo cáo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dddd, MMMM dd, yyyy HH:mm tt";
            dateTimePicker1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(901, 5);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(485, 35);
            dateTimePicker1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 49);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 1126);
            panel1.TabIndex = 2;
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 880);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThong_StripMenu;
        private ToolStripMenuItem danhMuc_toolStripMenu;
        private ToolStripMenuItem muonSach_StripMenu;
        private ToolStripMenuItem timKiem_StripMenu;
        private ToolStripMenuItem baoCao_StripMenu;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem btnQuanLySach;
        private ToolStripMenuItem btnQuanLyTacGia;
        private ToolStripMenuItem btnDangXuat;
        private ToolStripMenuItem btnTaiKhoan;
        private ToolStripMenuItem btnQuanLyDocGia;
        private ToolStripMenuItem btnMuonSach;
        private ToolStripMenuItem btnTimKiemDocGia;
        private ToolStripMenuItem btnQuanLyNhanVien;
        private ToolStripMenuItem btnThoat;
        private Panel panel1;
    }
}