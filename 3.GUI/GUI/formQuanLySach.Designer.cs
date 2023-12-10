
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
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            cBox_Author = new ComboBox();
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
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(-5, 248);
            dgvSach.Margin = new Padding(4, 3, 4, 3);
            dgvSach.Name = "dgvSach";
            dgvSach.Size = new Size(1237, 314);
            dgvSach.TabIndex = 38;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 258);
            panel1.TabIndex = 37;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuy);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnThemTacGia);
            groupBox3.Location = new Point(378, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 59);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Enabled = false;
            btnHuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(410, 17);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(91, 44);
            btnHuy.TabIndex = 29;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(309, 17);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 44);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(207, 17);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 44);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(109, 17);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 44);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTacGia.Location = new Point(7, 17);
            btnThemTacGia.Margin = new Padding(4);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(91, 44);
            btnThemTacGia.TabIndex = 17;
            btnThemTacGia.Text = "Thêm";
            btnThemTacGia.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
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
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(472, 84);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 29);
            comboBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(367, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 17;
            label5.Text = "Thể loại";
            // 
            // cBox_Author
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(932, 30);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 29);
            comboBox1.TabIndex = 16;
            // 
            // txt_book_name
            // 
            txt_book_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_book_name.Location = new Point(472, 31);
            txt_book_name.Margin = new Padding(4, 3, 4, 3);
            txt_book_name.Name = "txt_book_name";
            txt_book_name.ReadOnly = true;
            txt_book_name.Size = new Size(289, 35);
            txt_book_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 27);
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
            label2.Size = new Size(98, 27);
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
            label3.Size = new Size(118, 27);
            label3.TabIndex = 2;
            label3.Text = "Tên tác giả";
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(794, 84);
            txt_quantity.Margin = new Padding(4, 3, 4, 3);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(86, 29);
            txt_quantity.TabIndex = 15;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(693, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 27);
            label7.TabIndex = 14;
            label7.Text = "Số lượng ";
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
            // cBox_language
            // 
            cBox_language.Enabled = false;
            cBox_language.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_language.FormattingEnabled = true;
            cBox_language.Location = new Point(137, 84);
            cBox_language.Margin = new Padding(4, 3, 4, 3);
            cBox_language.Name = "cBox_language";
            cBox_language.Size = new Size(160, 29);
            cBox_language.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 93);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 6;
            label6.Text = "Ngôn ngữ";
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
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(595, 576);
            txtNumberPage.Margin = new Padding(4);
            txtNumberPage.Multiline = true;
            txtNumberPage.Name = "txtNumberPage";
            txtNumberPage.Size = new Size(75, 27);
            txtNumberPage.TabIndex = 53;
            txtNumberPage.Text = "0/0";
            txtNumberPage.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastPage.Location = new Point(760, 575);
            btnLastPage.Margin = new Padding(4);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(91, 31);
            btnLastPage.TabIndex = 52;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(673, 575);
            btnNextPage.Margin = new Padding(4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(91, 31);
            btnNextPage.TabIndex = 51;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFirstPage.Location = new Point(411, 575);
            btnFirstPage.Margin = new Padding(4);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(91, 31);
            btnFirstPage.TabIndex = 49;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrePage.Location = new Point(499, 575);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(91, 31);
            btnPrePage.TabIndex = 50;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 610);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(dgvSach);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formQuanLySach";
            Text = "Quản lý sách";
            Load += formQuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
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
        private ComboBox cBox_Caterogy;
        private Label label5;
        private GroupBox groupBox3;
    }
}