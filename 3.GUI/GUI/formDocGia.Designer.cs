
namespace QLTV
{
    partial class formDocGia
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
            dgvDocGia = new DataGridView();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            COL_GENDER = new DataGridViewTextBoxColumn();
            COL_PHONE = new DataGridViewTextBoxColumn();
            COL_EMAIL = new DataGridViewTextBoxColumn();
            COL_CREATEAT = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            btnChonAnh = new Button();
            ptbChonAnh = new _3.GUI.Helper.RoundedPictureBox();
            groupBox3 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txt_email = new TextBox();
            label6 = new Label();
            txt_id = new TextBox();
            txt_phone = new TextBox();
            cBox_gioiTinh = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(687, 781);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 43;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(875, 780);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 42;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(776, 780);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 41;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(477, 780);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 39;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(577, 780);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 40;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME, COL_GENDER, COL_PHONE, COL_EMAIL, COL_CREATEAT });
            dgvDocGia.Location = new Point(-5, 344);
            dgvDocGia.Margin = new Padding(5);
            dgvDocGia.MultiSelect = false;
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1414, 419);
            dgvDocGia.TabIndex = 38;
            dgvDocGia.CellClick += dgvDocGia_CellClick;
            // 
            // COL_ID
            // 
            COL_ID.DataPropertyName = "CustomerId";
            COL_ID.HeaderText = "Mã";
            COL_ID.MinimumWidth = 20;
            COL_ID.Name = "COL_ID";
            COL_ID.ReadOnly = true;
            COL_ID.Width = 125;
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên";
            COL_NAME.MinimumWidth = 100;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            COL_NAME.Width = 200;
            // 
            // COL_GENDER
            // 
            COL_GENDER.DataPropertyName = "Gender";
            COL_GENDER.HeaderText = "Giới tính";
            COL_GENDER.MinimumWidth = 50;
            COL_GENDER.Name = "COL_GENDER";
            COL_GENDER.ReadOnly = true;
            COL_GENDER.Width = 125;
            // 
            // COL_PHONE
            // 
            COL_PHONE.DataPropertyName = "Phone";
            COL_PHONE.HeaderText = "Số điện thoại";
            COL_PHONE.MinimumWidth = 6;
            COL_PHONE.Name = "COL_PHONE";
            COL_PHONE.ReadOnly = true;
            COL_PHONE.Width = 125;
            // 
            // COL_EMAIL
            // 
            COL_EMAIL.DataPropertyName = "Email";
            COL_EMAIL.HeaderText = "Email";
            COL_EMAIL.MinimumWidth = 100;
            COL_EMAIL.Name = "COL_EMAIL";
            COL_EMAIL.ReadOnly = true;
            COL_EMAIL.Width = 250;
            // 
            // COL_CREATEAT
            // 
            COL_CREATEAT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COL_CREATEAT.DataPropertyName = "CreateAt";
            COL_CREATEAT.HeaderText = "Ngày đăng ký";
            COL_CREATEAT.MinimumWidth = 6;
            COL_CREATEAT.Name = "COL_CREATEAT";
            COL_CREATEAT.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 342);
            panel1.TabIndex = 37;
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
            txtTimKiem.Margin = new Padding(5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(195, 35);
            txtTimKiem.TabIndex = 37;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(ptbChonAnh);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(cBox_gioiTinh);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1267, 260);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Enabled = false;
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(62, 188);
            btnChonAnh.Margin = new Padding(5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(91, 44);
            btnChonAnh.TabIndex = 53;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(36, 34);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(145, 133);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 52;
            ptbChonAnh.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Location = new Point(345, 164);
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
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(384, 31);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(16, 31);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(263, 31);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(139, 31);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 116);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 36;
            label2.Text = "Email";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(671, 37);
            txt_name.Margin = new Padding(5);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(263, 35);
            txt_name.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 21;
            label1.Text = "Mã độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(539, 40);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 22;
            label3.Text = "Tên độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(189, 116);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 27);
            label5.TabIndex = 23;
            label5.Text = "Số điện thoại";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(671, 107);
            txt_email.Margin = new Padding(5);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(263, 35);
            txt_email.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(975, 43);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 27);
            label6.TabIndex = 24;
            label6.Text = "Giới tính";
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(315, 37);
            txt_id.Margin = new Padding(5);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(195, 35);
            txt_id.TabIndex = 25;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(315, 107);
            txt_phone.Margin = new Padding(5);
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            txt_phone.Size = new Size(195, 35);
            txt_phone.TabIndex = 28;
            // 
            // cBox_gioiTinh
            // 
            cBox_gioiTinh.Enabled = false;
            cBox_gioiTinh.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_gioiTinh.FormattingEnabled = true;
            cBox_gioiTinh.Location = new Point(1082, 35);
            cBox_gioiTinh.Margin = new Padding(5);
            cBox_gioiTinh.Name = "cBox_gioiTinh";
            cBox_gioiTinh.Size = new Size(103, 35);
            cBox_gioiTinh.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(505, 5);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(444, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin độc giả";
            // 
            // formDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 824);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvDocGia);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "formDocGia";
            Text = "Độc giả";
            Load += formDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvDocGia;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private TextBox txt_name;
        private Label label1;
        private Label label3;
        private TextBox txt_id;
        private Label label8;
        private Label label2;
        private Label label5;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_phone;
        private ComboBox cBox_gioiTinh;
        private GroupBox groupBox3;
        private Button btnChonAnh;
        private _3.GUI.Helper.RoundedPictureBox ptbChonAnh;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewTextBoxColumn COL_GENDER;
        private DataGridViewTextBoxColumn COL_PHONE;
        private DataGridViewTextBoxColumn COL_EMAIL;
        private DataGridViewTextBoxColumn COL_CREATEAT;
    }
}