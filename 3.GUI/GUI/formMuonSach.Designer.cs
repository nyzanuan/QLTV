
namespace QLTV
{
    partial class formMuonSach
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
            dgvMuonSach = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            cmbSach = new ComboBox();
            cmbDocGia = new ComboBox();
            checkBox1 = new CheckBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThem = new Button();
            dtpNgayTra = new DateTimePicker();
            dtpNgayMuon = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(688, 761);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 48;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(877, 760);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 47;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(777, 760);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 46;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(478, 760);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 44;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(578, 760);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 45;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvMuonSach
            // 
            dgvMuonSach.AllowUserToAddRows = false;
            dgvMuonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuonSach.Location = new Point(0, 333);
            dgvMuonSach.Margin = new Padding(5, 4, 5, 4);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.Size = new Size(1408, 407);
            dgvMuonSach.TabIndex = 43;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-6, -1);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 335);
            panel1.TabIndex = 42;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Location = new Point(1017, -3);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(368, 68);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 31);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 24;
            label5.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(120, 23);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 32);
            txtSearch.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(cmbSach);
            groupBox1.Controls.Add(cmbDocGia);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(dtpNgayTra);
            groupBox1.Controls.Add(dtpNgayMuon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(27, 75);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1351, 247);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // cmbSach
            // 
            cmbSach.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSach.FormattingEnabled = true;
            cmbSach.Location = new Point(838, 43);
            cmbSach.Name = "cmbSach";
            cmbSach.Size = new Size(334, 39);
            cmbSach.TabIndex = 37;
            // 
            // cmbDocGia
            // 
            cmbDocGia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDocGia.FormattingEnabled = true;
            cmbDocGia.Location = new Point(191, 43);
            cmbDocGia.Name = "cmbDocGia";
            cmbDocGia.Size = new Size(334, 39);
            cmbDocGia.TabIndex = 36;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(355, 36);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 31);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Đã trả";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(896, 184);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(781, 184);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(672, 184);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(552, 184);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(434, 184);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dddd, MMMM dd, yyyy ";
            dtpNgayTra.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(838, 115);
            dtpNgayTra.Margin = new Padding(5, 4, 5, 4);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(334, 35);
            dtpNgayTra.TabIndex = 22;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dddd, MMMM dd, yyyy ";
            dtpNgayMuon.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(191, 111);
            dtpNgayMuon.Margin = new Padding(5, 4, 5, 4);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(334, 35);
            dtpNgayMuon.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(718, 123);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 27);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 27);
            label1.TabIndex = 0;
            label1.Text = "Chọn độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(718, 55);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 1;
            label2.Text = "Chọn sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 120);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 27);
            label3.TabIndex = 2;
            label3.Text = "Ngày mượn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(546, 0);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(417, 53);
            label8.TabIndex = 19;
            label8.Text = "Quản lý mượn sách";
            // 
            // panel2
            // 
            panel2.Location = new Point(561, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 140);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.Location = new Point(1186, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(138, 140);
            panel3.TabIndex = 39;
            // 
            // formMuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 803);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvMuonSach);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "formMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMuonSach";
            Load += formMuonSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvMuonSach;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUpdate;
        private Button btnThem;
        private DateTimePicker dtpNgayTra;
        private DateTimePicker dtpNgayMuon;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private CheckBox checkBox1;
        private ComboBox cmbSach;
        private ComboBox cmbDocGia;
        private Panel panel2;
        private Panel panel3;
    }
}