namespace _3.GUI.GUI
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txt_search = new TextBox();
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnGiaHan = new Button();
            btnTraSach = new Button();
            refund_dateTimePicker = new DateTimePicker();
            borrow_dateTimePicker = new DateTimePicker();
            label4 = new Label();
            txt_book_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_user_id = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(595, 571);
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
            btnLastPage.Location = new Point(760, 570);
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
            btnNextPage.Location = new Point(673, 570);
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
            btnFirstPage.Location = new Point(411, 570);
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
            btnPrePage.Location = new Point(499, 570);
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
            book_dataGridView.Location = new Point(-12, 250);
            book_dataGridView.Margin = new Padding(4, 3, 4, 3);
            book_dataGridView.Name = "book_dataGridView";
            book_dataGridView.Size = new Size(1237, 305);
            book_dataGridView.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-12, -1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 252);
            panel1.TabIndex = 49;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_search);
            groupBox2.Location = new Point(890, -2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 51);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 24;
            label5.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(105, 17);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(204, 27);
            txt_search.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnGiaHan);
            groupBox1.Controls.Add(btnTraSach);
            groupBox1.Controls.Add(refund_dateTimePicker);
            groupBox1.Controls.Add(borrow_dateTimePicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_book_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_user_id);
            groupBox1.Location = new Point(24, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1187, 196);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(720, 155);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(619, 155);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Enabled = false;
            btnGiaHan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiaHan.Location = new Point(524, 155);
            btnGiaHan.Margin = new Padding(4);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(80, 33);
            btnGiaHan.TabIndex = 32;
            btnGiaHan.Text = "Gia Hạn";
            btnGiaHan.UseVisualStyleBackColor = true;
            // 
            // btnTraSach
            // 
            btnTraSach.Enabled = false;
            btnTraSach.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraSach.Location = new Point(419, 155);
            btnTraSach.Margin = new Padding(4);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(80, 33);
            btnTraSach.TabIndex = 31;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            // 
            // refund_dateTimePicker
            // 
            refund_dateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy ";
            refund_dateTimePicker.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            refund_dateTimePicker.Format = DateTimePickerFormat.Custom;
            refund_dateTimePicker.Location = new Point(808, 108);
            refund_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            refund_dateTimePicker.Name = "refund_dateTimePicker";
            refund_dateTimePicker.Size = new Size(293, 29);
            refund_dateTimePicker.TabIndex = 22;
            // 
            // borrow_dateTimePicker
            // 
            borrow_dateTimePicker.CustomFormat = "dddd, MMMM dd, yyyy ";
            borrow_dateTimePicker.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            borrow_dateTimePicker.Format = DateTimePickerFormat.Custom;
            borrow_dateTimePicker.Location = new Point(323, 109);
            borrow_dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            borrow_dateTimePicker.Name = "borrow_dateTimePicker";
            borrow_dateTimePicker.Size = new Size(293, 29);
            borrow_dateTimePicker.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(713, 114);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 20;
            label4.Text = "Ngày trả";
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(808, 47);
            txt_book_name.Margin = new Padding(4, 3, 4, 3);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.Size = new Size(293, 29);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 56);
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
            label2.Location = new Point(710, 56);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(207, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 2;
            label3.Text = "Ngày gia hạn";
            // 
            // txt_user_id
            // 
            txt_user_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_id.Location = new Point(321, 48);
            txt_user_id.Margin = new Padding(4, 3, 4, 3);
            txt_user_id.Name = "txt_user_id";
            txt_user_id.Size = new Size(295, 29);
            txt_user_id.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(478, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(280, 42);
            label8.TabIndex = 19;
            label8.Text = "Quản lý trả sách";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 29);
            comboBox1.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 21);
            label6.TabIndex = 36;
            label6.Text = "Mã mượn sách";
            // 
            // formTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 602);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(book_dataGridView);
            Controls.Add(panel1);
            Name = "formTraSach";
            Text = "formTraSach";
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).EndInit();
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
        private DataGridView book_dataGridView;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txt_search;
        private GroupBox groupBox1;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnGiaHan;
        private Button btnTraSach;
        private DateTimePicker refund_dateTimePicker;
        private DateTimePicker borrow_dateTimePicker;
        private Label label4;
        private TextBox txt_book_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user_id;
        private Label label8;
        private Label label6;
        private ComboBox comboBox1;
    }
}