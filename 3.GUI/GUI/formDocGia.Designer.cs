﻿
namespace QLTV
{
    partial class formDocGia
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
            dgvDocGia = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txt_email = new TextBox();
            label6 = new Label();
            txt_id = new TextBox();
            txt_phone = new TextBox();
            cBox_gioiTinh = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(601, 586);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 43;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(766, 585);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 42;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(679, 585);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 41;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(417, 585);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 39;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(505, 585);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 40;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Location = new Point(-4, 258);
            dgvDocGia.Margin = new Padding(4);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1237, 314);
            dgvDocGia.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 257);
            panel1.TabIndex = 37;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(875, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 49);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 38;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(126, 13);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(171, 29);
            txtTimKiem.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(cBox_gioiTinh);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(47, 47);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1109, 195);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Location = new Point(302, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 65);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(444, 23);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 35;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(336, 23);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 34;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(14, 23);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 33);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(230, 23);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(122, 23);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 33);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(475, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 36;
            label2.Text = "Email";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(587, 28);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(231, 29);
            txt_name.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 21;
            label1.Text = "Mã độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(472, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 22;
            label3.Text = "Tên độc giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(165, 87);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 23;
            label5.Text = "Số điện thoại";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(587, 80);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(231, 29);
            txt_email.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(853, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 24;
            label6.Text = "Giới tính";
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(276, 28);
            txt_id.Margin = new Padding(4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(171, 29);
            txt_id.TabIndex = 25;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(276, 80);
            txt_phone.Margin = new Padding(4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(171, 29);
            txt_phone.TabIndex = 28;
            // 
            // cBox_gioiTinh
            // 
            cBox_gioiTinh.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_gioiTinh.FormattingEnabled = true;
            cBox_gioiTinh.Location = new Point(947, 26);
            cBox_gioiTinh.Margin = new Padding(4);
            cBox_gioiTinh.Name = "cBox_gioiTinh";
            cBox_gioiTinh.Size = new Size(91, 29);
            cBox_gioiTinh.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(442, 4);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(362, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin độc giả";
            // 
            // formDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 618);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvDocGia);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "formDocGia";
            Text = "Độc giả";
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private DataGridView dgvDocGia;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
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
        private Label label2;
        private Label label5;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_phone;
        private ComboBox cBox_gioiTinh;
        private GroupBox groupBox3;
    }
}