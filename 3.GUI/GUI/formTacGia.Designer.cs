
using _3.GUI.Helper;

namespace QLTV
{
    partial class formTacGia
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
            dgvTacGia = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnChonAnh = new Button();
            dtpNgaySinh = new DateTimePicker();
            label1 = new Label();
            ptbChonAnh = new RoundedPictureBox();
            txtMaTacGia = new TextBox();
            txtTenTacGia = new TextBox();
            btnThemTacGia = new Button();
            label3 = new Label();
            btnXoa = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            label8 = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            txtNumberPage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvTacGia
            // 
            dgvTacGia.AllowUserToAddRows = false;
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTacGia.BackgroundColor = SystemColors.ActiveCaption;
            dgvTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacGia.Location = new Point(-7, 255);
            dgvTacGia.Margin = new Padding(4);
            dgvTacGia.Name = "dgvTacGia";
            dgvTacGia.RowHeadersWidth = 51;
            dgvTacGia.RowTemplate.Height = 100;
            dgvTacGia.Size = new Size(1237, 314);
            dgvTacGia.TabIndex = 23;
            dgvTacGia.CellClick += dgvTacGia_CellContentClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-7, -2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1237, 293);
            panel1.TabIndex = 22;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(868, -4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 53);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(139, 14);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(182, 29);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 12;
            label4.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ptbChonAnh);
            groupBox1.Controls.Add(txtMaTacGia);
            groupBox1.Controls.Add(txtTenTacGia);
            groupBox1.Controls.Add(btnThemTacGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 45);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1167, 205);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(811, 142);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 25;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(696, 142);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 24;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(53, 123);
            btnChonAnh.Margin = new Padding(4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(79, 23);
            btnChonAnh.TabIndex = 23;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(324, 81);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(242, 23);
            dtpNgaySinh.TabIndex = 22;
            dtpNgaySinh.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 21;
            label1.Text = "Ngày sinh";
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(30, 20);
            ptbChonAnh.Margin = new Padding(3, 2, 3, 2);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(126, 98);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 20;
            ptbChonAnh.TabStop = false;
            // 
            // txtMaTacGia
            // 
            txtMaTacGia.Enabled = false;
            txtMaTacGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTacGia.Location = new Point(324, 26);
            txtMaTacGia.Margin = new Padding(4);
            txtMaTacGia.Name = "txtMaTacGia";
            txtMaTacGia.Size = new Size(242, 29);
            txtMaTacGia.TabIndex = 11;
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Enabled = false;
            txtTenTacGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTacGia.Location = new Point(742, 29);
            txtTenTacGia.Margin = new Padding(4);
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(242, 29);
            txtTenTacGia.TabIndex = 9;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(342, 142);
            btnThemTacGia.Margin = new Padding(4);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(80, 33);
            btnThemTacGia.TabIndex = 16;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(206, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Mã tác giả";
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(571, 142);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(453, 142);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 33);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(624, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên tác giả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(432, 1);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(355, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin tác giả";
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(758, 574);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 30;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(671, 574);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 29;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(409, 574);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 26;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(497, 574);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 27;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(598, 577);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 31;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // formTacGia
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1212, 618);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvTacGia);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "formTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTacGiac";
            WindowState = FormWindowState.Maximized;
            Load += formTacGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTacGia;
        private Panel panel1;
        private TextBox txtTenTacGia;
        private Label label8;
        private Button btnXoa;
        private Label label2;
        private Button btnUpdate;
        private Label label3;
        private Button btnThemTacGia;
        private TextBox txtMaTacGia;
        private RoundedPictureBox ptbChonAnh;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpNgaySinh;
        private Button btnChonAnh;
        private TextBox txtSearch;
        private Label label4;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private TextBox txtNumberPage;
        private GroupBox groupBox2;
    }
}