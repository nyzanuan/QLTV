
namespace QLTV
{
    partial class formQuanLySach
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
            dgvSach = new DataGridView();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            COL_TITLE = new DataGridViewTextBoxColumn();
            COL_TOTALCOPIES = new DataGridViewTextBoxColumn();
            COL_AVAILABLECOPIES = new DataGridViewTextBoxColumn();
            COL_BORROWEDCOPIES = new DataGridViewTextBoxColumn();
            COL_STATUS = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            cBox_Status = new ComboBox();
            label11 = new Label();
            txt_title = new TextBox();
            label10 = new Label();
            cBox_Publisher = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThemTacGia = new Button();
            btnChonAnh = new Button();
            ptbChonAnh = new PictureBox();
            cBox_Caterogy = new ComboBox();
            label5 = new Label();
            cBox_Author = new ComboBox();
            txt_book_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_quantity = new TextBox();
            label7 = new Label();
            txt_book_id = new TextBox();
            cBox_language = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME, COL_TITLE, COL_TOTALCOPIES, COL_AVAILABLECOPIES, COL_BORROWEDCOPIES, COL_STATUS });
            dgvSach.Location = new Point(-6, 408);
            dgvSach.Margin = new Padding(5, 4, 5, 4);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(1414, 342);
            dgvSach.TabIndex = 38;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // COL_ID
            // 
            COL_ID.DataPropertyName = "BookId";
            COL_ID.HeaderText = "Mã sách";
            COL_ID.MinimumWidth = 10;
            COL_ID.Name = "COL_ID";
            COL_ID.ReadOnly = true;
            COL_ID.Width = 125;
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên";
            COL_NAME.MinimumWidth = 50;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            COL_NAME.Width = 200;
            // 
            // COL_TITLE
            // 
            COL_TITLE.DataPropertyName = "Title";
            COL_TITLE.HeaderText = "Tiêu đề";
            COL_TITLE.MinimumWidth = 70;
            COL_TITLE.Name = "COL_TITLE";
            COL_TITLE.ReadOnly = true;
            COL_TITLE.Width = 200;
            // 
            // COL_TOTALCOPIES
            // 
            COL_TOTALCOPIES.DataPropertyName = "TotalCopies";
            COL_TOTALCOPIES.HeaderText = "Tổng số lượng";
            COL_TOTALCOPIES.MinimumWidth = 6;
            COL_TOTALCOPIES.Name = "COL_TOTALCOPIES";
            COL_TOTALCOPIES.ReadOnly = true;
            COL_TOTALCOPIES.Width = 150;
            // 
            // COL_AVAILABLECOPIES
            // 
            COL_AVAILABLECOPIES.DataPropertyName = "AvailableCopies";
            COL_AVAILABLECOPIES.HeaderText = "Tồn kho";
            COL_AVAILABLECOPIES.MinimumWidth = 6;
            COL_AVAILABLECOPIES.Name = "COL_AVAILABLECOPIES";
            COL_AVAILABLECOPIES.ReadOnly = true;
            COL_AVAILABLECOPIES.Width = 125;
            // 
            // COL_BORROWEDCOPIES
            // 
            COL_BORROWEDCOPIES.DataPropertyName = "BorrowedCopies";
            COL_BORROWEDCOPIES.HeaderText = "Đã mượn";
            COL_BORROWEDCOPIES.MinimumWidth = 6;
            COL_BORROWEDCOPIES.Name = "COL_BORROWEDCOPIES";
            COL_BORROWEDCOPIES.ReadOnly = true;
            COL_BORROWEDCOPIES.Width = 125;
            // 
            // COL_STATUS
            // 
            COL_STATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COL_STATUS.DataPropertyName = "Status";
            COL_STATUS.HeaderText = "Trạng thái";
            COL_STATUS.MinimumWidth = 6;
            COL_STATUS.Name = "COL_STATUS";
            COL_STATUS.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 400);
            panel1.TabIndex = 37;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(969, -1);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(413, 68);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 31);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 18;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(169, 20);
            txtTimKiem.Margin = new Padding(5, 4, 5, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(228, 35);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cBox_Status);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_title);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cBox_Publisher);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(ptbChonAnh);
            groupBox1.Controls.Add(cBox_Caterogy);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cBox_Author);
            groupBox1.Controls.Add(txt_book_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_quantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_book_id);
            groupBox1.Controls.Add(cBox_language);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(23, 64);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1358, 330);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // cBox_Status
            // 
            cBox_Status.Enabled = false;
            cBox_Status.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Status.FormattingEnabled = true;
            cBox_Status.Location = new Point(601, 172);
            cBox_Status.Margin = new Padding(5, 4, 5, 4);
            cBox_Status.Name = "cBox_Status";
            cBox_Status.Size = new Size(182, 35);
            cBox_Status.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(485, 175);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 27);
            label11.TabIndex = 60;
            label11.Text = "Trạng thái";
            // 
            // txt_title
            // 
            txt_title.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_title.Location = new Point(1013, 34);
            txt_title.Margin = new Padding(5, 4, 5, 4);
            txt_title.Name = "txt_title";
            txt_title.ReadOnly = true;
            txt_title.Size = new Size(315, 35);
            txt_title.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(920, 42);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 27);
            label10.TabIndex = 58;
            label10.Text = "Tiêu đề";
            // 
            // cBox_Publisher
            // 
            cBox_Publisher.Enabled = false;
            cBox_Publisher.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Publisher.FormattingEnabled = true;
            cBox_Publisher.Location = new Point(902, 111);
            cBox_Publisher.Margin = new Padding(5, 4, 5, 4);
            cBox_Publisher.Name = "cBox_Publisher";
            cBox_Publisher.Size = new Size(426, 35);
            cBox_Publisher.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(791, 116);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 27);
            label9.TabIndex = 56;
            label9.Text = "Tên NSX";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnThemTacGia);
            groupBox3.Location = new Point(409, 243);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(576, 79);
            groupBox3.TabIndex = 55;
            groupBox3.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(469, 23);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(353, 23);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(237, 23);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(125, 23);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(8, 23);
            btnThemTacGia.Margin = new Padding(5);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(91, 44);
            btnThemTacGia.TabIndex = 17;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Enabled = false;
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(56, 194);
            btnChonAnh.Margin = new Padding(5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(91, 44);
            btnChonAnh.TabIndex = 54;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbChonAnh.Location = new Point(34, 27);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(125, 159);
            ptbChonAnh.TabIndex = 19;
            ptbChonAnh.TabStop = false;
            // 
            // cBox_Caterogy
            // 
            cBox_Caterogy.Enabled = false;
            cBox_Caterogy.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Caterogy.FormattingEnabled = true;
            cBox_Caterogy.Location = new Point(601, 111);
            cBox_Caterogy.Margin = new Padding(5, 4, 5, 4);
            cBox_Caterogy.Name = "cBox_Caterogy";
            cBox_Caterogy.Size = new Size(182, 35);
            cBox_Caterogy.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(501, 121);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 17;
            label5.Text = "Thể loại";
            // 
            // cBox_Author
            // 
            cBox_Author.Enabled = false;
            cBox_Author.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Author.FormattingEnabled = true;
            cBox_Author.Location = new Point(920, 172);
            cBox_Author.Margin = new Padding(5, 4, 5, 4);
            cBox_Author.Name = "cBox_Author";
            cBox_Author.Size = new Size(408, 35);
            cBox_Author.TabIndex = 16;
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(621, 39);
            txt_book_name.Margin = new Padding(5, 4, 5, 4);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.ReadOnly = true;
            txt_book_name.Size = new Size(289, 35);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 56);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(501, 51);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(792, 175);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 2;
            label3.Text = "Tên tác giả";
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(315, 173);
            txt_quantity.Margin = new Padding(5, 4, 5, 4);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.ReadOnly = true;
            txt_quantity.Size = new Size(82, 35);
            txt_quantity.TabIndex = 15;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(202, 180);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 27);
            label7.TabIndex = 14;
            label7.Text = "Số lượng ";
            // 
            // txt_book_id
            // 
            txt_book_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_id.Location = new Point(305, 44);
            txt_book_id.Margin = new Padding(5, 4, 5, 4);
            txt_book_id.Name = "txt_book_id";
            txt_book_id.ReadOnly = true;
            txt_book_id.Size = new Size(182, 35);
            txt_book_id.TabIndex = 8;
            // 
            // cBox_language
            // 
            cBox_language.Enabled = false;
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(305, 116);
            cBox_language.Margin = new Padding(5, 4, 5, 4);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(182, 35);
            cBox_language.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(199, 128);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(482, 12);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(399, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin sách";
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(680, 768);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 53;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(869, 767);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 52;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(769, 767);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 51;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(470, 767);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 49;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(570, 767);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 50;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // formQuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 813);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvSach);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "formQuanLySach";
            Text = "Quản lý sách";
            Load += formQuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSach;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private ComboBox cBox_Author;
        private TextBox txt_book_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_quantity;
        private Label label7;
        private TextBox txt_book_id;
        private ComboBox cBox_language;
        private Label label6;
        private Label label8;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private ComboBox cBox_Caterogy;
        private Label label5;
        private PictureBox ptbChonAnh;
        private Button btnChonAnh;
        private GroupBox groupBox3;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnThemTacGia;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewTextBoxColumn COL_TITLE;
        private DataGridViewTextBoxColumn COL_TOTALCOPIES;
        private DataGridViewTextBoxColumn COL_AVAILABLECOPIES;
        private DataGridViewTextBoxColumn COL_BORROWEDCOPIES;
        private DataGridViewTextBoxColumn COL_STATUS;
        private ComboBox cBox_Publisher;
        private Label label9;
        private TextBox txt_title;
        private Label label10;
        private ComboBox cBox_Status;
        private Label label11;
    }
}