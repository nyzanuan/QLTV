using _3.GUI.Helper;

namespace _3.GUI.GUI
{
    partial class formNhanVien
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
            panelHeader = new Panel();
            labelHeader = new Label();
            panelBody = new Panel();
            panelBodyButton = new Panel();
            btnThem = new Button();
            btnUpdate = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            panelBodyInput = new Panel();
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxBodyInput = new GroupBox();
            tableLayoutPanelAllInput = new TableLayoutPanel();
            cmbVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSoDienThoai = new TextBox();
            labelMaNV = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaNhanVien = new TextBox();
            cmbGioiTinh = new ComboBox();
            tableLayoutBodyImage = new TableLayoutPanel();
            panelHinhAnh = new Panel();
            btnChonAnh = new Button();
            ptbChonAnh = new RoundedPictureBox();
            groupBoxBodySearch = new GroupBox();
            tableLayoutPanelSearch = new TableLayoutPanel();
            label9 = new Label();
            txtSearch = new TextBox();
            cmbSearchRole = new ComboBox();
            label8 = new Label();
            dgvNhanVien = new DataGridView();
            tableLayoutPanelFooter = new TableLayoutPanel();
            panelFooter = new Panel();
            btnLastPage = new Button();
            btnNextPage = new Button();
            txtNumberPage = new TextBox();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            panelBodyButton.SuspendLayout();
            panelBodyInput.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxBodyInput.SuspendLayout();
            tableLayoutPanelAllInput.SuspendLayout();
            tableLayoutBodyImage.SuspendLayout();
            panelHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            groupBoxBodySearch.SuspendLayout();
            tableLayoutPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tableLayoutPanelFooter.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1323, 88);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.None;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.Location = new Point(478, 7);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(332, 35);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(panelBodyButton);
            panelBody.Controls.Add(panelBodyInput);
            panelBody.Dock = DockStyle.Top;
            panelBody.Location = new Point(0, 88);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1323, 496);
            panelBody.TabIndex = 1;
            // 
            // panelBodyButton
            // 
            panelBodyButton.Controls.Add(btnThem);
            panelBodyButton.Controls.Add(btnUpdate);
            panelBodyButton.Controls.Add(btnXoa);
            panelBodyButton.Controls.Add(btnHuy);
            panelBodyButton.Controls.Add(btnLuu);
            panelBodyButton.Dock = DockStyle.Top;
            panelBodyButton.Location = new Point(0, 372);
            panelBodyButton.Name = "panelBodyButton";
            panelBodyButton.Size = new Size(1323, 104);
            panelBodyButton.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(377, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 36);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(486, 28);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(616, 28);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 36);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(845, 28);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 36);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(730, 28);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 36);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panelBodyInput
            // 
            panelBodyInput.Controls.Add(tableLayoutPanelMain);
            panelBodyInput.Dock = DockStyle.Top;
            panelBodyInput.Location = new Point(0, 0);
            panelBodyInput.Name = "panelBodyInput";
            panelBodyInput.Size = new Size(1323, 372);
            panelBodyInput.TabIndex = 9;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.Controls.Add(groupBoxBodyInput, 0, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxBodySearch, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1323, 372);
            tableLayoutPanelMain.TabIndex = 10;
            // 
            // groupBoxBodyInput
            // 
            groupBoxBodyInput.Controls.Add(tableLayoutPanelAllInput);
            groupBoxBodyInput.Controls.Add(tableLayoutBodyImage);
            groupBoxBodyInput.Dock = DockStyle.Fill;
            groupBoxBodyInput.Location = new Point(3, 3);
            groupBoxBodyInput.Name = "groupBoxBodyInput";
            groupBoxBodyInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxBodyInput.Size = new Size(920, 366);
            groupBoxBodyInput.TabIndex = 8;
            groupBoxBodyInput.TabStop = false;
            groupBoxBodyInput.Text = "Khu vực nhập liệu";
            // 
            // tableLayoutPanelAllInput
            // 
            tableLayoutPanelAllInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAllInput.ColumnCount = 4;
            tableLayoutPanelAllInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAllInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelAllInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAllInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelAllInput.Controls.Add(cmbVaiTro, 3, 3);
            tableLayoutPanelAllInput.Controls.Add(txtMatKhau, 1, 3);
            tableLayoutPanelAllInput.Controls.Add(txtUserName, 1, 2);
            tableLayoutPanelAllInput.Controls.Add(txtEmail, 3, 1);
            tableLayoutPanelAllInput.Controls.Add(txtTenNhanVien, 1, 1);
            tableLayoutPanelAllInput.Controls.Add(txtSoDienThoai, 3, 0);
            tableLayoutPanelAllInput.Controls.Add(labelMaNV, 0, 0);
            tableLayoutPanelAllInput.Controls.Add(label1, 2, 0);
            tableLayoutPanelAllInput.Controls.Add(label2, 0, 1);
            tableLayoutPanelAllInput.Controls.Add(label3, 0, 2);
            tableLayoutPanelAllInput.Controls.Add(label4, 0, 3);
            tableLayoutPanelAllInput.Controls.Add(label5, 2, 1);
            tableLayoutPanelAllInput.Controls.Add(label6, 2, 2);
            tableLayoutPanelAllInput.Controls.Add(label7, 2, 3);
            tableLayoutPanelAllInput.Controls.Add(txtMaNhanVien, 1, 0);
            tableLayoutPanelAllInput.Controls.Add(cmbGioiTinh, 3, 2);
            tableLayoutPanelAllInput.Location = new Point(211, 23);
            tableLayoutPanelAllInput.Name = "tableLayoutPanelAllInput";
            tableLayoutPanelAllInput.RowCount = 4;
            tableLayoutPanelAllInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAllInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAllInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAllInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelAllInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanelAllInput.Size = new Size(703, 325);
            tableLayoutPanelAllInput.TabIndex = 1;
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbVaiTro.FormattingEnabled = true;
            cmbVaiTro.Location = new Point(468, 270);
            cmbVaiTro.Margin = new Padding(3, 4, 3, 4);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.Size = new Size(232, 28);
            cmbVaiTro.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(119, 258);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(232, 52);
            txtMatKhau.TabIndex = 14;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(119, 176);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(232, 52);
            txtUserName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(468, 95);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 52);
            txtEmail.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenNhanVien.Location = new Point(119, 95);
            txtTenNhanVien.Multiline = true;
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(232, 52);
            txtTenNhanVien.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoDienThoai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(468, 14);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(232, 52);
            txtSoDienThoai.TabIndex = 9;
            // 
            // labelMaNV
            // 
            labelMaNV.Anchor = AnchorStyles.None;
            labelMaNV.AutoSize = true;
            labelMaNV.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaNV.Location = new Point(4, 31);
            labelMaNV.Name = "labelMaNV";
            labelMaNV.Size = new Size(107, 19);
            labelMaNV.TabIndex = 0;
            labelMaNV.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 1;
            label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 193);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 274);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(382, 112);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(370, 193);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 6;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(380, 274);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 7;
            label7.Text = "Vai trò";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(119, 14);
            txtMaNhanVien.Multiline = true;
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(232, 52);
            txtMaNhanVien.TabIndex = 8;
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Location = new Point(468, 188);
            cmbGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(232, 28);
            cmbGioiTinh.TabIndex = 15;
            // 
            // tableLayoutBodyImage
            // 
            tableLayoutBodyImage.ColumnCount = 1;
            tableLayoutBodyImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBodyImage.Controls.Add(panelHinhAnh, 0, 0);
            tableLayoutBodyImage.Dock = DockStyle.Left;
            tableLayoutBodyImage.Location = new Point(3, 24);
            tableLayoutBodyImage.Name = "tableLayoutBodyImage";
            tableLayoutBodyImage.RowCount = 1;
            tableLayoutBodyImage.RowStyles.Add(new RowStyle(SizeType.Absolute, 207F));
            tableLayoutBodyImage.Size = new Size(202, 338);
            tableLayoutBodyImage.TabIndex = 0;
            // 
            // panelHinhAnh
            // 
            panelHinhAnh.Anchor = AnchorStyles.None;
            panelHinhAnh.Controls.Add(btnChonAnh);
            panelHinhAnh.Controls.Add(ptbChonAnh);
            panelHinhAnh.Location = new Point(22, 54);
            panelHinhAnh.Name = "panelHinhAnh";
            panelHinhAnh.Size = new Size(158, 230);
            panelHinhAnh.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Anchor = AnchorStyles.None;
            btnChonAnh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(30, 155);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 35);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.Anchor = AnchorStyles.None;
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(13, 20);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(131, 129);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 7;
            ptbChonAnh.TabStop = false;
            // 
            // groupBoxBodySearch
            // 
            groupBoxBodySearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBodySearch.Controls.Add(tableLayoutPanelSearch);
            groupBoxBodySearch.Location = new Point(929, 4);
            groupBoxBodySearch.Margin = new Padding(3, 4, 3, 4);
            groupBoxBodySearch.Name = "groupBoxBodySearch";
            groupBoxBodySearch.Padding = new Padding(3, 4, 3, 4);
            groupBoxBodySearch.Size = new Size(391, 336);
            groupBoxBodySearch.TabIndex = 9;
            groupBoxBodySearch.TabStop = false;
            groupBoxBodySearch.Text = "Khu vực tìm kiếm";
            // 
            // tableLayoutPanelSearch
            // 
            tableLayoutPanelSearch.ColumnCount = 1;
            tableLayoutPanelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSearch.Controls.Add(label9, 0, 2);
            tableLayoutPanelSearch.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanelSearch.Controls.Add(cmbSearchRole, 0, 3);
            tableLayoutPanelSearch.Controls.Add(label8, 0, 0);
            tableLayoutPanelSearch.Dock = DockStyle.Fill;
            tableLayoutPanelSearch.Location = new Point(3, 24);
            tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
            tableLayoutPanelSearch.Padding = new Padding(10, 11, 10, 11);
            tableLayoutPanelSearch.RowCount = 4;
            tableLayoutPanelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelSearch.Size = new Size(385, 308);
            tableLayoutPanelSearch.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(112, 179);
            label9.Name = "label9";
            label9.Size = new Size(160, 19);
            label9.TabIndex = 2;
            label9.Text = "Chọn vai trò cần tìm";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(13, 85);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(359, 65);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbSearchRole
            // 
            cmbSearchRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbSearchRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchRole.FormattingEnabled = true;
            cmbSearchRole.Location = new Point(13, 227);
            cmbSearchRole.Name = "cmbSearchRole";
            cmbSearchRole.Size = new Size(359, 28);
            cmbSearchRole.TabIndex = 3;
            cmbSearchRole.SelectedIndexChanged += cmbSearchRole_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(126, 37);
            label8.Name = "label8";
            label8.Size = new Size(133, 19);
            label8.TabIndex = 0;
            label8.Text = "Nhập tên cần tìm";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 4);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 100;
            dgvNhanVien.Size = new Size(1317, 260);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellContentClick;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 1;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.Controls.Add(panelFooter, 0, 1);
            tableLayoutPanelFooter.Controls.Add(dgvNhanVien, 0, 0);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(0, 584);
            tableLayoutPanelFooter.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelFooter.Size = new Size(1323, 384);
            tableLayoutPanelFooter.TabIndex = 70;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(btnLastPage);
            panelFooter.Controls.Add(btnNextPage);
            panelFooter.Controls.Add(txtNumberPage);
            panelFooter.Controls.Add(btnFirstPage);
            panelFooter.Controls.Add(btnPrePage);
            panelFooter.Dock = DockStyle.Fill;
            panelFooter.Location = new Point(3, 272);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1317, 108);
            panelFooter.TabIndex = 71;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Bottom;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(825, 48);
            btnLastPage.Margin = new Padding(6, 7, 6, 7);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(104, 41);
            btnLastPage.TabIndex = 73;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(711, 48);
            btnNextPage.Margin = new Padding(6, 7, 6, 7);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(104, 41);
            btnNextPage.TabIndex = 72;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.Bottom;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(609, 49);
            txtNumberPage.Margin = new Padding(6, 7, 6, 7);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(85, 35);
            txtNumberPage.TabIndex = 74;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Bottom;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(369, 48);
            btnFirstPage.Margin = new Padding(6, 7, 6, 7);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(104, 41);
            btnFirstPage.TabIndex = 70;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.Bottom;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(483, 48);
            btnPrePage.Margin = new Padding(6, 7, 6, 7);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(104, 41);
            btnPrePage.TabIndex = 71;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // formNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 968);
            Controls.Add(tableLayoutPanelFooter);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Name = "formNhanVien";
            Text = "formNhanVien";
            Load += formNhanVien_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBodyButton.ResumeLayout(false);
            panelBodyInput.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxBodyInput.ResumeLayout(false);
            tableLayoutPanelAllInput.ResumeLayout(false);
            tableLayoutPanelAllInput.PerformLayout();
            tableLayoutBodyImage.ResumeLayout(false);
            panelHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            groupBoxBodySearch.ResumeLayout(false);
            tableLayoutPanelSearch.ResumeLayout(false);
            tableLayoutPanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tableLayoutPanelFooter.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelHeader;
        private Panel panelBody;
        private Panel panelBodyInput;
        private GroupBox groupBoxBodySearch;
        private GroupBox groupBoxBodyInput;
        private TableLayoutPanel tableLayoutBodyImage;
        private Button btnChonAnh;
        private Panel panelBodyButton;
        private Button btnThem;
        private Button btnUpdate;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnLuu;
        private RoundedPictureBox ptbChonAnh;
        private TableLayoutPanel tableLayoutPanelAllInput;
        private Label labelMaNV;
        private Label label1;
        private ComboBox cmbVaiTro;
        private TextBox txtMatKhau;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtTenNhanVien;
        private TextBox txtSoDienThoai;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaNhanVien;
        private ComboBox cmbGioiTinh;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelSearch;
        private Label label9;
        private Label label8;
        private TextBox txtSearch;
        private ComboBox cmbSearchRole;
        private DataGridView dgvNhanVien;
        private TableLayoutPanel tableLayoutPanelFooter;
        private Panel panelFooter;
        private Button btnLastPage;
        private Button btnNextPage;
        private TextBox txtNumberPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private Panel panelHinhAnh;
    }
}