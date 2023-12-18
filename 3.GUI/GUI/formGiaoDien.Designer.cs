
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Panel();
            btnAboutUs = new Button();
            btnThoat = new Button();
            btnDangXuat = new Button();
            btnChart = new Button();
            btnBaoCao = new Button();
            panelMuonSachCon = new Panel();
            btnTraSach = new Button();
            btnMuonSach = new Button();
            btnMTSach = new Button();
            panelDanhMucCon = new Panel();
            btnNXB = new Button();
            btnTheLoaiSach = new Button();
            btnTacGia = new Button();
            btnNhanVien = new Button();
            btnQuanLySach = new Button();
            btnDocGia = new Button();
            btnDanhMuc = new Button();
            panelLogoUTH = new Panel();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panelChild = new Guna.UI2.WinForms.Guna2Panel();
            panelMenu.SuspendLayout();
            panelMuonSachCon.SuspendLayout();
            panelDanhMucCon.SuspendLayout();
            panelLogoUTH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnThoat);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnAboutUs);

            panelMenu.Controls.Add(btnChart);
            panelMenu.Controls.Add(btnBaoCao);
            panelMenu.Controls.Add(panelMuonSachCon);
            panelMenu.Controls.Add(btnMTSach);
            panelMenu.Controls.Add(panelDanhMucCon);
            panelMenu.Controls.Add(btnDanhMuc);
            panelMenu.Controls.Add(panelLogoUTH);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(210, 614);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Dock = DockStyle.Top;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAboutUs.ForeColor = SystemColors.ControlLightLight;
            btnAboutUs.Location = new Point(0, 740);
            btnAboutUs.Margin = new Padding(3, 2, 3, 2);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Padding = new Padding(9, 0, 0, 0);
            btnAboutUs.Size = new Size(238, 41);
            btnAboutUs.TabIndex = 34;
            btnAboutUs.Text = "ABOUT US";
            btnAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.UseVisualStyleBackColor = true;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Top;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(0, 524);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(8, 0, 0, 0);
            btnThoat.Size = new Size(208, 31);
            btnThoat.TabIndex = 34;
            btnThoat.Text = "THOÁT";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = SystemColors.ControlLightLight;
            btnDangXuat.Location = new Point(0, 493);
            btnDangXuat.Margin = new Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(8, 0, 0, 0);
            btnDangXuat.Size = new Size(208, 31);
            btnDangXuat.TabIndex = 33;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnChart
            // 
            btnChart.Dock = DockStyle.Top;
            btnChart.FlatAppearance.BorderSize = 0;
            btnChart.FlatStyle = FlatStyle.Flat;
            btnChart.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChart.ForeColor = SystemColors.ControlLightLight;
            btnChart.Location = new Point(0, 462);
            btnChart.Margin = new Padding(3, 2, 3, 2);
            btnChart.Name = "btnChart";
            btnChart.Padding = new Padding(8, 0, 0, 0);
            btnChart.Size = new Size(208, 31);
            btnChart.TabIndex = 35;
            btnChart.Text = "BIỂU ĐỒ";
            btnChart.TextAlign = ContentAlignment.MiddleLeft;
            btnChart.UseVisualStyleBackColor = true;
            btnChart.Click += btnChart_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaoCao.ForeColor = SystemColors.ControlLightLight;
            btnBaoCao.Location = new Point(0, 431);
            btnBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(8, 0, 0, 0);
            btnBaoCao.Size = new Size(208, 31);
            btnBaoCao.TabIndex = 32;
            btnBaoCao.Text = "BÁO CÁO";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // panelMuonSachCon
            // 
            panelMuonSachCon.BackColor = Color.FromArgb(35, 32, 39);
            panelMuonSachCon.Controls.Add(btnTraSach);
            panelMuonSachCon.Controls.Add(btnMuonSach);
            panelMuonSachCon.Dock = DockStyle.Top;
            panelMuonSachCon.Location = new Point(0, 361);
            panelMuonSachCon.Margin = new Padding(3, 2, 3, 2);
            panelMuonSachCon.Name = "panelMuonSachCon";
            panelMuonSachCon.Size = new Size(208, 70);
            panelMuonSachCon.TabIndex = 31;
            // 
            // btnTraSach
            // 
            btnTraSach.Dock = DockStyle.Top;
            btnTraSach.FlatAppearance.BorderSize = 0;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraSach.ForeColor = SystemColors.Info;
            btnTraSach.Location = new Point(0, 33);
            btnTraSach.Margin = new Padding(3, 2, 3, 2);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Padding = new Padding(26, 0, 0, 0);
            btnTraSach.Size = new Size(208, 28);
            btnTraSach.TabIndex = 18;
            btnTraSach.Text = "Trả sách";
            btnTraSach.TextAlign = ContentAlignment.MiddleLeft;
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Dock = DockStyle.Top;
            btnMuonSach.FlatAppearance.BorderSize = 0;
            btnMuonSach.FlatStyle = FlatStyle.Flat;
            btnMuonSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMuonSach.ForeColor = SystemColors.ButtonHighlight;
            btnMuonSach.Location = new Point(0, 0);
            btnMuonSach.Margin = new Padding(3, 2, 3, 2);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Padding = new Padding(26, 0, 0, 0);
            btnMuonSach.Size = new Size(208, 33);
            btnMuonSach.TabIndex = 17;
            btnMuonSach.Text = "Mượn sách";
            btnMuonSach.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonSach.UseVisualStyleBackColor = false;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // btnMTSach
            // 
            btnMTSach.Dock = DockStyle.Top;
            btnMTSach.FlatAppearance.BorderSize = 0;
            btnMTSach.FlatStyle = FlatStyle.Flat;
            btnMTSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMTSach.ForeColor = SystemColors.ControlLightLight;
            btnMTSach.Location = new Point(0, 330);
            btnMTSach.Margin = new Padding(3, 2, 3, 2);
            btnMTSach.Name = "btnMTSach";
            btnMTSach.Padding = new Padding(8, 0, 0, 0);
            btnMTSach.Size = new Size(208, 31);
            btnMTSach.TabIndex = 30;
            btnMTSach.Text = "MƯỢN TRẢ SÁCH";
            btnMTSach.TextAlign = ContentAlignment.MiddleLeft;
            btnMTSach.UseVisualStyleBackColor = true;
            btnMTSach.Click += btnMTSach_Click;
            // 
            // panelDanhMucCon
            // 
            panelDanhMucCon.BackColor = Color.FromArgb(35, 32, 39);
            panelDanhMucCon.Controls.Add(btnNXB);
            panelDanhMucCon.Controls.Add(btnTheLoaiSach);
            panelDanhMucCon.Controls.Add(btnTacGia);
            panelDanhMucCon.Controls.Add(btnNhanVien);
            panelDanhMucCon.Controls.Add(btnQuanLySach);
            panelDanhMucCon.Controls.Add(btnDocGia);
            panelDanhMucCon.Dock = DockStyle.Top;
            panelDanhMucCon.Location = new Point(0, 147);
            panelDanhMucCon.Margin = new Padding(3, 2, 3, 2);
            panelDanhMucCon.Name = "panelDanhMucCon";
            panelDanhMucCon.Size = new Size(208, 183);
            panelDanhMucCon.TabIndex = 29;
            // 
            // btnNXB
            // 
            btnNXB.Dock = DockStyle.Top;
            btnNXB.FlatAppearance.BorderSize = 0;
            btnNXB.FlatStyle = FlatStyle.Flat;
            btnNXB.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNXB.ForeColor = SystemColors.Info;
            btnNXB.Location = new Point(0, 140);
            btnNXB.Margin = new Padding(3, 2, 3, 2);
            btnNXB.Name = "btnNXB";
            btnNXB.Padding = new Padding(26, 0, 0, 0);
            btnNXB.Size = new Size(208, 28);
            btnNXB.TabIndex = 15;
            btnNXB.Text = "Nhà xuất bản";
            btnNXB.TextAlign = ContentAlignment.MiddleLeft;
            btnNXB.UseVisualStyleBackColor = false;
            btnNXB.Click += btnNXB_Click;
            // 
            // btnTheLoaiSach
            // 
            btnTheLoaiSach.Dock = DockStyle.Top;
            btnTheLoaiSach.FlatAppearance.BorderSize = 0;
            btnTheLoaiSach.FlatStyle = FlatStyle.Flat;
            btnTheLoaiSach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTheLoaiSach.ForeColor = SystemColors.Info;
            btnTheLoaiSach.Location = new Point(0, 112);
            btnTheLoaiSach.Margin = new Padding(3, 2, 3, 2);
            btnTheLoaiSach.Name = "btnTheLoaiSach";
            btnTheLoaiSach.Padding = new Padding(26, 0, 0, 0);
            btnTheLoaiSach.Size = new Size(208, 28);
            btnTheLoaiSach.TabIndex = 14;
            btnTheLoaiSach.Text = "Thể loại sách";
            btnTheLoaiSach.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoaiSach.UseVisualStyleBackColor = false;
            btnTheLoaiSach.Click += btnTheLoaiSach_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.Dock = DockStyle.Top;
            btnTacGia.FlatAppearance.BorderSize = 0;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTacGia.ForeColor = SystemColors.Info;
            btnTacGia.Location = new Point(0, 84);
            btnTacGia.Margin = new Padding(3, 2, 3, 2);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Padding = new Padding(26, 0, 0, 0);
            btnTacGia.Size = new Size(208, 28);
            btnTacGia.TabIndex = 10;
            btnTacGia.Text = "Quản lý tác giả";
            btnTacGia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacGia.UseVisualStyleBackColor = false;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhanVien.ForeColor = SystemColors.Info;
            btnNhanVien.Location = new Point(0, 56);
            btnNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(26, 0, 0, 0);
            btnNhanVien.Size = new Size(208, 28);
            btnNhanVien.TabIndex = 12;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.Dock = DockStyle.Top;
            btnQuanLySach.FlatAppearance.BorderSize = 0;
            btnQuanLySach.FlatStyle = FlatStyle.Flat;
            btnQuanLySach.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLySach.ForeColor = SystemColors.Info;
            btnQuanLySach.Location = new Point(0, 28);
            btnQuanLySach.Margin = new Padding(3, 2, 3, 2);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Padding = new Padding(26, 0, 0, 0);
            btnQuanLySach.Size = new Size(208, 28);
            btnQuanLySach.TabIndex = 9;
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLySach.UseVisualStyleBackColor = false;
            btnQuanLySach.Click += btnQuanLySach_Click;
            // 
            // btnDocGia
            // 
            btnDocGia.Dock = DockStyle.Top;
            btnDocGia.FlatAppearance.BorderSize = 0;
            btnDocGia.FlatStyle = FlatStyle.Flat;
            btnDocGia.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDocGia.ForeColor = SystemColors.Info;
            btnDocGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocGia.Location = new Point(0, 0);
            btnDocGia.Margin = new Padding(3, 2, 3, 2);
            btnDocGia.Name = "btnDocGia";
            btnDocGia.Padding = new Padding(26, 0, 0, 0);
            btnDocGia.Size = new Size(208, 28);
            btnDocGia.TabIndex = 11;
            btnDocGia.Text = "Quản lý độc giả";
            btnDocGia.TextAlign = ContentAlignment.MiddleLeft;
            btnDocGia.UseVisualStyleBackColor = false;
            btnDocGia.Click += button5_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Dock = DockStyle.Top;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhMuc.ForeColor = SystemColors.ControlLightLight;
            btnDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.Location = new Point(0, 106);
            btnDanhMuc.Margin = new Padding(3, 2, 3, 2);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(9, 0, 0, 0);
            btnDanhMuc.Size = new Size(208, 41);
            btnDanhMuc.TabIndex = 28;
            btnDanhMuc.Text = "DANH MỤC";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // panelLogoUTH
            // 
            panelLogoUTH.Controls.Add(pictureBox1);
            panelLogoUTH.Dock = DockStyle.Top;
            panelLogoUTH.Location = new Point(0, 0);
            panelLogoUTH.Margin = new Padding(3, 2, 3, 2);
            panelLogoUTH.Name = "panelLogoUTH";
            panelLogoUTH.Size = new Size(208, 106);
            panelLogoUTH.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelChild);
            panelMain.Controls.Add(panelMenu);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1269, 614);
            panelMain.TabIndex = 1;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // panelChild
            // 
            panelChild.CustomizableEdges = customizableEdges3;
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(210, 0);
            panelChild.Margin = new Padding(3, 2, 3, 2);
            panelChild.Name = "panelChild";
            panelChild.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelChild.Size = new Size(1210, 819);
            panelChild.TabIndex = 1;
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 614);
            Controls.Add(panelMain);
            Margin = new Padding(4);
            Name = "formGiaoDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao diện";
            FormClosing += formGiaoDien_FormClosing;
            FormClosed += formGiaoDien_FormClosed;
            Load += formGiaoDien_Load;
            panelMenu.ResumeLayout(false);
            panelMuonSachCon.ResumeLayout(false);
            panelDanhMucCon.ResumeLayout(false);
            panelLogoUTH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;

        private Panel panel2;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnQuanLySach;
        private Button btnNXB;
        private Button btnTheLoaiSach;
        private Button btnTacGia;
        private Button btnNhanVien;
        private Button btnDocGia;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelLogoUTH;
        private Panel panelDanhMucCon;
        private Button btnDanhMuc;
        private Panel panelMuonSachCon;
        private Button btnMTSach;
        private Button btnTraSach;
        private Button btnMuonSach;
        private Button btnBaoCao;

        private Button btnThoat;
        private Button btnDangXuat;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnChart;
        private Button btnAboutUs;
        private Guna.UI2.WinForms.Guna2Panel panelChild;
    }
}