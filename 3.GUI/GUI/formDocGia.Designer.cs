
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
            dgvDocGia = new DataGridView();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_IMAGE = new DataGridViewImageColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            COL_GENDER = new DataGridViewTextBoxColumn();
            COL_PHONE = new DataGridViewTextBoxColumn();
            COL_EMAIL = new DataGridViewTextBoxColumn();
            COL_CREATEAT = new DataGridViewTextBoxColumn();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panelMid = new Panel();
            label6 = new Label();
            btnHuy = new Button();
            cBox_gioiTinh = new ComboBox();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnChonAnh = new Button();
            label2 = new Label();
            ptbChonAnh = new _3.GUI.Helper.RoundedPictureBox();
            txt_id = new TextBox();
            txt_email = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            txt_phone = new TextBox();
            label8 = new Label();
            txtTimKiem = new TextBox();
            label4 = new Label();
            panelTop = new Panel();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            panelTop.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.BackgroundColor = SystemColors.ActiveCaption;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_IMAGE, COL_NAME, COL_GENDER, COL_PHONE, COL_EMAIL, COL_CREATEAT });
            dgvDocGia.Dock = DockStyle.Top;
            dgvDocGia.GridColor = SystemColors.ActiveCaption;
            dgvDocGia.Location = new Point(0, 0);
            dgvDocGia.Margin = new Padding(4);
            dgvDocGia.MultiSelect = false;
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1063, 307);
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
            // COL_IMAGE
            // 
            COL_IMAGE.DataPropertyName = "Image";
            COL_IMAGE.HeaderText = "hình";
            COL_IMAGE.MinimumWidth = 6;
            COL_IMAGE.Name = "COL_IMAGE";
            COL_IMAGE.ReadOnly = true;
            COL_IMAGE.Width = 125;
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
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.Bottom;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(524, 323);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 55;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Bottom;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(689, 322);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 54;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(602, 322);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 53;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Bottom;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(340, 322);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 51;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.Bottom;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(428, 322);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 52;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(label6);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(cBox_gioiTinh);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(btnThem);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(btnChonAnh);
            panelMid.Controls.Add(label2);
            panelMid.Controls.Add(ptbChonAnh);
            panelMid.Controls.Add(txt_id);
            panelMid.Controls.Add(txt_email);
            panelMid.Controls.Add(txt_name);
            panelMid.Controls.Add(label1);
            panelMid.Controls.Add(label5);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(txt_phone);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 192);
            panelMid.TabIndex = 54;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(860, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 24;
            label6.Text = "Giới tính";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(752, 145);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 36);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cBox_gioiTinh
            // 
            cBox_gioiTinh.Anchor = AnchorStyles.None;
            cBox_gioiTinh.Enabled = false;
            cBox_gioiTinh.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_gioiTinh.FormattingEnabled = true;
            cBox_gioiTinh.Location = new Point(941, 16);
            cBox_gioiTinh.Margin = new Padding(4);
            cBox_gioiTinh.Name = "cBox_gioiTinh";
            cBox_gioiTinh.Size = new Size(81, 27);
            cBox_gioiTinh.TabIndex = 27;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(644, 146);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 33);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(322, 146);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 33);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(538, 146);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 33);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(430, 146);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 33);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Anchor = AnchorStyles.None;
            btnChonAnh.Enabled = false;
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(89, 131);
            btnChonAnh.Margin = new Padding(4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(80, 33);
            btnChonAnh.TabIndex = 53;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(513, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 36;
            label2.Text = "Email";
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.Anchor = AnchorStyles.None;
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(67, 13);
            ptbChonAnh.Margin = new Padding(3, 2, 3, 2);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(127, 100);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 52;
            ptbChonAnh.TabStop = false;
            // 
            // txt_id
            // 
            txt_id.Anchor = AnchorStyles.None;
            txt_id.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(327, 18);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(170, 27);
            txt_id.TabIndex = 25;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(618, 87);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(194, 27);
            txt_email.TabIndex = 29;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.None;
            txt_name.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(618, 16);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(194, 27);
            txt_name.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 21;
            label1.Text = "Mã độc giả";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(204, 95);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 23;
            label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(511, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 22;
            label3.Text = "Tên độc giả";
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(327, 84);
            txt_phone.Margin = new Padding(4);
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            txt_phone.Size = new Size(170, 27);
            txt_phone.TabIndex = 28;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(375, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(362, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin độc giả";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(882, 4);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(168, 29);
            txtTimKiem.TabIndex = 37;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(782, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            label4.Click += label4_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 37;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvDocGia);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 234);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 357);
            panelBot.TabIndex = 56;
            panelBot.Paint += panelBot_Paint;
            // 
            // formDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(4);
            Name = "formDocGia";
            Text = "Độc giả";
            Load += formDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            panelMid.ResumeLayout(false);
            panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDocGia;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewImageColumn COL_IMAGE;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewTextBoxColumn COL_GENDER;
        private DataGridViewTextBoxColumn COL_PHONE;
        private DataGridViewTextBoxColumn COL_EMAIL;
        private DataGridViewTextBoxColumn COL_CREATEAT;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private Panel panelMid;
        private Label label6;
        private Button btnHuy;
        private ComboBox cBox_gioiTinh;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnChonAnh;
        private Label label2;
        private _3.GUI.Helper.RoundedPictureBox ptbChonAnh;
        private TextBox txt_id;
        private TextBox txt_email;
        private TextBox txt_name;
        private Label label1;
        private Label label5;
        private Label label3;
        private TextBox txt_phone;
        private Label label8;
        private TextBox txtTimKiem;
        private Label label4;
        private Panel panelTop;
        private Panel panelBot;
    }
}