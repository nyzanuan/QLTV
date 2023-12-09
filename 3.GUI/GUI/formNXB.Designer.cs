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
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            dgvNXB = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
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
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNXB).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(678, 781);
            txtNumberPage.Margin = new Padding(5, 5, 5, 5);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 57;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(866, 780);
            btnLastPage.Margin = new Padding(5, 5, 5, 5);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 56;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(767, 780);
            btnNextPage.Margin = new Padding(5, 5, 5, 5);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 55;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(467, 780);
            btnFirstPage.Margin = new Padding(5, 5, 5, 5);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 53;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(568, 780);
            btnPrePage.Margin = new Padding(5, 5, 5, 5);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 54;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            dgvNXB.AllowUserToAddRows = false;
            dgvNXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNXB.Location = new Point(-14, 344);
            dgvNXB.Margin = new Padding(5, 5, 5, 5);
            dgvNXB.Name = "dgvNXB";
            dgvNXB.RowHeadersWidth = 51;
            dgvNXB.Size = new Size(1414, 419);
            dgvNXB.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-11, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 342);
            panel1.TabIndex = 51;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1006, 17);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(376, 65);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 28);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(144, 17);
            txtTimKiem.Margin = new Padding(5, 5, 5, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(195, 35);
            txtTimKiem.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(104, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1217, 233);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 112);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 37;
            label2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(339, 101);
            txtDiaChi.Margin = new Padding(5, 5, 5, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(685, 35);
            txtDiaChi.TabIndex = 36;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(839, 167);
            btnHuy.Margin = new Padding(5, 5, 5, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(715, 167);
            btnLuu.Margin = new Padding(5, 5, 5, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(347, 167);
            btnThem.Margin = new Padding(5, 5, 5, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 44);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(594, 167);
            btnXoa.Margin = new Padding(5, 5, 5, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(471, 167);
            btnUpdate.Margin = new Padding(5, 5, 5, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(761, 37);
            txtTen.Margin = new Padding(5, 5, 5, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(263, 35);
            txtTen.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 52);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 27);
            label1.TabIndex = 21;
            label1.Text = "Mã nhà xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(594, 49);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 27);
            label3.TabIndex = 22;
            label3.Text = "Tên nhà xuất bản";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(339, 37);
            txtMa.Margin = new Padding(5, 5, 5, 5);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(195, 35);
            txtMa.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(505, 5);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(383, 45);
            label8.TabIndex = 19;
            label8.Text = "Quản lý nhà xuất bản";
            // 
            // formNXB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 824);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvNXB);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formNXB";
            Text = "Nhà xuất bản";
            Load += formNXB_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNXB).EndInit();
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
        private DataGridView dgvNXB;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
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
    }
}