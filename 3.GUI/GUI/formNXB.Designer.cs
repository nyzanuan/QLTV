namespace _3.GUI.GUI
{
    partial class formNXB
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
            dgvNXB = new DataGridView();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            COL_IMAGE = new DataGridViewImageColumn();
            label4 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txtDiaChi = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            txtTen = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtMa = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label5 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox4 = new TextBox();
            label9 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            textBox7 = new TextBox();
            label12 = new Label();
            panelHeader = new Panel();
            tableLayoutPanelBodyInput = new TableLayoutPanel();
            btnChonAnh = new Button();
            ptbChonAnh = new PictureBox();
            tableLayoutPanelBody = new TableLayoutPanel();
            panelBodyButton = new Panel();
            tableLooterButtoFooter = new TableLayoutPanel();
            panelFooterButton = new Panel();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPrePage = new Button();
            txtNumberPage = new TextBox();
            btnFirstPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNXB).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panelHeader.SuspendLayout();
            tableLayoutPanelBodyInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).BeginInit();
            tableLayoutPanelBody.SuspendLayout();
            panelBodyButton.SuspendLayout();
            tableLooterButtoFooter.SuspendLayout();
            panelFooterButton.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNXB
            // 
            dgvNXB.AllowUserToAddRows = false;
            dgvNXB.AllowUserToDeleteRows = false;
            dgvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNXB.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME, COL_IMAGE });
            dgvNXB.Dock = DockStyle.Fill;
            dgvNXB.Location = new Point(5, 5);
            dgvNXB.Margin = new Padding(5);
            dgvNXB.Name = "dgvNXB";
            dgvNXB.ReadOnly = true;
            dgvNXB.RowHeadersWidth = 51;
            dgvNXB.Size = new Size(1132, 320);
            dgvNXB.TabIndex = 52;
            dgvNXB.CellClick += dgvNXB_CellClick;
            // 
            // COL_ID
            // 
            COL_ID.DataPropertyName = "PublisherId";
            COL_ID.HeaderText = "Mã";
            COL_ID.MinimumWidth = 6;
            COL_ID.Name = "COL_ID";
            COL_ID.ReadOnly = true;
            // 
            // COL_NAME
            // 
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Tên NXB";
            COL_NAME.MinimumWidth = 6;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            // 
            // COL_IMAGE
            // 
            COL_IMAGE.DataPropertyName = "Image";
            COL_IMAGE.HeaderText = "Hình";
            COL_IMAGE.ImageLayout = DataGridViewImageCellLayout.Zoom;
            COL_IMAGE.MinimumWidth = 6;
            COL_IMAGE.Name = "COL_IMAGE";
            COL_IMAGE.ReadOnly = true;
            COL_IMAGE.Resizable = DataGridViewTriState.True;
            COL_IMAGE.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(715, 35);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(856, 32);
            txtTimKiem.Margin = new Padding(5);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(272, 28);
            txtTimKiem.TabIndex = 37;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 20);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(383, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý nhà xuất bản";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 143);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 37;
            label2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(189, 139);
            txtDiaChi.Margin = new Padding(5);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(371, 35);
            txtDiaChi.TabIndex = 36;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(778, 5);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(655, 5);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(287, 5);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(533, 5);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(410, 5);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTen.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(759, 34);
            txtTen.Margin = new Padding(5);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(372, 35);
            txtTen.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 38);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 27);
            label1.TabIndex = 21;
            label1.Text = "Mã nhà xuất bản";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(570, 38);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 27);
            label3.TabIndex = 22;
            label3.Text = "Tên nhà xuất bản";
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMa.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(189, 34);
            txtMa.Margin = new Padding(5);
            txtMa.Multiline = true;
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(371, 35);
            txtMa.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0270271F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9729729F));
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.MinimumSize = new Size(398, 36);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(398, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(151, 4);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 28);
            textBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 39);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 21;
            label5.Text = "Mã nhà xuất bản";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.09589F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.90411F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 265F));
            tableLayoutPanel5.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(-61, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 23);
            textBox4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(1, 15);
            label9.TabIndex = 0;
            label9.Text = "label9";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.65497F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.34503F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.65497F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.34503F));
            tableLayoutPanel8.Controls.Add(textBox3, 1, 0);
            tableLayoutPanel8.Controls.Add(label7, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(51, 33);
            tableLayoutPanel8.TabIndex = 63;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(17, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(31, 27);
            textBox3.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(8, 33);
            label7.TabIndex = 0;
            label7.Text = "label7";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(60, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(9, 42);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.65497F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.34503F));
            tableLayoutPanel9.Controls.Add(textBox7, 1, 0);
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(200, 100);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(60, 3);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(137, 23);
            textBox7.TabIndex = 2;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(6, 42);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 0;
            label12.Text = "label12";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label8);
            panelHeader.Controls.Add(label4);
            panelHeader.Controls.Add(txtTimKiem);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1142, 125);
            panelHeader.TabIndex = 53;
            // 
            // tableLayoutPanelBodyInput
            // 
            tableLayoutPanelBodyInput.ColumnCount = 4;
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBodyInput.Controls.Add(label1, 0, 0);
            tableLayoutPanelBodyInput.Controls.Add(label2, 0, 1);
            tableLayoutPanelBodyInput.Controls.Add(txtTen, 3, 0);
            tableLayoutPanelBodyInput.Controls.Add(txtMa, 1, 0);
            tableLayoutPanelBodyInput.Controls.Add(label3, 2, 0);
            tableLayoutPanelBodyInput.Controls.Add(txtDiaChi, 1, 1);
            tableLayoutPanelBodyInput.Controls.Add(btnChonAnh, 2, 1);
            tableLayoutPanelBodyInput.Controls.Add(ptbChonAnh, 3, 1);
            tableLayoutPanelBodyInput.Dock = DockStyle.Fill;
            tableLayoutPanelBodyInput.Location = new Point(3, 3);
            tableLayoutPanelBodyInput.Name = "tableLayoutPanelBodyInput";
            tableLayoutPanelBodyInput.RowCount = 2;
            tableLayoutPanelBodyInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.Size = new Size(1136, 209);
            tableLayoutPanelBodyInput.TabIndex = 54;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Anchor = AnchorStyles.None;
            btnChonAnh.Enabled = false;
            btnChonAnh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.Location = new Point(614, 134);
            btnChonAnh.Margin = new Padding(5);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(91, 44);
            btnChonAnh.TabIndex = 66;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // ptbChonAnh
            // 
            ptbChonAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbChonAnh.Location = new Point(757, 107);
            ptbChonAnh.Name = "ptbChonAnh";
            ptbChonAnh.Size = new Size(125, 62);
            ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbChonAnh.TabIndex = 67;
            ptbChonAnh.TabStop = false;
            // 
            // tableLayoutPanelBody
            // 
            tableLayoutPanelBody.ColumnCount = 1;
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBody.Controls.Add(panelBodyButton, 0, 1);
            tableLayoutPanelBody.Controls.Add(tableLayoutPanelBodyInput, 0, 0);
            tableLayoutPanelBody.Dock = DockStyle.Top;
            tableLayoutPanelBody.Location = new Point(0, 125);
            tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            tableLayoutPanelBody.RowCount = 2;
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBody.RowStyles.Add(new RowStyle());
            tableLayoutPanelBody.Size = new Size(1142, 275);
            tableLayoutPanelBody.TabIndex = 55;
            // 
            // panelBodyButton
            // 
            panelBodyButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBodyButton.Controls.Add(btnHuy);
            panelBodyButton.Controls.Add(btnXoa);
            panelBodyButton.Controls.Add(btnUpdate);
            panelBodyButton.Controls.Add(btnThem);
            panelBodyButton.Controls.Add(btnLuu);
            panelBodyButton.Location = new Point(3, 218);
            panelBodyButton.Name = "panelBodyButton";
            panelBodyButton.Size = new Size(1136, 54);
            panelBodyButton.TabIndex = 56;
            // 
            // tableLooterButtoFooter
            // 
            tableLooterButtoFooter.ColumnCount = 1;
            tableLooterButtoFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLooterButtoFooter.Controls.Add(panelFooterButton, 0, 1);
            tableLooterButtoFooter.Controls.Add(dgvNXB, 0, 0);
            tableLooterButtoFooter.Dock = DockStyle.Fill;
            tableLooterButtoFooter.Location = new Point(0, 400);
            tableLooterButtoFooter.Name = "tableLooterButtoFooter";
            tableLooterButtoFooter.RowCount = 2;
            tableLooterButtoFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLooterButtoFooter.RowStyles.Add(new RowStyle());
            tableLooterButtoFooter.Size = new Size(1142, 389);
            tableLooterButtoFooter.TabIndex = 56;
            // 
            // panelFooterButton
            // 
            panelFooterButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelFooterButton.Controls.Add(btnLastPage);
            panelFooterButton.Controls.Add(btnNextPage);
            panelFooterButton.Controls.Add(btnPrePage);
            panelFooterButton.Controls.Add(txtNumberPage);
            panelFooterButton.Controls.Add(btnFirstPage);
            panelFooterButton.Location = new Point(3, 333);
            panelFooterButton.Name = "panelFooterButton";
            panelFooterButton.Size = new Size(1136, 53);
            panelFooterButton.TabIndex = 57;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.None;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(722, 11);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 54;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(623, 11);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 53;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.None;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(424, 11);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 52;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.None;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(533, 12);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 55;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.None;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(323, 11);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 51;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // formNXB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 789);
            Controls.Add(tableLooterButtoFooter);
            Controls.Add(tableLayoutPanelBody);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formNXB";
            Text = "Nhà xuất bản";
            Load += formNXB_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvNXB).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelBodyInput.ResumeLayout(false);
            tableLayoutPanelBodyInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbChonAnh).EndInit();
            tableLayoutPanelBody.ResumeLayout(false);
            panelBodyButton.ResumeLayout(false);
            tableLooterButtoFooter.ResumeLayout(false);
            panelFooterButton.ResumeLayout(false);
            panelFooterButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvNXB;
        private Label label4;
        private TextBox txtTimKiem;
        private Label label2;
        private TextBox txtDiaChi;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private TextBox txtTen;
        private Label label1;
        private Label label3;
        private TextBox txtMa;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox4;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox textBox7;
        private Label label12;
        private Panel panelHeader;
        private TableLayoutPanel tableLayoutPanelBodyInput;
        private TableLayoutPanel tableLayoutPanelBody;
        private Panel panelBodyButton;
        private TableLayoutPanel tableLooterButtoFooter;
        private Panel panelFooterButton;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPrePage;
        private TextBox txtNumberPage;
        private Button btnFirstPage;
        private Button btnChonAnh;
        private PictureBox ptbChonAnh;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private DataGridViewImageColumn COL_IMAGE;
    }
}