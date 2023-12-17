using _3.GUI.GUI.Component;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            cBox_gioiTinh = new ComboBox();
            label6 = new Label();
            btnChonAnh = new Button();
            label1 = new Label();
            txt_email = new TextBox();
            txt_name = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txt_phone = new TextBox();
            label3 = new Label();
            txt_id = new TextBox();
            ptbChonAnh = new PictureboxCustome();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            label8 = new Label();
            panelTop = new Panel();
            panel1 = new Panel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            panelMid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.BackgroundColor = SystemColors.ActiveCaption;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_IMAGE, COL_NAME, COL_GENDER, COL_PHONE, COL_EMAIL, COL_CREATEAT });
            dgvDocGia.GridColor = SystemColors.ActiveCaption;
            dgvDocGia.Location = new Point(0, 5);
            dgvDocGia.Margin = new Padding(5);
            dgvDocGia.MultiSelect = false;
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.RowTemplate.Height = 100;
            dgvDocGia.Size = new Size(1047, 271);
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
            // 
            // COL_IMAGE
            // 
            COL_IMAGE.DataPropertyName = "Image";
            COL_IMAGE.HeaderText = "Hình";
            COL_IMAGE.ImageLayout = DataGridViewImageCellLayout.Zoom;
            COL_IMAGE.MinimumWidth = 6;
            COL_IMAGE.Name = "COL_IMAGE";
            COL_IMAGE.ReadOnly = true;
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên";
            COL_NAME.MinimumWidth = 100;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            // 
            // COL_GENDER
            // 
            COL_GENDER.DataPropertyName = "Gender";
            COL_GENDER.HeaderText = "Giới tính";
            COL_GENDER.MinimumWidth = 50;
            COL_GENDER.Name = "COL_GENDER";
            COL_GENDER.ReadOnly = true;
            // 
            // COL_PHONE
            // 
            COL_PHONE.DataPropertyName = "Phone";
            COL_PHONE.HeaderText = "Số điện thoại";
            COL_PHONE.MinimumWidth = 6;
            COL_PHONE.Name = "COL_PHONE";
            COL_PHONE.ReadOnly = true;
            // 
            // COL_EMAIL
            // 
            COL_EMAIL.DataPropertyName = "Email";
            COL_EMAIL.HeaderText = "Email";
            COL_EMAIL.MinimumWidth = 100;
            COL_EMAIL.Name = "COL_EMAIL";
            COL_EMAIL.ReadOnly = true;
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
            txtNumberPage.Location = new Point(492, 289);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 55;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Bottom;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(680, 286);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 54;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(581, 286);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 53;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Bottom;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(282, 286);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 51;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.Bottom;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(382, 286);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 52;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(tableLayoutPanel1);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(btnThem);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 56);
            panelMid.Margin = new Padding(3, 4, 3, 4);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1051, 379);
            panelMid.TabIndex = 54;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999924F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.Controls.Add(cBox_gioiTinh, 6, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Controls.Add(btnChonAnh, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(txt_email, 4, 1);
            tableLayoutPanel1.Controls.Add(txt_name, 4, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_phone, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
            tableLayoutPanel1.Controls.Add(txt_id, 2, 0);
            tableLayoutPanel1.Controls.Add(ptbChonAnh, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1051, 291);
            tableLayoutPanel1.TabIndex = 66;
            // 
            // cBox_gioiTinh
            // 
            cBox_gioiTinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_gioiTinh.Enabled = false;
            cBox_gioiTinh.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_gioiTinh.ForeColor = SystemColors.MenuText;
            cBox_gioiTinh.FormattingEnabled = true;
            cBox_gioiTinh.Location = new Point(887, 55);
            cBox_gioiTinh.Margin = new Padding(5);
            cBox_gioiTinh.Name = "cBox_gioiTinh";
            cBox_gioiTinh.Size = new Size(159, 33);
            cBox_gioiTinh.TabIndex = 60;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(760, 60);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 57;
            label6.Text = "Giới tính";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Anchor = AnchorStyles.None;
            btnChonAnh.Enabled = false;
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(38, 196);
            btnChonAnh.Margin = new Padding(5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(91, 44);
            btnChonAnh.TabIndex = 65;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 54;
            label1.Text = "Mã độc giả";
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(593, 202);
            txt_email.Margin = new Padding(5);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(157, 32);
            txt_email.TabIndex = 62;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_name.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(593, 56);
            txt_name.Margin = new Padding(5);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(157, 32);
            txt_name.TabIndex = 59;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(466, 205);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 63;
            label2.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(172, 193);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 50);
            label5.TabIndex = 56;
            label5.Text = "Số điện thoại";
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_phone.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(299, 202);
            txt_phone.Margin = new Padding(5);
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            txt_phone.Size = new Size(157, 32);
            txt_phone.TabIndex = 61;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(466, 60);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 55;
            label3.Text = "Tên độc giả";
            // 
            // txt_id
            // 
            txt_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_id.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(299, 56);
            txt_id.Margin = new Padding(5);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(157, 32);
            txt_id.TabIndex = 58;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.Anchor = AnchorStyles.None;
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            ptbChonAnh.BorderColor = Color.RoyalBlue;
            ptbChonAnh.BorderColor2 = Color.HotPink;
            ptbChonAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ptbChonAnh.BorderSize = 2;
            ptbChonAnh.GradientAngle = 50F;
            ptbChonAnh.Location = new Point(23, 12);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(121, 121);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 66;
            ptbChonAnh.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(706, 313);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 48);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(583, 315);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(215, 315);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 44);
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
            btnXoa.Location = new Point(462, 315);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 44);
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
            btnUpdate.Location = new Point(338, 315);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(444, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin độc giả";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1051, 56);
            panelTop.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(553, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 11, 10, 0);
            panel1.Size = new Size(498, 56);
            panel1.TabIndex = 20;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoRoundedCorners = true;
            txtTimKiem.BorderRadius = 20;
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.IconLeft = _3.GUI.Properties.Resources._8666693_search_icon;
            txtTimKiem.Location = new Point(64, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(421, 42);
            txtTimKiem.TabIndex = 55;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panelBot
            // 
            panelBot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBot.Controls.Add(dgvDocGia);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Location = new Point(0, 443);
            panelBot.Margin = new Padding(3, 4, 3, 4);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1051, 347);
            panelBot.TabIndex = 56;
            panelBot.Paint += panelBot_Paint;
            // 
            // formDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 789);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(5);
            Name = "formDocGia";
            Text = "Độc giả";
            Load += formDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            panelMid.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDocGia;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private Panel panelMid;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private Label label8;
        private Panel panelTop;
        private Panel panelBot;
        private Panel panel1;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewImageColumn COL_IMAGE;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewTextBoxColumn COL_GENDER;
        private DataGridViewTextBoxColumn COL_PHONE;
        private DataGridViewTextBoxColumn COL_EMAIL;
        private DataGridViewTextBoxColumn COL_CREATEAT;
        private ComboBox cBox_gioiTinh;
        private Label label6;
        private Button btnChonAnh;
        private Label label1;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_name;
        private Label label5;
        private TextBox txt_id;
        private TextBox txt_phone;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureboxCustome ptbChonAnh;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}