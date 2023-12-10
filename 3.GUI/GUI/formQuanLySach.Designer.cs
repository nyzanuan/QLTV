
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
            dgvSach = new DataGridView();
            panelTop = new Panel();
            label4 = new Label();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnUpdate = new Button();
            btnThemTacGia = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            txt_book_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            panelBot = new Panel();
            txt_quantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            panelTop.SuspendLayout();
            panelMid.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(0, 1);
            dgvSach.Margin = new Padding(4, 3, 4, 3);
            dgvSach.Name = "dgvSach";
            dgvSach.Size = new Size(1063, 324);
            dgvSach.TabIndex = 38;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(txtTimKiem);
            panelTop.Controls.Add(label8);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1063, 42);
            panelTop.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(782, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 18;
            label4.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(882, 4);
            txtTimKiem.Margin = new Padding(4, 3, 4, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(168, 29);
            txtTimKiem.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(375, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(325, 36);
            label8.TabIndex = 19;
            label8.Text = "Quản lý thông tin sách";
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(734, 135);
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
            btnLuu.Location = new Point(633, 135);
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
            btnXoa.Location = new Point(531, 135);
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
            btnUpdate.Location = new Point(433, 135);
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
            btnThemTacGia.Location = new Point(331, 135);
            btnThemTacGia.Margin = new Padding(4);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(80, 33);
            btnThemTacGia.TabIndex = 17;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(391, 79);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 29);
            comboBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(286, 87);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 17;
            label5.Text = "Thể loại";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(837, 26);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 29);
            comboBox1.TabIndex = 16;
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(391, 26);
            txt_book_name.Margin = new Padding(4, 3, 4, 3);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.Size = new Size(308, 29);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 35);
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
            label2.Location = new Point(286, 35);
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
            label3.Location = new Point(737, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Tên tác giả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(737, 97);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 14;
            label7.Text = "Số lượng";
            // 
            // txt_book_id
            // 
            txt_book_id.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_id.Location = new Point(114, 26);
            txt_book_id.Margin = new Padding(4, 3, 4, 3);
            txt_book_id.Name = "txt_book_id";
            txt_book_id.Size = new Size(139, 29);
            txt_book_id.TabIndex = 8;
            // 
            // cBox_language
            // 
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(114, 80);
            cBox_language.Margin = new Padding(4, 3, 4, 3);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(139, 29);
            cBox_language.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 89);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(527, 333);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(66, 21);
            txtNumberPage.TabIndex = 53;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(692, 332);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(80, 23);
            btnLastPage.TabIndex = 52;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(605, 332);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(80, 23);
            btnNextPage.TabIndex = 51;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(343, 332);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(80, 23);
            btnFirstPage.TabIndex = 49;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(431, 332);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 50;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(txt_quantity);
            panelMid.Controls.Add(txt_book_name);
            panelMid.Controls.Add(btnHuy);
            panelMid.Controls.Add(btnLuu);
            panelMid.Controls.Add(comboBox1);
            panelMid.Controls.Add(label3);
            panelMid.Controls.Add(btnXoa);
            panelMid.Controls.Add(label6);
            panelMid.Controls.Add(btnUpdate);
            panelMid.Controls.Add(cBox_language);
            panelMid.Controls.Add(comboBox2);
            panelMid.Controls.Add(btnThemTacGia);
            panelMid.Controls.Add(label7);
            panelMid.Controls.Add(txt_book_id);
            panelMid.Controls.Add(label1);
            panelMid.Controls.Add(label2);
            panelMid.Controls.Add(label5);
            panelMid.Dock = DockStyle.Top;
            panelMid.Location = new Point(0, 42);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1063, 187);
            panelMid.TabIndex = 54;
            // 
            // panelBot
            // 
            panelBot.Controls.Add(dgvSach);
            panelBot.Controls.Add(btnLastPage);
            panelBot.Controls.Add(txtNumberPage);
            panelBot.Controls.Add(btnPrePage);
            panelBot.Controls.Add(btnFirstPage);
            panelBot.Controls.Add(btnNextPage);
            panelBot.Dock = DockStyle.Top;
            panelBot.Location = new Point(0, 229);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(1063, 362);
            panelBot.TabIndex = 55;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(837, 89);
            txt_quantity.Margin = new Padding(4, 3, 4, 3);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(86, 29);
            txt_quantity.TabIndex = 30;
            // 
            // formQuanLySach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(panelBot);
            Controls.Add(panelMid);
            Controls.Add(panelTop);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formQuanLySach";
            Text = "Quản lý sách";
            Load += formQuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMid.ResumeLayout(false);
            panelMid.PerformLayout();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
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
        private ComboBox comboBox1;
        private TextBox txt_book_name;
        private Label label1;
        private Label label2;
        private Label label3;
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
        private ComboBox comboBox2;
        private Label label5;
        private Panel panelMid;
        private Panel panelBot;
        private TextBox txt_quantity;
    }
}