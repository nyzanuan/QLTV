
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
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnThoat = new ToolStripMenuItem();
            danhMuc_toolStripMenu = new ToolStripMenuItem();
            quảnLýSáchToolStripMenuItem = new ToolStripMenuItem();
            menuTacGia = new ToolStripMenuItem();
            độcGiảToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            muonSach_StripMenu = new ToolStripMenuItem();
            mượnSáchToolStripMenuItem = new ToolStripMenuItem();
            timKiem_StripMenu = new ToolStripMenuItem();
            tìmSáchToolStripMenuItem1 = new ToolStripMenuItem();
            tìmKiếmĐộcGiảToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1403, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThong_StripMenu
            // 
            heThong_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem, btnThoat });
            heThong_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heThong_StripMenu.Name = "heThong_StripMenu";
            heThong_StripMenu.Size = new Size(114, 31);
            heThong_StripMenu.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = _3.GUI.Properties.Resources.account_25;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(197, 32);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(197, 32);
            thoátToolStripMenuItem.Text = "Tài khoản";
            // 
            // btnThoat
            // 
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(197, 32);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click_1;
            // 
            // danhMuc_toolStripMenu
            // 
            danhMuc_toolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSáchToolStripMenuItem, menuTacGia, độcGiảToolStripMenuItem, nhânViênToolStripMenuItem });
            danhMuc_toolStripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            danhMuc_toolStripMenu.Name = "danhMuc_toolStripMenu";
            danhMuc_toolStripMenu.Size = new Size(125, 31);
            danhMuc_toolStripMenu.Text = "Danh mục";
            danhMuc_toolStripMenu.Click += danhMuc_toolStripMenu_Click;
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            quảnLýSáchToolStripMenuItem.Size = new Size(274, 32);
            quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            quảnLýSáchToolStripMenuItem.Click += quảnLýSáchToolStripMenuItem_Click;
            // 
            // menuTacGia
            // 
            menuTacGia.Name = "menuTacGia";
            menuTacGia.Size = new Size(274, 32);
            menuTacGia.Text = "Quản lý tác giả";
            menuTacGia.Click += menuTacGia_Click;
            // 
            // độcGiảToolStripMenuItem
            // 
            độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            độcGiảToolStripMenuItem.Size = new Size(274, 32);
            độcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            độcGiảToolStripMenuItem.Click += độcGiảToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(274, 32);
            nhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // muonSach_StripMenu
            // 
            muonSach_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { mượnSáchToolStripMenuItem });
            muonSach_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            muonSach_StripMenu.Name = "muonSach_StripMenu";
            muonSach_StripMenu.Size = new Size(166, 31);
            muonSach_StripMenu.Text = "Mượn trả sách";
            // 
            // mượnSáchToolStripMenuItem
            // 
            mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            mượnSáchToolStripMenuItem.Size = new Size(206, 32);
            mượnSáchToolStripMenuItem.Text = "Mượn sách";
            // 
            // timKiem_StripMenu
            // 
            timKiem_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { tìmSáchToolStripMenuItem1, tìmKiếmĐộcGiảToolStripMenuItem });
            timKiem_StripMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            timKiem_StripMenu.Name = "timKiem_StripMenu";
            timKiem_StripMenu.Size = new Size(117, 31);
            timKiem_StripMenu.Text = "Tìm kiếm";
            // 
            // tìmSáchToolStripMenuItem1
            // 
            tìmSáchToolStripMenuItem1.Name = "tìmSáchToolStripMenuItem1";
            tìmSáchToolStripMenuItem1.Size = new Size(264, 32);
            tìmSáchToolStripMenuItem1.Text = "Tìm sách";
            // 
            // tìmKiếmĐộcGiảToolStripMenuItem
            // 
            tìmKiếmĐộcGiảToolStripMenuItem.Name = "tìmKiếmĐộcGiảToolStripMenuItem";
            tìmKiếmĐộcGiảToolStripMenuItem.Size = new Size(264, 32);
            tìmKiếmĐộcGiảToolStripMenuItem.Text = "Tìm kiếm độc giả";
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
            dateTimePicker1.Location = new Point(900, 5);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(485, 35);
            dateTimePicker1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(13, 55);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 845);
            panel1.TabIndex = 2;
            // 
            // formGiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 914);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
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
        private ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private ToolStripMenuItem menuTacGia;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem độcGiảToolStripMenuItem;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ToolStripMenuItem tìmSáchToolStripMenuItem1;
        private ToolStripMenuItem tìmKiếmĐộcGiảToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem btnThoat;
    }
}