
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
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelInput = new TableLayoutPanel();
            panelCmbDocGia = new Panel();
            panelCmbChonSach = new Panel();
            panelBodyButton = new Panel();
            panelBot = new Panel();
            tableLayoutPanelFooter = new TableLayoutPanel();
            panelFooterButton = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelInput.SuspendLayout();
            panelCmbDocGia.SuspendLayout();
            panelCmbChonSach.SuspendLayout();
            panelBodyButton.SuspendLayout();
            panelBot.SuspendLayout();
            tableLayoutPanelFooter.SuspendLayout();
            panelFooterButton.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(581, 5);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(77, 39);
            txtNumberPage.TabIndex = 48;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(772, 5);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(77, 39);
            btnLastPage.TabIndex = 47;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(679, 2);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(77, 39);
            btnNextPage.TabIndex = 46;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(404, 2);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(77, 39);
            btnFirstPage.TabIndex = 44;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(494, 2);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(77, 39);
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
            dgvMuonSach.Dock = DockStyle.Fill;
            dgvMuonSach.Location = new Point(6, 5);
            dgvMuonSach.Margin = new Padding(6, 5, 6, 5);
            dgvMuonSach.Name = "dgvMuonSach";
            dgvMuonSach.RowHeadersWidth = 51;
            dgvMuonSach.RowTemplate.Height = 100;
            dgvMuonSach.Size = new Size(1139, 351);
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
            panelTop.Margin = new Padding(5, 4, 5, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1151, 55);
            panelTop.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(704, 13);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 24;
            label5.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 5);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(350, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý mượn sách";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(812, 8);
            txtSearch.Margin = new Padding(6, 5, 6, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(328, 32);
            txtSearch.TabIndex = 23;
            // 
            // btnLocSach
            // 
            btnLocSach.Dock = DockStyle.Right;
            btnLocSach.Enabled = false;
            btnLocSach.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnLocSach.Location = new Point(259, 0);
            btnLocSach.Margin = new Padding(6, 7, 6, 7);
            btnLocSach.Name = "btnLocSach";
            btnLocSach.Size = new Size(66, 45);
            btnLocSach.TabIndex = 41;
            btnLocSach.Text = "Lọc";
            btnLocSach.UseVisualStyleBackColor = true;
            btnLocSach.Click += btnLocSach_Click;
            // 
            // btnLocDocGia
            // 
            btnLocDocGia.Dock = DockStyle.Right;
            btnLocDocGia.Enabled = false;
            btnLocDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocDocGia.Location = new Point(261, 0);
            btnLocDocGia.Margin = new Padding(6, 7, 6, 7);
            btnLocDocGia.Name = "btnLocDocGia";
            btnLocDocGia.Size = new Size(64, 48);
            btnLocDocGia.TabIndex = 40;
            btnLocDocGia.Text = "Lọc";
            btnLocDocGia.UseVisualStyleBackColor = true;
            btnLocDocGia.Click += btnLocDocGia_Click;
            // 
            // panelHinhAnhSach
            // 
            panelHinhAnhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHinhAnhSach.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhSach.Location = new Point(1034, 4);
            panelHinhAnhSach.Margin = new Padding(3, 4, 3, 4);
            panelHinhAnhSach.Name = "panelHinhAnhSach";
            tableLayoutPanelInput.SetRowSpan(panelHinhAnhSach, 2);
            panelHinhAnhSach.Size = new Size(108, 141);
            panelHinhAnhSach.TabIndex = 39;
            // 
            // panelHinhAnhDocGia
            // 
            panelHinhAnhDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHinhAnhDocGia.BorderStyle = BorderStyle.FixedSingle;
            panelHinhAnhDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            panelHinhAnhDocGia.Location = new Point(474, 4);
            panelHinhAnhDocGia.Margin = new Padding(3, 4, 3, 4);
            panelHinhAnhDocGia.Name = "panelHinhAnhDocGia";
            tableLayoutPanelInput.SetRowSpan(panelHinhAnhDocGia, 2);
            panelHinhAnhDocGia.Size = new Size(108, 141);
            panelHinhAnhDocGia.TabIndex = 38;
            // 
            // cmbSach
            // 
            cmbSach.Dock = DockStyle.Fill;
            cmbSach.Enabled = false;
            cmbSach.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSach.FormattingEnabled = true;
            cmbSach.Location = new Point(0, 0);
            cmbSach.Margin = new Padding(3, 4, 3, 4);
            cmbSach.Name = "cmbSach";
            cmbSach.Size = new Size(259, 31);
            cmbSach.TabIndex = 37;
            cmbSach.SelectedIndexChanged += cmbSach_SelectedIndexChanged;
            cmbSach.TextChanged += cmbSach_TextChanged;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(679, 9);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 36);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(430, 5);
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
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(531, 7);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 40);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(772, 9);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(104, 36);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cmbDocGia
            // 
            cmbDocGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbDocGia.Enabled = false;
            cmbDocGia.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDocGia.FormattingEnabled = true;
            cmbDocGia.Location = new Point(3, 13);
            cmbDocGia.Margin = new Padding(3, 4, 3, 4);
            cmbDocGia.Name = "cmbDocGia";
            cmbDocGia.Size = new Size(249, 31);
            cmbDocGia.TabIndex = 36;
            cmbDocGia.SelectedIndexChanged += cmbDocGia_SelectedIndexChanged;
            cmbDocGia.TextChanged += cmbDocGia_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(328, 5);
            btnThem.Margin = new Padding(6, 7, 6, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 30;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(706, 95);
            dtpNgayTra.Margin = new Padding(6, 5, 6, 5);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(319, 32);
            dtpNgayTra.TabIndex = 22;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayMuon.Enabled = false;
            dtpNgayMuon.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.Location = new Point(146, 95);
            dtpNgayMuon.Margin = new Padding(6, 5, 6, 5);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(319, 32);
            dtpNgayMuon.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(598, 99);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 24);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn độc giả";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(591, 24);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Chọn sách";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày mượn";
            // 
            // panelMid
            // 
            panelMid.Controls.Add(tableLayoutPanelMain);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 55);
            panelMid.Margin = new Padding(3, 4, 3, 4);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1151, 311);
            panelMid.TabIndex = 49;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInput, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelBodyButton, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(1151, 311);
            tableLayoutPanelMain.TabIndex = 45;
            // 
            // tableLayoutPanelInput
            // 
            tableLayoutPanelInput.ColumnCount = 6;
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelInput.Controls.Add(label1, 0, 0);
            tableLayoutPanelInput.Controls.Add(panelCmbDocGia, 1, 0);
            tableLayoutPanelInput.Controls.Add(panelHinhAnhSach, 5, 0);
            tableLayoutPanelInput.Controls.Add(panelCmbChonSach, 4, 0);
            tableLayoutPanelInput.Controls.Add(dtpNgayTra, 4, 1);
            tableLayoutPanelInput.Controls.Add(label3, 0, 1);
            tableLayoutPanelInput.Controls.Add(dtpNgayMuon, 1, 1);
            tableLayoutPanelInput.Controls.Add(label4, 3, 1);
            tableLayoutPanelInput.Controls.Add(label2, 3, 0);
            tableLayoutPanelInput.Controls.Add(panelHinhAnhDocGia, 2, 0);
            tableLayoutPanelInput.Dock = DockStyle.Fill;
            tableLayoutPanelInput.Location = new Point(3, 3);
            tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            tableLayoutPanelInput.RowCount = 2;
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInput.Size = new Size(1145, 149);
            tableLayoutPanelInput.TabIndex = 46;
            // 
            // panelCmbDocGia
            // 
            panelCmbDocGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelCmbDocGia.Controls.Add(cmbDocGia);
            panelCmbDocGia.Controls.Add(btnLocDocGia);
            panelCmbDocGia.Location = new Point(143, 13);
            panelCmbDocGia.Name = "panelCmbDocGia";
            panelCmbDocGia.Size = new Size(325, 48);
            panelCmbDocGia.TabIndex = 42;
            // 
            // panelCmbChonSach
            // 
            panelCmbChonSach.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelCmbChonSach.Controls.Add(cmbSach);
            panelCmbChonSach.Controls.Add(btnLocSach);
            panelCmbChonSach.Location = new Point(703, 14);
            panelCmbChonSach.Name = "panelCmbChonSach";
            panelCmbChonSach.Size = new Size(325, 45);
            panelCmbChonSach.TabIndex = 43;
            // 
            // panelBodyButton
            // 
            panelBodyButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBodyButton.Controls.Add(btnHuy);
            panelBodyButton.Controls.Add(btnXoa);
            panelBodyButton.Controls.Add(btnUpdate);
            panelBodyButton.Controls.Add(btnLuu);
            panelBodyButton.Controls.Add(btnThem);
            panelBodyButton.Location = new Point(3, 197);
            panelBodyButton.Name = "panelBodyButton";
            panelBodyButton.Size = new Size(1145, 72);
            panelBodyButton.TabIndex = 44;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(tableLayoutPanelFooter);
            panelBot.Dock = DockStyle.Fill;
            panelBot.Location = new Point(0, 366);
            panelBot.Margin = new Padding(3, 4, 3, 4);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1151, 423);
            panelBot.TabIndex = 50;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 1;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.Controls.Add(panelFooterButton, 0, 1);
            tableLayoutPanelFooter.Controls.Add(dgvMuonSach, 0, 0);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(0, 0);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle());
            tableLayoutPanelFooter.Size = new Size(1151, 423);
            tableLayoutPanelFooter.TabIndex = 49;
            // 
            // panelFooterButton
            // 
            panelFooterButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelFooterButton.Controls.Add(btnLastPage);
            panelFooterButton.Controls.Add(btnNextPage);
            panelFooterButton.Controls.Add(btnFirstPage);
            panelFooterButton.Controls.Add(txtNumberPage);
            panelFooterButton.Controls.Add(btnPrePage);
            panelFooterButton.Location = new Point(3, 364);
            panelFooterButton.Name = "panelFooterButton";
            panelFooterButton.Size = new Size(1145, 56);
            panelFooterButton.TabIndex = 50;
            // 
            // formMuonSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 789);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(5, 4, 5, 4);
            Name = "formMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMuonSach";
            Load += formMuonSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMuonSach).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMid.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelInput.ResumeLayout(false);
            tableLayoutPanelInput.PerformLayout();
            panelCmbDocGia.ResumeLayout(false);
            panelCmbChonSach.ResumeLayout(false);
            panelBodyButton.ResumeLayout(false);
            panelBot.ResumeLayout(false);
            tableLayoutPanelFooter.ResumeLayout(false);
            panelFooterButton.ResumeLayout(false);
            panelFooterButton.PerformLayout();
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
        private ComboBox cmbSach;
        private ComboBox cmbDocGia;
        private Panel panelHinhAnhDocGia;
        private Panel panelHinhAnhSach;
        private Button btnLocDocGia;
        private Button btnLocSach;
        private Panel panelMid;
        private Panel panelBot;
        private Panel panelBodyButton;
        private Panel panelCmbChonSach;
        private Panel panelCmbDocGia;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelInput;
        private Panel panelFooterButton;
        private TableLayoutPanel tableLayoutPanelFooter;
    }
}