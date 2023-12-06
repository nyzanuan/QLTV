
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            cmbSearchRole = new ComboBox();
            label9 = new Label();
            txtSearch = new TextBox();
            label7 = new Label();
            group = new GroupBox();
            txtMatKhau = new TextBox();
            label11 = new Label();
            txtTenNhanVien = new TextBox();
            label10 = new Label();
            btnChonAnh = new Button();
            btnHuy = new Button();
            ptbChonAnh = new RoundedPictureBox();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
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
            label8 = new Label();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ActiveCaption;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(20, 403);
            dgvNhanVien.Margin = new Padding(4, 5, 4, 5);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvNhanVien.RowTemplate.Height = 100;
            dgvNhanVien.Size = new Size(1370, 495);
            dgvNhanVien.TabIndex = 25;
            dgvNhanVien.CellClick += dgvNhanVien_CellContentClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(group);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(20, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 379);
            panel1.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbSearchRole);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(951, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 286);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khu vực tìm kiếm";
            // 
            // cmbSearchRole
            // 
            cmbSearchRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchRole.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSearchRole.FormattingEnabled = true;
            cmbSearchRole.Location = new Point(52, 183);
            cmbSearchRole.Margin = new Padding(4, 5, 4, 5);
            cmbSearchRole.Name = "cmbSearchRole";
            cmbSearchRole.Size = new Size(300, 30);
            cmbSearchRole.TabIndex = 48;
            cmbSearchRole.SelectedIndexChanged += cmbSearchRole_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 146);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 39;
            label9.Text = "Vai trò";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(52, 90);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 30);
            txtSearch.TabIndex = 38;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 59);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 37;
            label7.Text = "Tên nhân viên";
            // 
            // group
            // 
            group.Controls.Add(txtMatKhau);
            group.Controls.Add(label11);
            group.Controls.Add(txtTenNhanVien);
            group.Controls.Add(label10);
            group.Controls.Add(btnChonAnh);
            group.Controls.Add(btnHuy);
            group.Controls.Add(ptbChonAnh);
            group.Controls.Add(btnLuu);
            group.Controls.Add(btnThem);
            group.Controls.Add(btnXoa);
            group.Controls.Add(btnUpdate);
            group.Controls.Add(label4);
            group.Controls.Add(cmbVaiTro);
            group.Controls.Add(label2);
            group.Controls.Add(txtUserName);
            group.Controls.Add(label1);
            group.Controls.Add(label3);
            group.Controls.Add(label5);
            group.Controls.Add(txtEmail);
            group.Controls.Add(label6);
            group.Controls.Add(txtMaNhanVien);
            group.Controls.Add(txtSoDienThoai);
            group.Controls.Add(cmbGioiTinh);
            group.Location = new Point(3, 80);
            group.Name = "group";
            group.Size = new Size(927, 286);
            group.TabIndex = 20;
            group.TabStop = false;
            group.Text = "Khu vực chỉnh sửa";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Enabled = false;
            txtMatKhau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(278, 149);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(242, 30);
            txtMatKhau.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(140, 154);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 52;
            label11.Text = "Mật khẩu";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTenNhanVien.Enabled = false;
            txtTenNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhanVien.Location = new Point(278, 100);
            txtTenNhanVien.Margin = new Padding(4, 5, 4, 5);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(242, 30);
            txtTenNhanVien.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(140, 105);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 22);
            label10.TabIndex = 50;
            label10.Text = "Tên nhân viên";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(45, 146);
            btnChonAnh.Margin = new Padding(4, 5, 4, 5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(92, 33);
            btnChonAnh.TabIndex = 49;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(808, 216);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(92, 44);
            btnHuy.TabIndex = 47;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(28, 26);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(109, 104);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 48;
            ptbChonAnh.TabStop = false;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(708, 216);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(92, 44);
            btnLuu.TabIndex = 46;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(409, 216);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 44);
            btnThem.TabIndex = 43;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(609, 216);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 44);
            btnXoa.TabIndex = 45;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(509, 216);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 44);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(545, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 41;
            label4.Text = "Vai trò";
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVaiTro.Enabled = false;
            cmbVaiTro.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVaiTro.FormattingEnabled = true;
            cmbVaiTro.Location = new Point(668, 146);
            cmbVaiTro.Margin = new Padding(4, 5, 4, 5);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.Size = new Size(252, 30);
            cmbVaiTro.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(545, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 40;
            label2.Text = "Email";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(278, 59);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(242, 30);
            txtUserName.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 31;
            label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 32;
            label3.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(545, 19);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 33;
            label5.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(668, 56);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 30);
            txtEmail.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(545, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 34;
            label6.Text = "Giới tính";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(278, 17);
            txtMaNhanVien.Margin = new Padding(4, 5, 4, 5);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(242, 30);
            txtMaNhanVien.TabIndex = 35;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Enabled = false;
            txtSoDienThoai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(668, 16);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(252, 30);
            txtSoDienThoai.TabIndex = 38;
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.Enabled = false;
            cmbGioiTinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Location = new Point(668, 99);
            cmbGioiTinh.Margin = new Padding(4, 5, 4, 5);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(252, 30);
            cmbGioiTinh.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(483, 12);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(589, 53);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin nhân viên";
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(754, 926);
            txtNumberPage.Margin = new Padding(4, 5, 4, 5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 40);
            txtNumberPage.TabIndex = 36;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(937, 922);
            btnLastPage.Margin = new Padding(4, 5, 4, 5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(92, 44);
            btnLastPage.TabIndex = 35;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(837, 922);
            btnNextPage.Margin = new Padding(4, 5, 4, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(92, 44);
            btnNextPage.TabIndex = 34;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(538, 922);
            btnFirstPage.Margin = new Padding(4, 5, 4, 5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(92, 44);
            btnFirstPage.TabIndex = 32;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(638, 922);
            btnPrePage.Margin = new Padding(4, 5, 4, 5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(92, 44);
            btnPrePage.TabIndex = 33;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // formNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 985);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formNhanVien";
            Load += formNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            group.ResumeLayout(false);
            group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Panel panel1;
        private Label label8;
        private GroupBox group;
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
        private GroupBox groupBox2;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private ComboBox cmbSearchRole;
        private Label label9;
        private TextBox txtSearch;
        private Label label7;
        private RoundedPictureBox ptbChonAnh;
        private Button btnChonAnh;
        private TextBox txtTenNhanVien;
        private Label label10;
        private TextBox txtMatKhau;
        private Label label11;
    }
}