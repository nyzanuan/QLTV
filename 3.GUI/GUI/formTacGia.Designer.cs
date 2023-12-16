namespace _3.GUI.GUI
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
            panelHeader = new Panel();
            label5 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            tableLayoutPanelBody = new TableLayoutPanel();
            panelBodyImage = new Panel();
            btnChonAnh = new Button();
            ptbChonAnh = new Helper.RoundedPictureBox();
            tableLayoutAllInputAndButton = new TableLayoutPanel();
            panelBodyButton = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThemTacGia = new Button();
            tableLayoutPanelBoduInput = new TableLayoutPanel();
            txtTenTacGia = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtMaTacGia = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            tableLayoutPanelFooter = new TableLayoutPanel();
            panelFooterButton = new Panel();
            btnLastPage = new Button();
            btnNextPage = new Button();
            txtNumberPage = new TextBox();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            dgvTacGia = new DataGridView();
            panelHeader.SuspendLayout();
            tableLayoutPanelBody.SuspendLayout();
            panelBodyImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            tableLayoutAllInputAndButton.SuspendLayout();
            panelBodyButton.SuspendLayout();
            tableLayoutPanelBoduInput.SuspendLayout();
            tableLayoutPanelFooter.SuspendLayout();
            panelFooterButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label5);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(985, 53);
            panelHeader.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(488, 21);
            label5.Name = "label5";
            label5.Size = new Size(170, 19);
            label5.TabIndex = 6;
            label5.Text = "Nhập tên tác giả cần tìm";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(694, 15);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(281, 29);
            txtSearch.TabIndex = 1;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(226, 26);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // tableLayoutPanelBody
            // 
            tableLayoutPanelBody.ColumnCount = 2;
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBody.Controls.Add(panelBodyImage, 0, 0);
            tableLayoutPanelBody.Controls.Add(tableLayoutAllInputAndButton, 1, 0);
            tableLayoutPanelBody.Dock = DockStyle.Top;
            tableLayoutPanelBody.Location = new Point(0, 53);
            tableLayoutPanelBody.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            tableLayoutPanelBody.RowCount = 1;
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBody.Size = new Size(985, 190);
            tableLayoutPanelBody.TabIndex = 1;
            // 
            // panelBodyImage
            // 
            panelBodyImage.Controls.Add(btnChonAnh);
            panelBodyImage.Controls.Add(ptbChonAnh);
            panelBodyImage.Dock = DockStyle.Fill;
            panelBodyImage.Location = new Point(3, 2);
            panelBodyImage.Margin = new Padding(3, 2, 3, 2);
            panelBodyImage.Name = "panelBodyImage";
            panelBodyImage.Size = new Size(146, 186);
            panelBodyImage.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(32, 116);
            btnChonAnh.Margin = new Padding(3, 2, 3, 2);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(82, 22);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Visible = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BackColor = Color.Transparent;
            ptbChonAnh.Location = new Point(12, 2);
            ptbChonAnh.Margin = new Padding(3, 2, 3, 2);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(123, 100);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 0;
            ptbChonAnh.TabStop = false;
            // 
            // tableLayoutAllInputAndButton
            // 
            tableLayoutAllInputAndButton.ColumnCount = 1;
            tableLayoutAllInputAndButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAllInputAndButton.Controls.Add(panelBodyButton, 0, 1);
            tableLayoutAllInputAndButton.Controls.Add(tableLayoutPanelBoduInput, 0, 0);
            tableLayoutAllInputAndButton.Dock = DockStyle.Fill;
            tableLayoutAllInputAndButton.Location = new Point(155, 2);
            tableLayoutAllInputAndButton.Margin = new Padding(3, 2, 3, 2);
            tableLayoutAllInputAndButton.Name = "tableLayoutAllInputAndButton";
            tableLayoutAllInputAndButton.RowCount = 2;
            tableLayoutAllInputAndButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAllInputAndButton.RowStyles.Add(new RowStyle());
            tableLayoutAllInputAndButton.Size = new Size(827, 186);
            tableLayoutAllInputAndButton.TabIndex = 1;
            // 
            // panelBodyButton
            // 
            panelBodyButton.Anchor = AnchorStyles.None;
            panelBodyButton.Controls.Add(btnHuy);
            panelBodyButton.Controls.Add(btnLuu);
            panelBodyButton.Controls.Add(btnXoa);
            panelBodyButton.Controls.Add(btnUpdate);
            panelBodyButton.Controls.Add(btnThemTacGia);
            panelBodyButton.Location = new Point(54, 139);
            panelBodyButton.Margin = new Padding(3, 2, 3, 2);
            panelBodyButton.Name = "panelBodyButton";
            panelBodyButton.Size = new Size(719, 45);
            panelBodyButton.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.Location = new Point(429, 8);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(96, 34);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(327, 8);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(226, 8);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(124, 8);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Anchor = AnchorStyles.None;
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(23, 8);
            btnThemTacGia.Margin = new Padding(3, 2, 3, 2);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(96, 34);
            btnThemTacGia.TabIndex = 2;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // tableLayoutPanelBoduInput
            // 
            tableLayoutPanelBoduInput.ColumnCount = 4;
            tableLayoutPanelBoduInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBoduInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBoduInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBoduInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBoduInput.Controls.Add(txtTenTacGia, 3, 0);
            tableLayoutPanelBoduInput.Controls.Add(label3, 0, 1);
            tableLayoutPanelBoduInput.Controls.Add(label2, 0, 0);
            tableLayoutPanelBoduInput.Controls.Add(label4, 2, 0);
            tableLayoutPanelBoduInput.Controls.Add(txtMaTacGia, 1, 0);
            tableLayoutPanelBoduInput.Controls.Add(dtpNgaySinh, 1, 1);
            tableLayoutPanelBoduInput.Dock = DockStyle.Fill;
            tableLayoutPanelBoduInput.Location = new Point(3, 2);
            tableLayoutPanelBoduInput.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelBoduInput.Name = "tableLayoutPanelBoduInput";
            tableLayoutPanelBoduInput.RowCount = 2;
            tableLayoutPanelBoduInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBoduInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBoduInput.Size = new Size(821, 133);
            tableLayoutPanelBoduInput.TabIndex = 1;
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTacGia.Location = new Point(501, 15);
            txtTenTacGia.Margin = new Padding(3, 2, 3, 2);
            txtTenTacGia.Multiline = true;
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(317, 36);
            txtTenTacGia.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 90);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã tác giả";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(412, 23);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 2;
            label4.Text = "Tên tác giả";
            // 
            // txtMaTacGia
            // 
            txtMaTacGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTacGia.Location = new Point(90, 17);
            txtMaTacGia.Margin = new Padding(3, 2, 3, 2);
            txtMaTacGia.Multiline = true;
            txtMaTacGia.Name = "txtMaTacGia";
            txtMaTacGia.Size = new Size(316, 32);
            txtMaTacGia.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(90, 86);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(316, 26);
            dtpNgaySinh.TabIndex = 5;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 1;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.Controls.Add(panelFooterButton, 0, 1);
            tableLayoutPanelFooter.Controls.Add(dgvTacGia, 0, 0);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(0, 243);
            tableLayoutPanelFooter.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle());
            tableLayoutPanelFooter.Size = new Size(985, 193);
            tableLayoutPanelFooter.TabIndex = 2;
            // 
            // panelFooterButton
            // 
            panelFooterButton.Anchor = AnchorStyles.None;
            panelFooterButton.Controls.Add(btnLastPage);
            panelFooterButton.Controls.Add(btnNextPage);
            panelFooterButton.Controls.Add(txtNumberPage);
            panelFooterButton.Controls.Add(btnFirstPage);
            panelFooterButton.Controls.Add(btnPrePage);
            panelFooterButton.Location = new Point(209, 154);
            panelFooterButton.Margin = new Padding(3, 2, 3, 2);
            panelFooterButton.Name = "panelFooterButton";
            panelFooterButton.Size = new Size(566, 37);
            panelFooterButton.TabIndex = 0;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.Bottom;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(415, 10);
            btnLastPage.Margin = new Padding(4, 4, 4, 4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 78;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Bottom;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(327, 10);
            btnNextPage.Margin = new Padding(4, 4, 4, 4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 77;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.Bottom;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(249, 10);
            txtNumberPage.Margin = new Padding(4, 4, 4, 4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 79;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.Bottom;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(66, 10);
            btnFirstPage.Margin = new Padding(4, 4, 4, 4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 75;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.Bottom;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(153, 10);
            btnPrePage.Margin = new Padding(4, 4, 4, 4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 76;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvTacGia
            // 
            dgvTacGia.AllowUserToAddRows = false;
            dgvTacGia.AllowUserToDeleteRows = false;
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacGia.Dock = DockStyle.Fill;
            dgvTacGia.Location = new Point(3, 2);
            dgvTacGia.Margin = new Padding(3, 2, 3, 2);
            dgvTacGia.Name = "dgvTacGia";
            dgvTacGia.ReadOnly = true;
            dgvTacGia.RowHeadersWidth = 51;
            dgvTacGia.RowTemplate.Height = 100;
            dgvTacGia.Size = new Size(979, 148);
            dgvTacGia.TabIndex = 1;
            dgvTacGia.CellClick += dgvTacGia_CellContentClick;
            // 
            // formTacGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 436);
            Controls.Add(tableLayoutPanelFooter);
            Controls.Add(tableLayoutPanelBody);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formTacGia";
            Text = "formTacGia";
            Load += formTacGia_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelBody.ResumeLayout(false);
            panelBodyImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            tableLayoutAllInputAndButton.ResumeLayout(false);
            panelBodyButton.ResumeLayout(false);
            tableLayoutPanelBoduInput.ResumeLayout(false);
            tableLayoutPanelBoduInput.PerformLayout();
            tableLayoutPanelFooter.ResumeLayout(false);
            panelFooterButton.ResumeLayout(false);
            panelFooterButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private TextBox txtSearch;
        private TableLayoutPanel tableLayoutPanelBody;
        private Panel panelBodyImage;
        private Button btnThemTacGia;
        private Button btnChonAnh;
        private Helper.RoundedPictureBox ptbChonAnh;
        private TableLayoutPanel tableLayoutAllInputAndButton;
        private Panel panelBodyButton;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUpdate;
        private TableLayoutPanel tableLayoutPanelBoduInput;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtTenTacGia;
        private TextBox txtMaTacGia;
        private DateTimePicker dtpNgaySinh;
        private TableLayoutPanel tableLayoutPanelFooter;
        private Panel panelFooterButton;
        private Button btnLastPage;
        private Button btnNextPage;
        private TextBox txtNumberPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvTacGia;
        private Label label5;
    }
}