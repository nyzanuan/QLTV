
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            tableLayoutPanelMain = new TableLayoutPanel();
            panelImage = new Panel();
            btnChonAnh = new Button();
            tableLayoutPanelMainInputAndButton = new TableLayoutPanel();
            panelMainButton = new Panel();
            tableLayoutPanelMainInput = new TableLayoutPanel();
            cBox_Publisher = new ComboBox();
            label11 = new Label();
            label3 = new Label();
            cBox_Status = new ComboBox();
            cBox_Caterogy = new ComboBox();
            cBox_Author = new ComboBox();
            txt_quantity = new TextBox();
            txt_title = new TextBox();
            label10 = new Label();
            label9 = new Label();
            panelBot = new Panel();
            tableLayoutPanelFooter = new TableLayoutPanel();
            panelFooterButton = new Panel();
            ptbChonAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelImage.SuspendLayout();
            tableLayoutPanelMainInputAndButton.SuspendLayout();
            panelMainButton.SuspendLayout();
            tableLayoutPanelMainInput.SuspendLayout();
            panelBot.SuspendLayout();
            tableLayoutPanelFooter.SuspendLayout();
            panelFooterButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME, COL_TITLE, COL_AVAILABLECOPIES, COL_BORROWEDCOPIES, COL_TOTALCOPIES, COL_IMAGE, COL_STATUS });
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(5, 4);
            dgvSach.Margin = new Padding(5, 4, 5, 4);
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 100;
            dgvSach.Size = new Size(1198, 424);
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
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên sách";
            COL_NAME.MinimumWidth = 6;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            // 
            // COL_TITLE
            // 
            COL_TITLE.DataPropertyName = "Title";
            COL_TITLE.HeaderText = "Tiêu đề";
            COL_TITLE.MinimumWidth = 6;
            COL_TITLE.Name = "COL_TITLE";
            COL_TITLE.ReadOnly = true;
            // 
            // COL_AVAILABLECOPIES
            // 
            COL_AVAILABLECOPIES.DataPropertyName = "AvailableCopies";
            COL_AVAILABLECOPIES.HeaderText = "Sách hiện có";
            COL_AVAILABLECOPIES.MinimumWidth = 6;
            COL_AVAILABLECOPIES.Name = "COL_AVAILABLECOPIES";
            COL_AVAILABLECOPIES.ReadOnly = true;
            // 
            // COL_BORROWEDCOPIES
            // 
            COL_BORROWEDCOPIES.DataPropertyName = "BorrowedCopies";
            COL_BORROWEDCOPIES.HeaderText = "Sách cho mượn";
            COL_BORROWEDCOPIES.MinimumWidth = 6;
            COL_BORROWEDCOPIES.Name = "COL_BORROWEDCOPIES";
            COL_BORROWEDCOPIES.ReadOnly = true;
            // 
            // COL_TOTALCOPIES
            // 
            COL_TOTALCOPIES.DataPropertyName = "TotalCopies";
            COL_TOTALCOPIES.HeaderText = "Tổng số sách";
            COL_TOTALCOPIES.MinimumWidth = 6;
            COL_TOTALCOPIES.Name = "COL_TOTALCOPIES";
            COL_TOTALCOPIES.ReadOnly = true;
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
            panelTop.Size = new Size(1208, 56);
            panelTop.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(828, 13);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 18;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(939, 5);
            txtTimKiem.Margin = new Padding(5, 4, 5, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(249, 35);
            txtTimKiem.TabIndex = 17;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 5);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(399, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin sách";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(526, 5);
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
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(410, 5);
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
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(294, 5);
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
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(182, 5);
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
            btnThemTacGia.Anchor = AnchorStyles.None;
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(65, 5);
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
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 72);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 17;
            label5.Text = "Thể loại";
            // 
            // txt_book_name
            // 
            txt_book_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(485, 11);
            txt_book_name.Margin = new Padding(5, 4, 5, 4);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.ReadOnly = true;
            txt_book_name.Size = new Size(223, 35);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(371, 15);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(722, 72);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 27);
            label7.TabIndex = 14;
            label7.Text = "Số lượng";
            // 
            // txt_book_id
            // 
            txt_book_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_book_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_id.Location = new Point(133, 11);
            txt_book_id.Margin = new Padding(5, 4, 5, 4);
            txt_book_id.Name = "txt_book_id";
            txt_book_id.ReadOnly = true;
            txt_book_id.Size = new Size(223, 35);
            txt_book_id.TabIndex = 8;
            // 
            // cBox_language
            // 
            cBox_language.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_language.Enabled = false;
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(834, 11);
            cBox_language.Margin = new Padding(5, 4, 5, 4);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(137, 35);
            cBox_language.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(718, 15);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.None;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(359, 6);
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
            btnLastPage.Anchor = AnchorStyles.None;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(548, 5);
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
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(448, 5);
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
            btnFirstPage.Anchor = AnchorStyles.None;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(149, 5);
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
            btnPrePage.Anchor = AnchorStyles.None;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(250, 5);
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
            panelMid.Controls.Add(tableLayoutPanelMain);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 56);
            panelMid.Margin = new Padding(3, 4, 3, 4);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1208, 249);
            panelMid.TabIndex = 54;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(panelImage, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelMainInputAndButton, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1208, 249);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(ptbChonAnh);
            panelImage.Controls.Add(btnChonAnh);
            panelImage.Location = new Point(3, 3);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(214, 239);
            panelImage.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Enabled = false;
            btnChonAnh.Location = new Point(61, 183);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 36;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // tableLayoutPanelMainInputAndButton
            // 
            tableLayoutPanelMainInputAndButton.ColumnCount = 1;
            tableLayoutPanelMainInputAndButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMainInputAndButton.Controls.Add(panelMainButton, 0, 1);
            tableLayoutPanelMainInputAndButton.Controls.Add(tableLayoutPanelMainInput, 0, 0);
            tableLayoutPanelMainInputAndButton.Dock = DockStyle.Fill;
            tableLayoutPanelMainInputAndButton.Location = new Point(223, 3);
            tableLayoutPanelMainInputAndButton.Name = "tableLayoutPanelMainInputAndButton";
            tableLayoutPanelMainInputAndButton.RowCount = 2;
            tableLayoutPanelMainInputAndButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMainInputAndButton.RowStyles.Add(new RowStyle());
            tableLayoutPanelMainInputAndButton.Size = new Size(982, 243);
            tableLayoutPanelMainInputAndButton.TabIndex = 1;
            // 
            // panelMainButton
            // 
            panelMainButton.Anchor = AnchorStyles.None;
            panelMainButton.Controls.Add(btnUpdate);
            panelMainButton.Controls.Add(btnXoa);
            panelMainButton.Controls.Add(btnLuu);
            panelMainButton.Controls.Add(btnHuy);
            panelMainButton.Controls.Add(btnThemTacGia);
            panelMainButton.Location = new Point(87, 183);
            panelMainButton.Name = "panelMainButton";
            panelMainButton.Size = new Size(807, 57);
            panelMainButton.TabIndex = 0;
            // 
            // tableLayoutPanelMainInput
            // 
            tableLayoutPanelMainInput.ColumnCount = 6;
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMainInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanelMainInput.Controls.Add(cBox_Publisher, 5, 2);
            tableLayoutPanelMainInput.Controls.Add(label11, 4, 2);
            tableLayoutPanelMainInput.Controls.Add(label1, 0, 0);
            tableLayoutPanelMainInput.Controls.Add(label5, 0, 1);
            tableLayoutPanelMainInput.Controls.Add(label3, 0, 2);
            tableLayoutPanelMainInput.Controls.Add(txt_book_id, 1, 0);
            tableLayoutPanelMainInput.Controls.Add(cBox_Status, 3, 2);
            tableLayoutPanelMainInput.Controls.Add(cBox_Caterogy, 1, 1);
            tableLayoutPanelMainInput.Controls.Add(label7, 4, 1);
            tableLayoutPanelMainInput.Controls.Add(cBox_Author, 1, 2);
            tableLayoutPanelMainInput.Controls.Add(label6, 4, 0);
            tableLayoutPanelMainInput.Controls.Add(label2, 2, 0);
            tableLayoutPanelMainInput.Controls.Add(txt_quantity, 5, 1);
            tableLayoutPanelMainInput.Controls.Add(txt_title, 3, 1);
            tableLayoutPanelMainInput.Controls.Add(label10, 2, 1);
            tableLayoutPanelMainInput.Controls.Add(cBox_language, 5, 0);
            tableLayoutPanelMainInput.Controls.Add(label9, 2, 2);
            tableLayoutPanelMainInput.Controls.Add(txt_book_name, 3, 0);
            tableLayoutPanelMainInput.Dock = DockStyle.Fill;
            tableLayoutPanelMainInput.Location = new Point(3, 3);
            tableLayoutPanelMainInput.Name = "tableLayoutPanelMainInput";
            tableLayoutPanelMainInput.RowCount = 3;
            tableLayoutPanelMainInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMainInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelMainInput.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelMainInput.Size = new Size(976, 174);
            tableLayoutPanelMainInput.TabIndex = 1;
            // 
            // cBox_Publisher
            // 
            cBox_Publisher.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_Publisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Publisher.Enabled = false;
            cBox_Publisher.FormattingEnabled = true;
            cBox_Publisher.Location = new Point(832, 130);
            cBox_Publisher.Name = "cBox_Publisher";
            cBox_Publisher.Size = new Size(141, 28);
            cBox_Publisher.TabIndex = 42;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(740, 131);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 27);
            label11.TabIndex = 41;
            label11.Text = "NXB";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 131);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 31;
            label3.Text = "Tên tác giả";
            // 
            // cBox_Status
            // 
            cBox_Status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Status.Enabled = false;
            cBox_Status.FormattingEnabled = true;
            cBox_Status.Location = new Point(483, 130);
            cBox_Status.Name = "cBox_Status";
            cBox_Status.Size = new Size(227, 28);
            cBox_Status.TabIndex = 40;
            // 
            // cBox_Caterogy
            // 
            cBox_Caterogy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_Caterogy.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Caterogy.Enabled = false;
            cBox_Caterogy.FormattingEnabled = true;
            cBox_Caterogy.Location = new Point(131, 72);
            cBox_Caterogy.Name = "cBox_Caterogy";
            cBox_Caterogy.Size = new Size(227, 28);
            cBox_Caterogy.TabIndex = 39;
            // 
            // cBox_Author
            // 
            cBox_Author.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBox_Author.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_Author.Enabled = false;
            cBox_Author.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Author.FormattingEnabled = true;
            cBox_Author.Location = new Point(133, 127);
            cBox_Author.Margin = new Padding(5, 4, 5, 4);
            cBox_Author.Name = "cBox_Author";
            cBox_Author.Size = new Size(223, 35);
            cBox_Author.TabIndex = 32;
            // 
            // txt_quantity
            // 
            txt_quantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(834, 68);
            txt_quantity.Margin = new Padding(5, 4, 5, 4);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.ReadOnly = true;
            txt_quantity.Size = new Size(137, 35);
            txt_quantity.TabIndex = 30;
            // 
            // txt_title
            // 
            txt_title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_title.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_title.Location = new Point(485, 68);
            txt_title.Margin = new Padding(5, 4, 5, 4);
            txt_title.Name = "txt_title";
            txt_title.ReadOnly = true;
            txt_title.Size = new Size(223, 35);
            txt_title.TabIndex = 38;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(379, 72);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 27);
            label10.TabIndex = 37;
            label10.Text = "Tiêu đề";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(366, 131);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 27);
            label9.TabIndex = 33;
            label9.Text = "Trạng thái";
            // 
            // panelBot
            // 
            panelBot.Controls.Add(tableLayoutPanelFooter);
            panelBot.Dock = DockStyle.Fill;
            panelBot.Location = new Point(0, 305);
            panelBot.Margin = new Padding(3, 4, 3, 4);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1208, 484);
            panelBot.TabIndex = 55;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 1;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.Controls.Add(panelFooterButton, 0, 1);
            tableLayoutPanelFooter.Controls.Add(dgvSach, 0, 0);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(0, 0);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle());
            tableLayoutPanelFooter.Size = new Size(1208, 484);
            tableLayoutPanelFooter.TabIndex = 54;
            // 
            // panelFooterButton
            // 
            panelFooterButton.Anchor = AnchorStyles.None;
            panelFooterButton.Controls.Add(btnLastPage);
            panelFooterButton.Controls.Add(btnNextPage);
            panelFooterButton.Controls.Add(btnFirstPage);
            panelFooterButton.Controls.Add(txtNumberPage);
            panelFooterButton.Controls.Add(btnPrePage);
            panelFooterButton.Location = new Point(277, 435);
            panelFooterButton.Name = "panelFooterButton";
            panelFooterButton.Size = new Size(654, 46);
            panelFooterButton.TabIndex = 55;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.CustomizableEdges = customizableEdges1;
            ptbChonAnh.ImageRotate = 0F;
            ptbChonAnh.Location = new Point(43, 14);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ptbChonAnh.Size = new Size(137, 161);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 37;
            ptbChonAnh.TabStop = false;
            // 
            // formQuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 789);
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
            tableLayoutPanelMain.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            tableLayoutPanelMainInputAndButton.ResumeLayout(false);
            panelMainButton.ResumeLayout(false);
            tableLayoutPanelMainInput.ResumeLayout(false);
            tableLayoutPanelMainInput.PerformLayout();
            panelBot.ResumeLayout(false);
            tableLayoutPanelFooter.ResumeLayout(false);
            panelFooterButton.ResumeLayout(false);
            panelFooterButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
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
        private Button btnChonAnh;
        private TextBox txt_title;
        private Label label10;
        private ComboBox cBox_Caterogy;
        private ComboBox cBox_Status;
        private ComboBox cBox_Publisher;
        private Label label11;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelImage;
        private TableLayoutPanel tableLayoutPanelMainInputAndButton;
        private Panel panelMainButton;
        private TableLayoutPanel tableLayoutPanelMainInput;
        private TableLayoutPanel tableLayoutPanelFooter;
        private Panel panelFooterButton;
        private Guna.UI2.WinForms.Guna2PictureBox ptbChonAnh;
    }
}