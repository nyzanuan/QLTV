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
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            txt_name = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txt_id = new TextBox();
            panelTop = new Panel();
            panelMid = new Panel();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Anchor = AnchorStyles.None;
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(535, 351);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 50;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Anchor = AnchorStyles.None;
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(700, 350);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 49;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.None;
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(613, 350);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 48;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Anchor = AnchorStyles.None;
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(351, 350);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 46;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Anchor = AnchorStyles.None;
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(439, 350);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 47;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { COL_ID, COL_NAME });
            dgvTheLoai.Location = new Point(0, 0);
            dgvTheLoai.Margin = new Padding(4);
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.Size = new Size(1063, 343);
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
            COL_ID.Width = 125;
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
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(698, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(798, 4);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(168, 29);
            txtTimKiem.TabIndex = 37;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(364, 3);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(301, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thể loại sách";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(740, 101);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
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
            btnLuu.Location = new Point(632, 101);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(310, 101);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 33);
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
            btnXoa.Location = new Point(526, 101);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
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
            btnUpdate.Location = new Point(418, 101);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 33);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.None;
            txt_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(613, 35);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(231, 29);
            txt_name.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(502, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 22;
            label3.Text = "Tên thể loại";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(218, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 21;
            label1.Text = "Mã thể loại";
            // 
            // txt_id
            // 
            txt_id.Anchor = AnchorStyles.None;
            txt_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(318, 35);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(171, 29);
            txt_id.TabIndex = 25;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 51;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(txt_name);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(btnThem);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(txt_id);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(label1);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 170);
            panelMid.TabIndex = 56;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvTheLoai);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 212);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 383);
            panelBot.TabIndex = 57;
            // 
            // formTheLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Name = "formTheLoai";
            Text = "Thể loại";
            Load += formTheLoai_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
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
        private DataGridView dgvTheLoai;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnUpdate;
        private TextBox txt_name;
        private Label label1;
        private Label label3;
        private TextBox txt_id;
        private Label label8;
        private DataGridViewTextBoxColumn COL_ID;
        private DataGridViewTextBoxColumn COL_NAME;
        private Label label4;
        private TextBox txtTimKiem;
        private Panel panelTop;
        private Panel panelMid;
        private Panel panelBot;
    }
}