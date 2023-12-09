
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
            panelMain = new Panel();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            btnLocSach = new Button();
            btnLocDocGia = new Button();
            panelHinhAnhSach = new Panel();
            panelHinhAnhDocGia = new Panel();
            checkBox1 = new CheckBox();
            cmbSach = new ComboBox();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnHuy = new Button();
            cmbDocGia = new ComboBox();
            btnThem = new Button();
            dtpNgayTra = new DateTimePicker();
            dtpNgayMuon = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            panelMain.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(738, 748);
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
            btnLastPage.Location = new Point(927, 747);
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
            btnNextPage.Location = new Point(827, 747);
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
            btnFirstPage.Location = new Point(528, 747);
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
            btnPrePage.Location = new Point(628, 747);
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
            dgvMuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuonSach.Location = new Point(11, 350);
            dgvMuonSach.Margin = new Padding(6, 5, 6, 5);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.RowTemplate.Height = 100;
            dgvMuonSach.Size = new Size(1519, 367);
            dgvMuonSach.TabIndex = 43;
            dgvMuonSach.SelectionChanged += dgvMuonSach_SelectionChanged;
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(groupBox2);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(label8);
            panelMain.Location = new Point(14, 13);
            panelMain.Margin = new Padding(5, 4, 5, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1516, 318);
            panelMain.TabIndex = 42;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Location = new Point(971, 5);
            groupBox2.Margin = new Padding(3, 5, 3, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(420, 68);
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
            txtSearch.Location = new Point(137, 31);
            txtSearch.Margin = new Padding(6, 5, 6, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(266, 32);
            txtSearch.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLocSach);
            groupBox1.Controls.Add(btnLocDocGia);
            groupBox1.Controls.Add(panelHinhAnhSach);
            groupBox1.Controls.Add(panelHinhAnhDocGia);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(cmbSach);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(cmbDocGia);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(dtpNgayTra);
            groupBox1.Controls.Add(dtpNgayMuon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(33, 74);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1450, 234);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // btnLocSach
            // 
            btnLocSach.Enabled = false;
            btnLocSach.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocSach.Location = new Point(1226, 38);
            btnLocSach.Margin = new Padding(6, 7, 6, 7);
            btnLocSach.Name = "btnLocSach";
            btnLocSach.Size = new Size(52, 36);
            btnLocSach.TabIndex = 41;
            btnLocSach.Text = "Lọc";
            btnLocSach.UseVisualStyleBackColor = true;
            btnLocSach.Click += btnLocSach_Click;
            // 
            // btnLocDocGia
            // 
            btnLocDocGia.Enabled = false;
            btnLocDocGia.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocDocGia.Location = new Point(546, 44);
            btnLocDocGia.Margin = new Padding(6, 7, 6, 7);
            btnLocDocGia.Name = "btnLocDocGia";
            btnLocDocGia.Size = new Size(52, 36);
            btnLocDocGia.TabIndex = 40;
            btnLocDocGia.Text = "Lọc";
            btnLocDocGia.UseVisualStyleBackColor = true;
            btnLocDocGia.Click += btnLocDocGia_Click;
            // 
            // panelHinhAnhSach
            // 
            panelHinhAnhSach.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhSach.Location = new Point(1298, 26);
            panelHinhAnhSach.Margin = new Padding(3, 4, 3, 4);
            panelHinhAnhSach.Name = "panelHinhAnhSach";
            panelHinhAnhSach.Size = new Size(130, 147);
            panelHinhAnhSach.TabIndex = 39;
            // 
            // panelHinhAnhDocGia
            // 
            panelHinhAnhDocGia.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhDocGia.Location = new Point(625, 29);
            panelHinhAnhDocGia.Margin = new Padding(3, 4, 3, 4);
            panelHinhAnhDocGia.Name = "panelHinhAnhDocGia";
            panelHinhAnhDocGia.Size = new Size(109, 128);
            panelHinhAnhDocGia.TabIndex = 38;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(769, 144);
            checkBox1.Margin = new Padding(3, 5, 3, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 29);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Đã trả";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbSach
            // 
            cmbSach.Enabled = false;
            cmbSach.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSach.FormattingEnabled = true;
            cmbSach.Location = new Point(897, 41);
            cmbSach.Margin = new Padding(3, 4, 3, 4);
            cmbSach.Name = "cmbSach";
            cmbSach.Size = new Size(324, 33);
            cmbSach.TabIndex = 37;
            cmbSach.SelectedIndexChanged += cmbSach_SelectedIndexChanged;
            cmbSach.TextChanged += cmbSach_TextChanged;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(346, 183);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(245, 183);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(124, 183);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 44);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(462, 183);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cmbDocGia
            // 
            cmbDocGia.Enabled = false;
            cmbDocGia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDocGia.FormattingEnabled = true;
            cmbDocGia.Location = new Point(207, 44);
            cmbDocGia.Margin = new Padding(3, 4, 3, 4);
            cmbDocGia.Name = "cmbDocGia";
            cmbDocGia.Size = new Size(330, 33);
            cmbDocGia.TabIndex = 36;
            cmbDocGia.SelectedIndexChanged += cmbDocGia_SelectedIndexChanged;
            cmbDocGia.TextChanged += cmbDocGia_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(21, 183);
            btnThem.Margin = new Padding(6, 7, 6, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 44);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(897, 92);
            dtpNgayTra.Margin = new Padding(6, 5, 6, 5);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(381, 30);
            dtpNgayTra.TabIndex = 22;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Enabled = false;
            dtpNgayMuon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(207, 100);
            dtpNgayMuon.Margin = new Padding(6, 5, 6, 5);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(381, 30);
            dtpNgayMuon.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(769, 97);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(769, 57);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Chọn sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 100);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
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
            // formMuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 783);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvMuonSach);
            Controls.Add(panelMain);
            Margin = new Padding(5, 4, 5, 4);
            Name = "formMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMuonSach";
            Load += formMuonSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
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
        private Panel panelMain;
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
        private Panel panelHinhAnhDocGia;
        private Panel panelHinhAnhSach;
        private Button btnLocDocGia;
        private Button btnLocSach;
    }
}