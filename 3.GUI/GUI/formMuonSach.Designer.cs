
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
            panelTop = new Panel();
            label5 = new Label();
            label8 = new Label();
            txtSearch = new TextBox();
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
            panelMid = new Panel();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(507, 300);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 48;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(672, 299);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 47;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(585, 299);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 46;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(323, 299);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 44;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(411, 299);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 45;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvMuonSach
            // 
            dgvMuonSach.AccessibleRole = AccessibleRole.None;
            dgvMuonSach.AllowUserToAddRows = false;
            dgvMuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuonSach.Location = new Point(0, 0);
            dgvMuonSach.Margin = new Padding(5, 4, 5, 4);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.RowTemplate.Height = 100;
            dgvMuonSach.Size = new Size(1063, 291);
            dgvMuonSach.TabIndex = 43;
            dgvMuonSach.SelectionChanged += dgvMuonSach_SelectionChanged;
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txtSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(795, 12);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 24;
            label5.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(375, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(282, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý mượn sách";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(886, 6);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(168, 27);
            txtSearch.TabIndex = 23;
            // 
            // btnLocSach
            // 
            btnLocSach.Enabled = false;
            btnLocSach.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocSach.Location = new Point(894, 19);
            btnLocSach.Margin = new Padding(5);
            btnLocSach.Name = "btnLocSach";
            btnLocSach.Size = new Size(58, 27);
            btnLocSach.TabIndex = 41;
            btnLocSach.Text = "Lọc";
            btnLocSach.UseVisualStyleBackColor = true;
            btnLocSach.Click += btnLocSach_Click;
            // 
            // btnLocDocGia
            // 
            btnLocDocGia.Enabled = false;
            btnLocDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocDocGia.Location = new Point(353, 20);
            btnLocDocGia.Margin = new Padding(5);
            btnLocDocGia.Name = "btnLocDocGia";
            btnLocDocGia.Size = new Size(56, 27);
            btnLocDocGia.TabIndex = 40;
            btnLocDocGia.Text = "Lọc";
            btnLocDocGia.UseVisualStyleBackColor = true;
            btnLocDocGia.Click += btnLocDocGia_Click;
            // 
            // panelHinhAnhSach
            // 
            panelHinhAnhSach.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhSach.Location = new Point(960, 18);
            panelHinhAnhSach.Name = "panelHinhAnhSach";
            panelHinhAnhSach.Size = new Size(95, 101);
            panelHinhAnhSach.TabIndex = 39;
            // 
            // panelHinhAnhDocGia
            // 
            panelHinhAnhDocGia.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            panelHinhAnhDocGia.Location = new Point(417, 19);
            panelHinhAnhDocGia.Name = "panelHinhAnhDocGia";
            panelHinhAnhDocGia.Size = new Size(95, 101);
            panelHinhAnhDocGia.TabIndex = 38;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(561, 97);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 23);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Đã trả";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbSach
            // 
            cmbSach.Enabled = false;
            cmbSach.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSach.FormattingEnabled = true;
            cmbSach.Location = new Point(673, 20);
            cmbSach.Name = "cmbSach";
            cmbSach.Size = new Size(213, 27);
            cmbSach.TabIndex = 37;
            cmbSach.SelectedIndexChanged += cmbSach_SelectedIndexChanged;
            cmbSach.TextChanged += cmbSach_TextChanged;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(571, 158);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(482, 158);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(376, 158);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 33);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(672, 158);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cmbDocGia
            // 
            cmbDocGia.Enabled = false;
            cmbDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDocGia.FormattingEnabled = true;
            cmbDocGia.Location = new Point(132, 21);
            cmbDocGia.Name = "cmbDocGia";
            cmbDocGia.Size = new Size(213, 27);
            cmbDocGia.TabIndex = 36;
            cmbDocGia.SelectedIndexChanged += cmbDocGia_SelectedIndexChanged;
            cmbDocGia.TextChanged += cmbDocGia_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(286, 158);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 33);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(673, 58);
            dtpNgayTra.Margin = new Padding(5, 4, 5, 4);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(213, 27);
            dtpNgayTra.TabIndex = 22;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Enabled = false;
            dtpNgayMuon.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(132, 63);
            dtpNgayMuon.Margin = new Padding(5, 4, 5, 4);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(213, 27);
            dtpNgayMuon.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(561, 66);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Chọn độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(561, 29);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 1;
            label2.Text = "Chọn sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 71);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày mượn";
            // 
            // panelMid
            // 
            panelMid.Controls.Add(btnLocSach);
            panelMid.Controls.Add(cmbDocGia);
            panelMid.Controls.Add(panelHinhAnhSach);
            panelMid.Controls.Add(checkBox1);
            panelMid.Controls.Add(btnLocDocGia);
            panelMid.Controls.Add(cmbSach);
            panelMid.Controls.Add(panelHinhAnhDocGia);
            panelMid.Controls.Add(dtpNgayTra);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(label4);
            panelMid.Controls.Add(label1);
            panelMid.Controls.Add(label2);
            panelMid.Controls.Add(dtpNgayMuon);
            panelMid.Controls.Add(btnThem);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(btnXoa);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 206);
            panelMid.TabIndex = 49;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvMuonSach);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 248);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 333);
            panelBot.TabIndex = 50;
            // 
            // formMuonSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMuonSach";
            Load += formMuonSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMid.ResumeLayout(false);
            panelMid.PerformLayout();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvMuonSach;
        private Panel panelTop;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtSearch;
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
        private Panel panelMid;
        private Panel panelBot;
    }
}