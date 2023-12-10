namespace _3.GUI.GUI
{
    partial class formTaiKhoan
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
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cbVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtUserName = new TextBox();
            groupBox3 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            cbMaNhanVien = new ComboBox();
            label8 = new Label();
            dgvBaoCao = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(678, 780);
            txtNumberPage.Margin = new Padding(5, 5, 5, 5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 50;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(866, 779);
            btnLastPage.Margin = new Padding(5, 5, 5, 5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 49;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(767, 779);
            btnNextPage.Margin = new Padding(5, 5, 5, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 48;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(467, 779);
            btnFirstPage.Margin = new Padding(5, 5, 5, 5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 46;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(568, 779);
            btnPrePage.Margin = new Padding(5, 5, 5, 5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 47;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-11, -1);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 342);
            panel1.TabIndex = 44;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1000, -1);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(376, 65);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 28);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(144, 17);
            txtTimKiem.Margin = new Padding(5, 5, 5, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(195, 35);
            txtTimKiem.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbVaiTro);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbMaNhanVien);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1267, 260);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(846, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 27);
            label2.TabIndex = 41;
            label2.Text = "Vai trò";
            // 
            // cbVaiTro
            // 
            cbVaiTro.Enabled = false;
            cbVaiTro.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbVaiTro.FormattingEnabled = true;
            cbVaiTro.Location = new Point(946, 36);
            cbVaiTro.Margin = new Padding(5, 5, 5, 5);
            cbVaiTro.Name = "cbVaiTro";
            cbVaiTro.Size = new Size(170, 35);
            cbVaiTro.TabIndex = 40;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(517, 117);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(263, 35);
            txtMatKhau.TabIndex = 39;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(517, 36);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 35);
            txtUserName.TabIndex = 38;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Location = new Point(366, 164);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(622, 87);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(507, 31);
            btnHuy.Margin = new Padding(5, 5, 5, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(384, 31);
            btnLuu.Margin = new Padding(5, 5, 5, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(16, 31);
            btnThem.Margin = new Padding(5, 5, 5, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(263, 31);
            btnXoa.Margin = new Padding(5, 5, 5, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(139, 31);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 47);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 21;
            label1.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(407, 48);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 22;
            label3.Text = "User name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(409, 128);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 23;
            label5.Text = "Mật khẩu";
            // 
            // cbMaNhanVien
            // 
            cbMaNhanVien.Enabled = false;
            cbMaNhanVien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaNhanVien.FormattingEnabled = true;
            cbMaNhanVien.Location = new Point(211, 36);
            cbMaNhanVien.Margin = new Padding(5, 5, 5, 5);
            cbMaNhanVien.Name = "cbMaNhanVien";
            cbMaNhanVien.Size = new Size(170, 35);
            cbMaNhanVien.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(505, 5);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(322, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý tài khoản";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(-14, 343);
            dgvBaoCao.Margin = new Padding(5, 5, 5, 5);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.ScrollBars = ScrollBars.Horizontal;
            dgvBaoCao.Size = new Size(1414, 419);
            dgvBaoCao.TabIndex = 53;
            // 
            // formTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 824);
            Controls.Add(dgvBaoCao);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formTaiKhoan";
            Text = "formTaiKhoan";
            Load += formTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private TextBox txt_name;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txt_phone;
        private Label label8;
        private DataGridView dgvBaoCao;
        private ComboBox cbMaNhanVien;
        private Label label2;
        private ComboBox cbVaiTro;
        private TextBox txtMatKhau;
        private TextBox txtUserName;
    }
}