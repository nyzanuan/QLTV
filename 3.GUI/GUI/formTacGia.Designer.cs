
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
            btn_del = new Button();
            btn_update = new Button();
            label2 = new Label();
            label8 = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            textBox1 = new TextBox();
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
            dgvTacGia.BackgroundColor = SystemColors.ActiveCaption;
            dgvTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacGia.Location = new Point(13, 414);
            dgvTacGia.Margin = new Padding(4, 5, 4, 5);
            dgvTacGia.Name = "dgvTacGia";
            dgvTacGia.RowHeadersWidth = 51;
            dgvTacGia.Size = new Size(1377, 419);
            dgvTacGia.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(13, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 390);
            panel1.TabIndex = 22;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(719, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 309);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khu vực tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(233, 125);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 35);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(76, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 27);
            label4.TabIndex = 12;
            label4.Text = "Tên tác giả";
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
            groupBox1.Controls.Add(btn_del);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 304);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khu vực edit";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(431, 234);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(92, 44);
            btnHuy.TabIndex = 25;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(331, 234);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(92, 44);
            btnLuu.TabIndex = 24;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(61, 164);
            btnChonAnh.Margin = new Padding(4, 5, 4, 5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(90, 31);
            btnChonAnh.TabIndex = 23;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(372, 137);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(276, 27);
            dtpNgaySinh.TabIndex = 22;
            dtpNgaySinh.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 21;
            label1.Text = "Ngày sinh";
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(34, 26);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(144, 130);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 20;
            ptbChonAnh.TabStop = false;
            // 
            // txtMaTacGia
            // 
            txtMaTacGia.Enabled = false;
            txtMaTacGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTacGia.Location = new Point(370, 28);
            txtMaTacGia.Margin = new Padding(4, 5, 4, 5);
            txtMaTacGia.Name = "txtMaTacGia";
            txtMaTacGia.Size = new Size(276, 35);
            txtMaTacGia.TabIndex = 11;
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Enabled = false;
            txtTenTacGia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTacGia.Location = new Point(370, 88);
            txtTenTacGia.Margin = new Padding(4, 5, 4, 5);
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(276, 35);
            txtTenTacGia.TabIndex = 9;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(32, 234);
            btnThemTacGia.Margin = new Padding(4, 5, 4, 5);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(92, 44);
            btnThemTacGia.TabIndex = 16;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(235, 36);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 27);
            label3.TabIndex = 2;
            label3.Text = "Mã tác giả";
            // 
            // btn_del
            // 
            btn_del.Enabled = false;
            btn_del.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_del.Location = new Point(232, 234);
            btn_del.Margin = new Padding(4, 5, 4, 5);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(92, 44);
            btn_del.TabIndex = 18;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Enabled = false;
            btn_update.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.Location = new Point(132, 234);
            btn_update.Margin = new Padding(4, 5, 4, 5);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(92, 44);
            btn_update.TabIndex = 17;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên tác giả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(468, 14);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(526, 53);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin tác giả";
            // 
            // btnLastPage
            // 
            btnLastPage.Enabled = false;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLastPage.Location = new Point(869, 843);
            btnLastPage.Margin = new Padding(4, 5, 4, 5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(92, 44);
            btnLastPage.TabIndex = 30;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Enabled = false;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextPage.Location = new Point(769, 843);
            btnNextPage.Margin = new Padding(4, 5, 4, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(92, 44);
            btnNextPage.TabIndex = 29;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(470, 843);
            btnFirstPage.Margin = new Padding(4, 5, 4, 5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(92, 44);
            btnFirstPage.TabIndex = 26;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Enabled = false;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrePage.Location = new Point(570, 843);
            btnPrePage.Margin = new Padding(4, 5, 4, 5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(92, 44);
            btnPrePage.TabIndex = 27;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(686, 847);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 40);
            textBox1.TabIndex = 31;
            textBox1.Text = "0/0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // formTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 891);
            Controls.Add(textBox1);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvTacGia);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTacGiac";
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
        private Button btn_del;
        private Label label2;
        private Button btn_update;
        private Label label3;
        private Button btnThemTacGia;
        private TextBox txtMaTacGia;
        private RoundedPictureBox ptbChonAnh;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpNgaySinh;
        private Button btnChonAnh;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Label label4;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private TextBox textBox1;
    }
}