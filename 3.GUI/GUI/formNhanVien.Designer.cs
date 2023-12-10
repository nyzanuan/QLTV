
using _3.GUI.Helper;

namespace QLTV
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
            dgvNhanVien = new DataGridView();
            panelTop = new Panel();
            label8 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            txtMatKhau = new TextBox();
            label11 = new Label();
            txtTenNhanVien = new TextBox();
            label10 = new Label();
            btnChonAnh = new Button();
            ptbChonAnh = new RoundedPictureBox();
            label4 = new Label();
            cmbVaiTro = new ComboBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtMaNhanVien = new TextBox();
            txtSoDienThoai = new TextBox();
            cmbGioiTinh = new ComboBox();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panelMid = new Panel();
            cmbSearchRole = new ComboBox();
            label9 = new Label();
            txtSearch = new TextBox();
            label7 = new Label();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            panelMid.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ActiveCaption;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Margin = new Padding(4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvNhanVien.RowTemplate.Height = 100;
            dgvNhanVien.Size = new Size(1068, 287);
            dgvNhanVien.TabIndex = 25;
            dgvNhanVien.CellClick += dgvNhanVien_CellContentClick;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(375, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(400, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin nhân viên";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(687, 162);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 47;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(592, 162);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 46;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(319, 162);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 33);
            btnThem.TabIndex = 43;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(501, 162);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
            btnXoa.TabIndex = 45;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(409, 162);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 33);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Enabled = false;
            txtMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(252, 113);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(212, 26);
            txtMatKhau.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(151, 118);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 19);
            label11.TabIndex = 52;
            label11.Text = "Mật khẩu";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTenNhanVien.Enabled = false;
            txtTenNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhanVien.Location = new Point(252, 48);
            txtTenNhanVien.Margin = new Padding(4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(212, 26);
            txtTenNhanVien.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(151, 53);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(101, 19);
            label10.TabIndex = 50;
            label10.Text = "Tên nhân viên";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(29, 108);
            btnChonAnh.Margin = new Padding(4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(80, 25);
            btnChonAnh.TabIndex = 49;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(28, 19);
            ptbChonAnh.Margin = new Padding(3, 2, 3, 2);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(95, 78);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 48;
            ptbChonAnh.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(496, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 41;
            label4.Text = "Vai trò";
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaiTro.Enabled = false;
            cmbVaiTro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVaiTro.FormattingEnabled = true;
            cmbVaiTro.Location = new Point(601, 111);
            cmbVaiTro.Margin = new Padding(4);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.Size = new Size(175, 27);
            cmbVaiTro.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(496, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 40;
            label2.Text = "Email";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(252, 82);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(212, 26);
            txtUserName.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(151, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 31;
            label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(151, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 32;
            label3.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(495, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 33;
            label5.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(601, 43);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 26);
            txtEmail.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(495, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 34;
            label6.Text = "Giới tính";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(252, 14);
            txtMaNhanVien.Margin = new Padding(4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(212, 26);
            txtMaNhanVien.TabIndex = 35;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Enabled = false;
            txtSoDienThoai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(601, 13);
            txtSoDienThoai.Margin = new Padding(4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(175, 26);
            txtSoDienThoai.TabIndex = 38;
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.Enabled = false;
            cmbGioiTinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Location = new Point(601, 75);
            cmbGioiTinh.Margin = new Padding(4);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(175, 27);
            cmbGioiTinh.TabIndex = 37;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(521, 296);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 48;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(686, 295);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 47;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(599, 295);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 46;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(337, 295);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 44;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(425, 295);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 45;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(cmbSearchRole);
            panelMid.Controls.Add(txtMatKhau);
            panelMid.Controls.Add(label9);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(label11);
            panelMid.Controls.Add(txtSearch);
            panelMid.Controls.Add(label7);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(txtTenNhanVien);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(txtUserName);
            panelMid.Controls.Add(btnThem);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(label10);
            panelMid.Controls.Add(txtMaNhanVien);
            panelMid.Controls.Add(btnChonAnh);
            panelMid.Controls.Add(cmbGioiTinh);
            panelMid.Controls.Add(ptbChonAnh);
            panelMid.Controls.Add(txtSoDienThoai);
            panelMid.Controls.Add(label4);
            panelMid.Controls.Add(label6);
            panelMid.Controls.Add(cmbVaiTro);
            panelMid.Controls.Add(txtEmail);
            panelMid.Controls.Add(label2);
            panelMid.Controls.Add(label5);
            panelMid.Controls.Add(label1);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 204);
            panelMid.TabIndex = 49;
            // 
            // cmbSearchRole
            // 
            cmbSearchRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchRole.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSearchRole.FormattingEnabled = true;
            cmbSearchRole.Location = new Point(868, 44);
            cmbSearchRole.Margin = new Padding(4);
            cmbSearchRole.Name = "cmbSearchRole";
            cmbSearchRole.Size = new Size(180, 27);
            cmbSearchRole.TabIndex = 48;
            cmbSearchRole.SelectedIndexChanged += cmbSearchRole_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(795, 52);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 19);
            label9.TabIndex = 39;
            label9.Text = "Vai trò";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(868, 8);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 26);
            txtSearch.TabIndex = 38;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(795, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 37;
            label7.Text = "Tìm kiếm";
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvNhanVien);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 246);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 324);
            panelBot.TabIndex = 50;
            // 
            // formNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(4);
            Name = "formNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += formNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            panelMid.ResumeLayout(false);
            panelMid.PerformLayout();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Panel panelTop;
        private Label label8;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private Label label4;
        private ComboBox cmbVaiTro;
        private Label label2;
        private TextBox txtUserName;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtMaNhanVien;
        private TextBox txtSoDienThoai;
        private ComboBox cmbGioiTinh;
        private RoundedPictureBox ptbChonAnh;
        private Button btnChonAnh;
        private TextBox txtTenNhanVien;
        private Label label10;
        private TextBox txtMatKhau;
        private Label label11;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private Panel panelMid;
        private ComboBox cmbSearchRole;
        private Label label9;
        private TextBox txtSearch;
        private Label label7;
        private Panel panelBot;
    }
}