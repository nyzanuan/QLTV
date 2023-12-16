﻿namespace _3.GUI.GUI
{
    partial class formTraSach
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
            book_dataGridView = new DataGridView();
            panelTop = new Panel();
            label5 = new Label();
            label8 = new Label();
            txt_search = new TextBox();
            btnHuy = new Button();
            btnTraSach = new Button();
            btnGiaHan = new Button();
            btnLuu = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            borrow_dateTimePicker = new DateTimePicker();
            refund_dateTimePicker = new DateTimePicker();
            extend_dateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            txt_book_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_user_id = new TextBox();
            panelMid = new Panel();
            panelBot = new Panel();
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).BeginInit();
            panelTop.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panelMid.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(509, 299);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 55;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(674, 298);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 54;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(587, 298);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 53;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(325, 298);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 51;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(413, 298);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 52;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // book_dataGridView
            // 
            book_dataGridView.AllowUserToAddRows = false;
            book_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            book_dataGridView.Location = new Point(0, 1);
            book_dataGridView.Margin = new Padding(4, 3, 4, 3);
            book_dataGridView.Name = "book_dataGridView";
            book_dataGridView.Size = new Size(1063, 290);
            book_dataGridView.TabIndex = 50;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(txt_search);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(782, 12);
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
            label8.Location = new Point(461, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(241, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý trả sách";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(882, 4);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(168, 27);
            txt_search.TabIndex = 23;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(637, 182);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(77, 33);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTraSach
            // 
            btnTraSach.Enabled = false;
            btnTraSach.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraSach.Location = new Point(347, 182);
            btnTraSach.Margin = new Padding(4);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(80, 33);
            btnTraSach.TabIndex = 31;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Enabled = false;
            btnGiaHan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiaHan.Location = new Point(446, 182);
            btnGiaHan.Margin = new Padding(4);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(80, 33);
            btnGiaHan.TabIndex = 32;
            btnGiaHan.Text = "Gia Hạn";
            btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(542, 182);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(borrow_dateTimePicker);
            groupBox3.Controls.Add(refund_dateTimePicker);
            groupBox3.Controls.Add(extend_dateTimePicker);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(554, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(475, 158);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gia hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 34);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 24;
            label7.Text = "Ngày mượn";
            // 
            // borrow_dateTimePicker
            // 
            borrow_dateTimePicker.Location = new Point(158, 26);
            borrow_dateTimePicker.Name = "borrow_dateTimePicker";
            borrow_dateTimePicker.Size = new Size(292, 29);
            borrow_dateTimePicker.TabIndex = 23;
            // 
            // refund_dateTimePicker
            // 
            refund_dateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy ";
            refund_dateTimePicker.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            refund_dateTimePicker.Format = DateTimePickerFormat.Custom;
            refund_dateTimePicker.Location = new Point(158, 72);
            refund_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            refund_dateTimePicker.Name = "refund_dateTimePicker";
            refund_dateTimePicker.Size = new Size(293, 29);
            refund_dateTimePicker.TabIndex = 22;
            // 
            // extend_dateTimePicker
            // 
            extend_dateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy ";
            extend_dateTimePicker.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            extend_dateTimePicker.Format = DateTimePickerFormat.Custom;
            extend_dateTimePicker.Location = new Point(158, 118);
            extend_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            extend_dateTimePicker.Name = "extend_dateTimePicker";
            extend_dateTimePicker.Size = new Size(293, 29);
            extend_dateTimePicker.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 2;
            label3.Text = "Ngày gia hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txt_book_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_user_id);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(101, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 158);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trả sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 36;
            label6.Text = "Mã mượn sách";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 29);
            comboBox1.TabIndex = 35;
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(141, 108);
            txt_book_name.Margin = new Padding(4, 3, 4, 3);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.Size = new Size(218, 29);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // txt_user_id
            // 
            txt_user_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_id.Location = new Point(141, 65);
            txt_user_id.Margin = new Padding(4, 3, 4, 3);
            txt_user_id.Name = "txt_user_id";
            txt_user_id.Size = new Size(218, 29);
            txt_user_id.TabIndex = 8;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnTraSach);
            panelMid.Controls.Add(groupBox3);
            panelMid.Controls.Add(groupBox1);
            panelMid.Controls.Add(btnGiaHan);
            panelMid.Controls.Add(btnLuu);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 222);
            panelMid.TabIndex = 56;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(book_dataGridView);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 264);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 340);
            panelBot.TabIndex = 57;
            // 
            // formTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Name = "formTraSach";
            Text = "formTraSach";
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelMid.ResumeLayout(false);
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
        private DataGridView book_dataGridView;
        private Panel panelTop;
        private Label label5;
        private TextBox txt_search;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnGiaHan;
        private Button btnTraSach;
        private DateTimePicker refund_dateTimePicker;
        private DateTimePicker extend_dateTimePicker;
        private Label label4;
        private TextBox txt_book_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user_id;
        private Label label8;
        private Label label6;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private DateTimePicker borrow_dateTimePicker;
        private Label label7;
        private Panel panelMid;
        private Panel panelBot;
    }
}