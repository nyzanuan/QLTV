
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
            COL_AVAILABLECOPIES = new DataGridViewTextBoxColumn();
            COL_BORROWEDCOPIES = new DataGridViewTextBoxColumn();
            COL_TOTALCOPIES = new DataGridViewTextBoxColumn();
            COL_IMAGE = new DataGridViewImageColumn();
            COL_STATUS = new DataGridViewTextBoxColumn();
            panelTop = new Panel();
            label4 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThemTacGia = new Button();
            label5 = new Label();
            txt_book_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            txt_book_id = new TextBox();
            cBox_language = new ComboBox();
            label6 = new Label();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panelMid = new Panel();
            cBox_Publisher = new ComboBox();
            label11 = new Label();
            cBox_Status = new ComboBox();
            cBox_Caterogy = new ComboBox();
            txt_title = new TextBox();
            label10 = new Label();
            btnChonAnh = new Button();
            ptbChonAnh = new PictureBox();
            label9 = new Label();
            cBox_Author = new ComboBox();
            label3 = new Label();
            txt_quantity = new TextBox();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME, COL_TITLE, COL_AVAILABLECOPIES, COL_BORROWEDCOPIES, COL_TOTALCOPIES, COL_IMAGE, COL_STATUS });
            dgvSach.Location = new Point(0, 1);
            dgvSach.Margin = new Padding(5, 4, 5, 4);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(1215, 432);
            dgvSach.TabIndex = 38;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // COL_ID
            // 
            COL_ID.DataPropertyName = "BookId";
            COL_ID.HeaderText = "Mã sách";
            COL_ID.MinimumWidth = 6;
            COL_ID.Name = "COL_ID";
            COL_ID.ReadOnly = true;
            COL_ID.Width = 125;
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên sách";
            COL_NAME.MinimumWidth = 6;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            COL_NAME.Width = 125;
            // 
            // COL_TITLE
            // 
            COL_TITLE.DataPropertyName = "Title";
            COL_TITLE.HeaderText = "Tiêu đề";
            COL_TITLE.MinimumWidth = 6;
            COL_TITLE.Name = "COL_TITLE";
            COL_TITLE.ReadOnly = true;
            COL_TITLE.Width = 125;
            // 
            // COL_AVAILABLECOPIES
            // 
            COL_AVAILABLECOPIES.DataPropertyName = "AvailableCopies";
            COL_AVAILABLECOPIES.HeaderText = "Sách hiện có";
            COL_AVAILABLECOPIES.MinimumWidth = 6;
            COL_AVAILABLECOPIES.Name = "COL_AVAILABLECOPIES";
            COL_AVAILABLECOPIES.ReadOnly = true;
            COL_AVAILABLECOPIES.Width = 125;
            // 
            // COL_BORROWEDCOPIES
            // 
            COL_BORROWEDCOPIES.DataPropertyName = "BorrowedCopies";
            COL_BORROWEDCOPIES.HeaderText = "Sách cho mượn";
            COL_BORROWEDCOPIES.MinimumWidth = 6;
            COL_BORROWEDCOPIES.Name = "COL_BORROWEDCOPIES";
            COL_BORROWEDCOPIES.ReadOnly = true;
            COL_BORROWEDCOPIES.Width = 125;
            // 
            // COL_TOTALCOPIES
            // 
            COL_TOTALCOPIES.DataPropertyName = "TotalCopies";
            COL_TOTALCOPIES.HeaderText = "Tổng số sách";
            COL_TOTALCOPIES.MinimumWidth = 6;
            COL_TOTALCOPIES.Name = "COL_TOTALCOPIES";
            COL_TOTALCOPIES.ReadOnly = true;
            COL_TOTALCOPIES.Width = 125;
            // 
            // COL_IMAGE
            // 
            COL_IMAGE.DataPropertyName = "Image";
            COL_IMAGE.HeaderText = "Hình sách";
            COL_IMAGE.ImageLayout = DataGridViewImageCellLayout.Zoom;
            COL_IMAGE.MinimumWidth = 6;
            COL_IMAGE.Name = "COL_IMAGE";
            COL_IMAGE.ReadOnly = true;
            COL_IMAGE.Resizable = DataGridViewTriState.True;
            COL_IMAGE.SortMode = DataGridViewColumnSortMode.Automatic;
            COL_IMAGE.Width = 125;
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
            // panelTop
            // 
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 4, 5, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1215, 56);
            panelTop.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(894, 16);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 18;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(1008, 5);
            txtTimKiem.Margin = new Padding(5, 4, 5, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(191, 35);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(429, 3);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(399, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin sách";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(839, 180);
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
            btnLuu.Location = new Point(723, 180);
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
            btnXoa.Location = new Point(607, 180);
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
            btnUpdate.Location = new Point(495, 180);
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
            btnThemTacGia.Location = new Point(378, 180);
            btnThemTacGia.Margin = new Padding(5);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(91, 44);
            btnThemTacGia.TabIndex = 17;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(258, 82);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 17;
            label5.Text = "Thể loại";
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(670, 8);
            txt_book_name.Margin = new Padding(5, 4, 5, 4);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.ReadOnly = true;
            txt_book_name.Size = new Size(260, 35);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 20);
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
            label2.Location = new Point(550, 20);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(994, 79);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 27);
            label7.TabIndex = 14;
            label7.Text = "Số lượng";
            // 
            // txt_book_id
            // 
            txt_book_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_id.Location = new Point(353, 8);
            txt_book_id.Margin = new Padding(5, 4, 5, 4);
            txt_book_id.Name = "txt_book_id";
            txt_book_id.ReadOnly = true;
            txt_book_id.Size = new Size(158, 35);
            txt_book_id.TabIndex = 8;
            // 
            // cBox_language
            // 
            cBox_language.Enabled = false;
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(1043, 8);
            cBox_language.Margin = new Padding(5, 4, 5, 4);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(158, 35);
            cBox_language.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(938, 20);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(602, 444);
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
            btnLastPage.Location = new Point(791, 443);
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
            btnNextPage.Location = new Point(691, 443);
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
            btnFirstPage.Location = new Point(392, 443);
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
            btnPrePage.Location = new Point(493, 443);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 50;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(cBox_Publisher);
            panelMid.Controls.Add(label11);
            panelMid.Controls.Add(cBox_Status);
            panelMid.Controls.Add(cBox_Caterogy);
            panelMid.Controls.Add(txt_title);
            panelMid.Controls.Add(label10);
            panelMid.Controls.Add(btnChonAnh);
            panelMid.Controls.Add(ptbChonAnh);
            panelMid.Controls.Add(label9);
            panelMid.Controls.Add(cBox_Author);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(txt_quantity);
            panelMid.Controls.Add(txt_book_name);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(label6);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(cBox_language);
            panelMid.Controls.Add(btnThemTacGia);
            panelMid.Controls.Add(label7);
            panelMid.Controls.Add(txt_book_id);
            panelMid.Controls.Add(label1);
            panelMid.Controls.Add(label2);
            panelMid.Controls.Add(label5);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 56);
            panelMid.Margin = new Padding(3, 4, 3, 4);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1215, 249);
            panelMid.TabIndex = 54;
            // 
            // cBox_Publisher
            // 
            cBox_Publisher.Enabled = false;
            cBox_Publisher.FormattingEnabled = true;
            cBox_Publisher.Location = new Point(976, 136);
            cBox_Publisher.Name = "cBox_Publisher";
            cBox_Publisher.Size = new Size(223, 28);
            cBox_Publisher.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(881, 137);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 27);
            label11.TabIndex = 41;
            label11.Text = "NXB";
            // 
            // cBox_Status
            // 
            cBox_Status.Enabled = false;
            cBox_Status.FormattingEnabled = true;
            cBox_Status.Location = new Point(723, 135);
            cBox_Status.Name = "cBox_Status";
            cBox_Status.Size = new Size(151, 28);
            cBox_Status.TabIndex = 40;
            // 
            // cBox_Caterogy
            // 
            cBox_Caterogy.Enabled = false;
            cBox_Caterogy.FormattingEnabled = true;
            cBox_Caterogy.Location = new Point(353, 81);
            cBox_Caterogy.Name = "cBox_Caterogy";
            cBox_Caterogy.Size = new Size(223, 28);
            cBox_Caterogy.TabIndex = 39;
            // 
            // txt_title
            // 
            txt_title.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_title.Location = new Point(677, 74);
            txt_title.Margin = new Padding(5, 4, 5, 4);
            txt_title.Name = "txt_title";
            txt_title.ReadOnly = true;
            txt_title.Size = new Size(280, 35);
            txt_title.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(584, 83);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 27);
            label10.TabIndex = 37;
            label10.Text = "Tiêu đề";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Enabled = false;
            btnChonAnh.Location = new Point(98, 176);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 36;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbChonAnh.Location = new Point(64, 7);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(163, 163);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 35;
            ptbChonAnh.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(608, 138);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 27);
            label9.TabIndex = 33;
            label9.Text = "Trạng thái";
            // 
            // cBox_Author
            // 
            cBox_Author.Enabled = false;
            cBox_Author.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Author.FormattingEnabled = true;
            cBox_Author.Location = new Point(348, 126);
            cBox_Author.Margin = new Padding(5, 4, 5, 4);
            cBox_Author.Name = "cBox_Author";
            cBox_Author.Size = new Size(247, 35);
            cBox_Author.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(233, 136);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 31;
            label3.Text = "Tên tác giả";
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(1101, 74);
            txt_quantity.Margin = new Padding(5, 4, 5, 4);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.ReadOnly = true;
            txt_quantity.Size = new Size(98, 35);
            txt_quantity.TabIndex = 30;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvSach);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 305);
            panelBot.Margin = new Padding(3, 4, 3, 4);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1215, 483);
            panelBot.TabIndex = 55;
            // 
            // formQuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 789);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(5, 4, 5, 4);
            Name = "formQuanLySach";
            Text = "Quản lý sách";
            Load += formQuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMid.ResumeLayout(false);
            panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvSach;
        private Panel panelTop;
        private Label label4;
        private TextBox txtTimKiem;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnThemTacGia;

        private TextBox txt_book_name;
        private Label label1;
        private Label label2;
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
        private Label label5;
        private Panel panelMid;
        private Panel panelBot;
        private TextBox txt_quantity;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewTextBoxColumn COL_TITLE;
        private DataGridViewTextBoxColumn COL_AVAILABLECOPIES;
        private DataGridViewTextBoxColumn COL_BORROWEDCOPIES;
        private DataGridViewTextBoxColumn COL_TOTALCOPIES;
        private DataGridViewImageColumn COL_IMAGE;
        private DataGridViewTextBoxColumn COL_STATUS;
        private Label label9;
        private ComboBox cBox_Author;
        private Label label3;
        private PictureBox ptbChonAnh;
        private Button btnChonAnh;
        private TextBox txt_title;
        private Label label10;
        private ComboBox cBox_Caterogy;
        private ComboBox cBox_Status;
        private ComboBox cBox_Publisher;
        private Label label11;
    }
}