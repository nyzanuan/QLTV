
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGiaoDien));
            panelMenu = new Panel();
            panelOut = new Panel();
            btnThoat = new Button();
            btnDangXuat = new Button();
            txtPhanQuyen = new TextBox();
            btnBaoCao = new Button();
            panelMuonSachCon = new Panel();
            btnTraSach = new Button();
            btnMuonSach = new Button();
            btnMTSach = new Button();
            panelDanhMucCon = new Panel();
            btnQuanLySach = new Button();
            btnNXB = new Button();
            btnTheLoaiSach = new Button();
            btnTacGia = new Button();
            btnNhanVien = new Button();
            btnDocGia = new Button();
            btnDanhMuc = new Button();
            panelLogoUTH = new Panel();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelMenu.SuspendLayout();
            panelOut.SuspendLayout();
            panelMuonSachCon.SuspendLayout();
            panelDanhMucCon.SuspendLayout();
            panelLogoUTH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(11, 7, 7);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(panelOut);
            panelMenu.Controls.Add(txtPhanQuyen);
            panelMenu.Controls.Add(btnBaoCao);
            panelMenu.Controls.Add(panelMuonSachCon);
            panelMenu.Controls.Add(btnMTSach);
            panelMenu.Controls.Add(panelDanhMucCon);
            panelMenu.Controls.Add(btnDanhMuc);
            panelMenu.Controls.Add(panelLogoUTH);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 614);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panelOut
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
            // btnThoat
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 37);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 845);
            panel1.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.PaleTurquoise;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = SystemColors.ControlText;
            btnDangXuat.Location = new Point(0, 0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(160, 26);
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // txtPhanQuyen
            // 
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 26);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBaoCao
            // 
            danhMuc_toolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { btnQuanLySach, btnQuanLyTacGia, btnQuanLyDocGia, btnQuanLyNhanVien, thểLoạiToolStripMenuItem, nhàXuấtBảnToolStripMenuItem });
            danhMuc_toolStripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            danhMuc_toolStripMenu.Name = "danhMuc_toolStripMenu";
            danhMuc_toolStripMenu.Size = new Size(98, 25);
            danhMuc_toolStripMenu.Text = "Danh mục";
            danhMuc_toolStripMenu.Click += danhMuc_toolStripMenu_Click;
            // 
            // panelMuonSachCon
            // 
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(213, 26);
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.Click += quảnLýSáchToolStripMenuItem_Click;
            // 
            // btnTraSach
            // 
            btnQuanLyTacGia.Name = "btnQuanLyTacGia";
            btnQuanLyTacGia.Size = new Size(213, 26);
            btnQuanLyTacGia.Text = "Quản lý tác giả";
            btnQuanLyTacGia.Click += menuTacGia_Click;
            // 
            // btnMuonSach
            // 
            btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            btnQuanLyDocGia.Size = new Size(213, 26);
            btnQuanLyDocGia.Text = "Quản lý độc giả";
            btnQuanLyDocGia.Click += độcGiảToolStripMenuItem_Click;
            // 
            // btnMTSach
            // 
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(213, 26);
            btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            btnQuanLyNhanVien.Click += nhânViênToolStripMenuItem_Click;
            // 
            // btnQuanLySach
            // 
            thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            thểLoạiToolStripMenuItem.Size = new Size(213, 26);
            thểLoạiToolStripMenuItem.Text = "Thể loại";
            thểLoạiToolStripMenuItem.Click += thểLoạiToolStripMenuItem_Click;
            // 
            // btnNXB
            // 
            nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            nhàXuấtBảnToolStripMenuItem.Size = new Size(213, 26);
            nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            nhàXuấtBảnToolStripMenuItem.Click += nhàXuấtBảnToolStripMenuItem_Click;
            // 
            // btnTheLoaiSach
            // 
            muonSach_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem, trảSáchToolStripMenuItem });
            muonSach_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            muonSach_StripMenu.Name = "muonSach_StripMenu";
            muonSach_StripMenu.Size = new Size(130, 25);
            muonSach_StripMenu.Text = "Mượn trả sách";
            // 
            // btnTacGia
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(164, 26);
            mượnSáchToolStripMenuItem.Text = "Mượn sách";
            mượnSáchToolStripMenuItem.Click += mượnSáchToolStripMenuItem_Click_1;
            // 
            // btnNhanVien
            // 
            trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            trảSáchToolStripMenuItem.Size = new Size(164, 26);
            trảSáchToolStripMenuItem.Text = "Trả sách";
            trảSáchToolStripMenuItem.Click += trảSáchToolStripMenuItem_Click;
            // 
            // btnDocGia
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
            // pictureBox1
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
            // panelMain
            // 
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelOut.ResumeLayout(false);
            panelMuonSachCon.ResumeLayout(false);
            panelDanhMucCon.ResumeLayout(false);
            panelLogoUTH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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