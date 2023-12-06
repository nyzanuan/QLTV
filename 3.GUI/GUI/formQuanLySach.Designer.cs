
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            txt_book_id = new TextBox();
            txt_book_name = new TextBox();
            cBox_language = new ComboBox();
            label7 = new Label();
            txt_quantity = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThemTacGia = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            book_dataGridView = new DataGridView();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 40);
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
            label3.Location = new Point(832, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Tên tác giả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 93);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
            // 
            // txt_book_id
            // 
            txt_book_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_id.Location = new Point(137, 30);
            txt_book_id.Margin = new Padding(4, 3, 4, 3);
            txt_book_id.Name = "txt_book_id";
            txt_book_id.Size = new Size(160, 29);
            txt_book_id.TabIndex = 8;
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(472, 31);
            txt_book_name.Margin = new Padding(4, 3, 4, 3);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.Size = new Size(308, 29);
            txt_book_name.TabIndex = 9;
            // 
            // cBox_language
            // 
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(137, 84);
            cBox_language.Margin = new Padding(4, 3, 4, 3);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(160, 29);
            cBox_language.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(373, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 14;
            label7.Text = "Số lượng";
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(471, 84);
            txt_quantity.Margin = new Padding(4, 3, 4, 3);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(76, 29);
            txt_quantity.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(422, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(325, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin sách";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnThemTacGia);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-9, -6);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 258);
            panel1.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(848, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 51);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 18;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(148, 15);
            txtTimKiem.Margin = new Padding(4, 3, 4, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 29);
            txtTimKiem.TabIndex = 17;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(788, 198);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 33);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(687, 198);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(80, 33);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(585, 198);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 33);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(487, 198);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 33);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(385, 198);
            btnThemTacGia.Margin = new Padding(4);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(80, 33);
            btnThemTacGia.TabIndex = 17;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txt_book_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_quantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_book_id);
            groupBox1.Controls.Add(cBox_language);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(20, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1188, 133);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(932, 30);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 29);
            comboBox1.TabIndex = 16;
            // 
            // book_dataGridView
            // 
            book_dataGridView.AllowUserToAddRows = false;
            book_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            book_dataGridView.Location = new Point(-9, 242);
            book_dataGridView.Margin = new Padding(4, 3, 4, 3);
            book_dataGridView.Name = "book_dataGridView";
            book_dataGridView.Size = new Size(1237, 314);
            book_dataGridView.TabIndex = 21;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(591, 578);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 36;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(751, 575);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 35;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(664, 575);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 34;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(402, 575);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 32;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(490, 575);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 33;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // formQuanLySach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 610);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(book_dataGridView);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formQuanLySach";
            Text = "Quản lý sách";
            Load += formQuanLySach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_book_id;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.ComboBox cBox_language;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView book_dataGridView;
        private GroupBox groupBox1;
        private Button btnThemTacGia;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnUpdate;
        private Label label4;
        private TextBox txtTimKiem;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
    }
}