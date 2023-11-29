
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
            this.book_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // book_dataGridView
            // 
            this.book_dataGridView.AllowUserToAddRows = false;
            this.book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_dataGridView.Location = new System.Drawing.Point(-3, 162);
            this.book_dataGridView.Name = "book_dataGridView";
            this.book_dataGridView.Size = new System.Drawing.Size(1059, 488);
            this.book_dataGridView.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 267);
            this.panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(438, 42);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tìm kiếm thông tin độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(716, 85);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 34);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Tìm ";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(379, 85);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 29);
            this.txt_search.TabIndex = 8;
            // 
            // formTimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 647);
            this.Controls.Add(this.book_dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "formTimKiemDocGia";
            this.Text = "form1TimKiemDocGia";
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView book_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
    }
}