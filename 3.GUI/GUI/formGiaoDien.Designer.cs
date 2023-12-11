
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
            panelOut.Controls.Add(btnThoat);
            panelOut.Controls.Add(btnDangXuat);
            panelOut.Dock = DockStyle.Top;
            panelOut.Location = new Point(0, 527);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(188, 77);
            panelOut.TabIndex = 33;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.PaleTurquoise;
            btnThoat.Dock = DockStyle.Top;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ControlText;
            btnThoat.Location = new Point(0, 38);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(10, 0, 0, 0);
            btnThoat.Size = new Size(188, 38);
            btnThoat.TabIndex = 26;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = false;
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
            btnDangXuat.Padding = new Padding(10, 0, 0, 0);
            btnDangXuat.Size = new Size(188, 38);
            btnDangXuat.TabIndex = 25;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;

            // 
            // txtPhanQuyen
            // 
            txtPhanQuyen.BackColor = Color.PaleTurquoise;
            txtPhanQuyen.Dock = DockStyle.Top;
            txtPhanQuyen.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhanQuyen.ForeColor = SystemColors.MenuText;
            txtPhanQuyen.Location = new Point(0, 498);
            txtPhanQuyen.Name = "txtPhanQuyen";
            txtPhanQuyen.PlaceholderText = "Phân quyền";
            txtPhanQuyen.Size = new Size(188, 29);
            txtPhanQuyen.TabIndex = 32;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.PaleTurquoise;
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaoCao.ForeColor = SystemColors.ControlText;
            btnBaoCao.Location = new Point(0, 460);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(10, 0, 0, 0);
            btnBaoCao.Size = new Size(188, 38);
            btnBaoCao.TabIndex = 23;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // panelMuonSachCon
            // 
            panelMuonSachCon.Controls.Add(btnTraSach);
            panelMuonSachCon.Controls.Add(btnMuonSach);
            panelMuonSachCon.Dock = DockStyle.Top;
            panelMuonSachCon.Location = new Point(0, 388);
            panelMuonSachCon.Name = "panelMuonSachCon";
            panelMuonSachCon.Size = new Size(188, 72);
            panelMuonSachCon.TabIndex = 29;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.FromArgb(192, 255, 255);
            btnTraSach.Dock = DockStyle.Top;
            btnTraSach.FlatAppearance.BorderSize = 0;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraSach.ForeColor = SystemColors.Desktop;
            btnTraSach.Location = new Point(0, 38);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Padding = new Padding(30, 0, 0, 0);
            btnTraSach.RightToLeft = RightToLeft.No;
            btnTraSach.Size = new Size(188, 37);
            btnTraSach.TabIndex = 12;
            btnTraSach.Text = "Trả sách";
            btnTraSach.TextAlign = ContentAlignment.MiddleLeft;
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.BackColor = Color.FromArgb(192, 255, 255);
            btnMuonSach.Dock = DockStyle.Top;
            btnMuonSach.FlatAppearance.BorderSize = 0;
            btnMuonSach.FlatStyle = FlatStyle.Flat;
            btnMuonSach.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMuonSach.ForeColor = SystemColors.Desktop;
            btnMuonSach.Location = new Point(0, 0);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Padding = new Padding(30, 0, 0, 0);
            btnMuonSach.Size = new Size(188, 38);
            btnMuonSach.TabIndex = 11;
            btnMuonSach.Text = "Mượn sách";
            btnMuonSach.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonSach.UseVisualStyleBackColor = false;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // btnMTSach
            // 
            btnMTSach.BackColor = Color.PaleTurquoise;
            btnMTSach.Dock = DockStyle.Top;
            btnMTSach.FlatAppearance.BorderSize = 0;
            btnMTSach.FlatStyle = FlatStyle.Flat;
            btnMTSach.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMTSach.ForeColor = SystemColors.ControlText;
            btnMTSach.Location = new Point(0, 350);
            btnMTSach.Name = "btnMTSach";
            btnMTSach.Padding = new Padding(10, 0, 0, 0);
            btnMTSach.Size = new Size(188, 38);
            btnMTSach.TabIndex = 28;
            btnMTSach.Text = "Mượn trả sách";
            btnMTSach.TextAlign = ContentAlignment.MiddleLeft;
            btnMTSach.UseVisualStyleBackColor = false;
            btnMTSach.Click += btnMTSach_Click;
            // 
            // panelDanhMucCon
            // 
            panelDanhMucCon.BackColor = Color.Teal;
            panelDanhMucCon.Controls.Add(btnQuanLySach);
            panelDanhMucCon.Controls.Add(btnNXB);
            panelDanhMucCon.Controls.Add(btnTheLoaiSach);
            panelDanhMucCon.Controls.Add(btnTacGia);
            panelDanhMucCon.Controls.Add(btnNhanVien);
            panelDanhMucCon.Controls.Add(btnDocGia);
            panelDanhMucCon.Dock = DockStyle.Top;
            panelDanhMucCon.Location = new Point(0, 126);
            panelDanhMucCon.Name = "panelDanhMucCon";
            panelDanhMucCon.Size = new Size(188, 224);
            panelDanhMucCon.TabIndex = 27;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.BackColor = Color.FromArgb(192, 255, 255);
            btnQuanLySach.Dock = DockStyle.Top;
            btnQuanLySach.FlatAppearance.BorderSize = 0;
            btnQuanLySach.FlatStyle = FlatStyle.Flat;
            btnQuanLySach.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuanLySach.ForeColor = SystemColors.Desktop;
            btnQuanLySach.Location = new Point(0, 190);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Padding = new Padding(30, 0, 0, 0);
            btnQuanLySach.Size = new Size(188, 34);
            btnQuanLySach.TabIndex = 9;
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLySach.UseVisualStyleBackColor = false;
            btnQuanLySach.Click += btnQuanLySach_Click;
            // 
            // btnNXB
            // 
            btnNXB.BackColor = Color.FromArgb(192, 255, 255);
            btnNXB.Dock = DockStyle.Top;
            btnNXB.FlatAppearance.BorderSize = 0;
            btnNXB.FlatStyle = FlatStyle.Flat;
            btnNXB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNXB.ForeColor = SystemColors.Desktop;
            btnNXB.Location = new Point(0, 152);
            btnNXB.Name = "btnNXB";
            btnNXB.Padding = new Padding(30, 0, 0, 0);
            btnNXB.Size = new Size(188, 38);
            btnNXB.TabIndex = 15;
            btnNXB.Text = "Nhà xuất bản";
            btnNXB.TextAlign = ContentAlignment.MiddleLeft;
            btnNXB.UseVisualStyleBackColor = false;
            btnNXB.Click += btnNXB_Click;
            // 
            // btnTheLoaiSach
            // 
            btnTheLoaiSach.BackColor = Color.FromArgb(192, 255, 255);
            btnTheLoaiSach.Dock = DockStyle.Top;
            btnTheLoaiSach.FlatAppearance.BorderSize = 0;
            btnTheLoaiSach.FlatStyle = FlatStyle.Flat;
            btnTheLoaiSach.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTheLoaiSach.ForeColor = SystemColors.Desktop;
            btnTheLoaiSach.Location = new Point(0, 114);
            btnTheLoaiSach.Name = "btnTheLoaiSach";
            btnTheLoaiSach.Padding = new Padding(30, 0, 0, 0);
            btnTheLoaiSach.Size = new Size(188, 38);
            btnTheLoaiSach.TabIndex = 14;
            btnTheLoaiSach.Text = "Thể loại sách";
            btnTheLoaiSach.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoaiSach.UseVisualStyleBackColor = false;
            btnTheLoaiSach.Click += btnTheLoaiSach_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.BackColor = Color.FromArgb(192, 255, 255);
            btnTacGia.Dock = DockStyle.Top;
            btnTacGia.FlatAppearance.BorderSize = 0;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTacGia.ForeColor = SystemColors.Desktop;
            btnTacGia.Location = new Point(0, 76);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Padding = new Padding(30, 0, 0, 0);
            btnTacGia.Size = new Size(188, 38);
            btnTacGia.TabIndex = 10;
            btnTacGia.Text = "Quản lý tác giả";
            btnTacGia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacGia.UseVisualStyleBackColor = false;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(192, 255, 255);
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = SystemColors.Desktop;
            btnNhanVien.Location = new Point(0, 38);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(30, 0, 0, 0);
            btnNhanVien.Size = new Size(188, 38);
            btnNhanVien.TabIndex = 12;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDocGia
            // 
            btnDocGia.BackColor = Color.FromArgb(192, 255, 255);
            btnDocGia.Dock = DockStyle.Top;
            btnDocGia.FlatAppearance.BorderSize = 0;
            btnDocGia.FlatStyle = FlatStyle.Flat;
            btnDocGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDocGia.ForeColor = SystemColors.Desktop;
            btnDocGia.Location = new Point(0, 0);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Padding = new Padding(30, 0, 0, 0);
            btnDocGia.Size = new Size(188, 38);
            btnDocGia.TabIndex = 11;
            btnDocGia.Text = "Quản lý độc giả";
            btnDocGia.TextAlign = ContentAlignment.MiddleLeft;
            btnDocGia.UseVisualStyleBackColor = false;
            btnDocGia.Click += button5_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.PaleTurquoise;
            btnDanhMuc.Dock = DockStyle.Top;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhMuc.ForeColor = SystemColors.ControlText;
            btnDanhMuc.Location = new Point(0, 88);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(10, 0, 0, 0);
            btnDanhMuc.Size = new Size(188, 38);
            btnDanhMuc.TabIndex = 26;
            btnDanhMuc.Text = "Danh Mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // panelLogoUTH
            // 
            panelLogoUTH.BackColor = Color.White;
            panelLogoUTH.Controls.Add(pictureBox1);
            panelLogoUTH.Dock = DockStyle.Top;
            panelLogoUTH.Location = new Point(0, 0);
            panelLogoUTH.Name = "panelLogoUTH";
            panelLogoUTH.Size = new Size(188, 88);
            panelLogoUTH.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(190, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1079, 614);
            panelMain.TabIndex = 1;
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 614);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
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
        private Panel panelMenu;
        private Panel panel2;
        private Button button10;
        private Button button11;
        private Button button12;
        private Panel panelDanhMucCon;
        private Button btnQuanLySach;
        private Button btnNXB;
        private Button btnTheLoaiSach;
        private Button btnTacGia;
        private Button btnNhanVien;
        private Button btnDocGia;
        private Button btnDanhMuc;
        private Panel panelLogoUTH;
        private Panel panelOut;
        private Button btnThoat;
        private Button btnDangXuat;
        private TextBox txtPhanQuyen;
        private Button btnBaoCao;
        private Panel panelMuonSachCon;
        private Button btnTraSach;
        private Button btnMuonSach;
        private Button btnMTSach;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}