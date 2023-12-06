
namespace QLTV
{
    partial class formTimKiemDocGia
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
            book_dataGridView = new DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            txt_search = new TextBox();
            txtNumberPage = new TextBox();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnFirstPage = new Button();
            btnPrePage = new Button();
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // book_dataGridView
            // 
            book_dataGridView.AllowUserToAddRows = false;
            book_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            book_dataGridView.Location = new Point(-5, 187);
            book_dataGridView.Margin = new Padding(4, 3, 4, 3);
            book_dataGridView.Name = "book_dataGridView";
            book_dataGridView.Size = new Size(1237, 374);
            book_dataGridView.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_search);
            panel1.Location = new Point(-4, -5);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 200);
            panel1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(469, 13);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(306, 42);
            label8.TabIndex = 19;
            label8.Text = "Danh sách độc giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(322, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(442, 98);
            txt_search.Margin = new Padding(4, 3, 4, 3);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(367, 29);
            txt_search.TabIndex = 8;
            // 
            // txtNumberPage
            // 
            txtNumberPage.Enabled = false;
            txtNumberPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumberPage.Location = new Point(596, 579);
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
            btnLastPage.Location = new Point(756, 576);
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
            btnNextPage.Location = new Point(669, 576);
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
            btnFirstPage.Location = new Point(407, 576);
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
            btnPrePage.Location = new Point(495, 576);
            btnPrePage.Margin = new Padding(4);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(80, 23);
            btnPrePage.TabIndex = 33;
            btnPrePage.Text = "<<";
            btnPrePage.UseVisualStyleBackColor = true;
            // 
            // formTimKiemDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 616);
            Controls.Add(txtNumberPage);
            Controls.Add(btnLastPage);
            Controls.Add(btnNextPage);
            Controls.Add(btnFirstPage);
            Controls.Add(btnPrePage);
            Controls.Add(book_dataGridView);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "formTimKiemDocGia";
            Text = "form1TimKiemDocGia";
            ((System.ComponentModel.ISupportInitialize)book_dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView book_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private TextBox txtNumberPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnFirstPage;
        private Button btnPrePage;
    }
}