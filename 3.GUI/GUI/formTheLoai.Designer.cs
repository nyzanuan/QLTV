namespace _3.GUI.GUI
{
    partial class formTheLoai
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
            dgvTheLoai = new DataGridView();
            COL_ID = new DataGridViewTextBoxColumn();
            COL_NAME = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            panelTop = new Panel();
            panelMid = new Panel();
            tableLayoutPanelBody = new TableLayoutPanel();
            tableLayoutPanelBodyInput = new TableLayoutPanel();
            txt_name = new TextBox();
            label1 = new Label();
            txt_id = new TextBox();
            label3 = new Label();
            panelBodyButton = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            btnUpdate = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panelBot = new Panel();
            tableLayoutPanelFooter = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            tableLayoutPanelBody.SuspendLayout();
            tableLayoutPanelBodyInput.SuspendLayout();
            panelBodyButton.SuspendLayout();
            panelBot.SuspendLayout();
            tableLayoutPanelFooter.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.None;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(607, 7);
            txtNumberPage.Margin = new Padding(5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 50;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.None;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(796, 6);
            btnLastPage.Margin = new Padding(5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 49;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(697, 6);
            btnNextPage.Margin = new Padding(5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 48;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.None;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(397, 6);
            btnFirstPage.Margin = new Padding(5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 46;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.None;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(498, 6);
            btnPrePage.Margin = new Padding(5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 47;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME });
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.Location = new Point(5, 5);
            dgvTheLoai.Margin = new Padding(5);
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.Size = new Size(1284, 453);
            dgvTheLoai.TabIndex = 45;
            dgvTheLoai.CellClick += dgvTheLoai_CellClick;
            dgvTheLoai.CellContentClick += dgvTheLoai_CellContentClick;
            // 
            // COL_ID
            // 
            COL_ID.DataPropertyName = "CategoryId";
            COL_ID.HeaderText = "Mã";
            COL_ID.MinimumWidth = 10;
            COL_ID.Name = "COL_ID";
            COL_ID.ReadOnly = true;
            // 
            // COL_NAME
            // 
            COL_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COL_NAME.DataPropertyName = "Name";
            COL_NAME.HeaderText = "Thể loại";
            COL_NAME.MinimumWidth = 50;
            COL_NAME.Name = "COL_NAME";
            COL_NAME.ReadOnly = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(877, 9);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(991, 5);
            txtTimKiem.Margin = new Padding(5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(289, 35);
            txtTimKiem.TabIndex = 37;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 0);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(372, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thể loại sách";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1294, 56);
            panelTop.TabIndex = 51;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(tableLayoutPanelBody);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 56);
            panelMid.Margin = new Padding(3, 4, 3, 4);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1294, 227);
            panelMid.TabIndex = 56;
            // 
            // tableLayoutPanelBody
            // 
            tableLayoutPanelBody.ColumnCount = 1;
            tableLayoutPanelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBody.Controls.Add(tableLayoutPanelBodyInput, 0, 0);
            tableLayoutPanelBody.Controls.Add(panelBodyButton, 0, 1);
            tableLayoutPanelBody.Dock = DockStyle.Fill;
            tableLayoutPanelBody.Location = new Point(0, 0);
            tableLayoutPanelBody.Name = "tableLayoutPanelBody";
            tableLayoutPanelBody.RowCount = 2;
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBody.Size = new Size(1294, 227);
            tableLayoutPanelBody.TabIndex = 0;
            // 
            // tableLayoutPanelBodyInput
            // 
            tableLayoutPanelBodyInput.ColumnCount = 4;
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelBodyInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBodyInput.Controls.Add(txt_name, 3, 0);
            tableLayoutPanelBodyInput.Controls.Add(label1, 0, 0);
            tableLayoutPanelBodyInput.Controls.Add(txt_id, 1, 0);
            tableLayoutPanelBodyInput.Controls.Add(label3, 2, 0);
            tableLayoutPanelBodyInput.Dock = DockStyle.Fill;
            tableLayoutPanelBodyInput.Location = new Point(3, 3);
            tableLayoutPanelBodyInput.Name = "tableLayoutPanelBodyInput";
            tableLayoutPanelBodyInput.RowCount = 1;
            tableLayoutPanelBodyInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBodyInput.Size = new Size(1288, 107);
            tableLayoutPanelBodyInput.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(782, 36);
            txt_name.Margin = new Padding(5);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(501, 35);
            txt_name.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 21;
            label1.Text = "Mã thể loại";
            // 
            // txt_id
            // 
            txt_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(136, 36);
            txt_id.Margin = new Padding(5);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(500, 35);
            txt_id.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(646, 40);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 22;
            label3.Text = "Tên thể loại";
            // 
            // panelBodyButton
            // 
            panelBodyButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBodyButton.Controls.Add(btnHuy);
            panelBodyButton.Controls.Add(btnLuu);
            panelBodyButton.Controls.Add(btnUpdate);
            panelBodyButton.Controls.Add(btnXoa);
            panelBodyButton.Controls.Add(btnThem);
            panelBodyButton.Location = new Point(3, 142);
            panelBodyButton.Name = "panelBodyButton";
            panelBodyButton.Size = new Size(1288, 56);
            panelBodyButton.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(842, 7);
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
            btnLuu.Location = new Point(718, 7);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(474, 7);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(597, 7);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(350, 7);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(tableLayoutPanelFooter);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 283);
            panelBot.Margin = new Padding(3, 4, 3, 4);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1294, 511);
            panelBot.TabIndex = 57;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 1;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.Controls.Add(panel1, 0, 1);
            tableLayoutPanelFooter.Controls.Add(dgvTheLoai, 0, 0);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(0, 0);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle());
            tableLayoutPanelFooter.Size = new Size(1294, 511);
            tableLayoutPanelFooter.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnLastPage);
            panel1.Controls.Add(btnNextPage);
            panel1.Controls.Add(btnPrePage);
            panel1.Controls.Add(txtNumberPage);
            panel1.Controls.Add(btnFirstPage);
            panel1.Location = new Point(3, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 42);
            panel1.TabIndex = 52;
            // 
            // formTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 789);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formTheLoai";
            Text = "Thể loại";
            Load += formTheLoai_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMid.ResumeLayout(false);
            tableLayoutPanelBody.ResumeLayout(false);
            tableLayoutPanelBodyInput.ResumeLayout(false);
            tableLayoutPanelBodyInput.PerformLayout();
            panelBodyButton.ResumeLayout(false);
            panelBot.ResumeLayout(false);
            tableLayoutPanelFooter.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvTheLoai;
        private Label label8;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private Label label4;
        private TextBox txtTimKiem;
        private Panel panelTop;
        private Panel panelMid;
        private Panel panelBot;
        private TextBox txt_name;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Button btnUpdate;
        private TextBox txt_id;
        private Button btnLuu;
        private Label label1;
        private TableLayoutPanel tableLayoutPanelBody;
        private TableLayoutPanel tableLayoutPanelBodyInput;
        private Panel panelBodyButton;
        private TableLayoutPanel tableLayoutPanelFooter;
        private Panel panel1;
    }
}