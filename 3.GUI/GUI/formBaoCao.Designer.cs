namespace _3.GUI.GUI
{
    partial class formBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBaoCao));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label4 = new Label();
            cbxBaoCao = new ComboBox();
            btnXemChiTiet = new Button();
            dgvBaoCao = new DataGridView();
            btnBaoCao = new Button();
            printPreviewBaoCao = new PrintPreviewDialog();
            printCB0 = new System.Drawing.Printing.PrintDocument();
            printCB1 = new System.Drawing.Printing.PrintDocument();
            printCB2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(466, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 45);
            label1.TabIndex = 0;
            label1.Text = "Lập báo cáo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 27);
            label2.TabIndex = 1;
            label2.Text = "Từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 2;
            label3.Text = "Đến";
            // 
            // dtpStart
            // 
            dtpStart.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Location = new Point(202, 81);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(314, 35);
            dtpStart.TabIndex = 3;
            dtpStart.Value = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Location = new Point(665, 81);
            dtpEnd.Margin = new Padding(3, 4, 3, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(314, 35);
            dtpEnd.TabIndex = 4;
            dtpEnd.Value = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 160);
            label4.Name = "label4";
            label4.Size = new Size(105, 27);
            label4.TabIndex = 5;
            label4.Text = "Chọn loại";
            // 
            // cbxBaoCao
            // 
            cbxBaoCao.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBaoCao.FormattingEnabled = true;
            cbxBaoCao.Items.AddRange(new object[] { "Danh sách mượn sách", "Sách được mượn nhiều nhất", "Số lượng sách hiện có" });
            cbxBaoCao.Location = new Point(371, 149);
            cbxBaoCao.Margin = new Padding(3, 4, 3, 4);
            cbxBaoCao.Name = "cbxBaoCao";
            cbxBaoCao.Size = new Size(309, 30);
            cbxBaoCao.TabIndex = 6;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemChiTiet.Location = new Point(1007, 149);
            btnXemChiTiet.Margin = new Padding(3, 4, 3, 4);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(137, 36);
            btnXemChiTiet.TabIndex = 7;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToOrderColumns = true;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(1, 215);
            dgvBaoCao.Margin = new Padding(3, 4, 3, 4);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.RowTemplate.Height = 25;
            dgvBaoCao.Size = new Size(1195, 612);
            dgvBaoCao.TabIndex = 8;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaoCao.Location = new Point(688, 149);
            btnBaoCao.Margin = new Padding(3, 4, 3, 4);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(137, 36);
            btnBaoCao.TabIndex = 9;
            btnBaoCao.Text = "Tạo báo cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // printPreviewBaoCao
            // 
            printPreviewBaoCao.AutoScrollMargin = new Size(0, 0);
            printPreviewBaoCao.AutoScrollMinSize = new Size(0, 0);
            printPreviewBaoCao.ClientSize = new Size(400, 300);
            printPreviewBaoCao.Enabled = true;
            printPreviewBaoCao.Icon = (Icon)resources.GetObject("printPreviewBaoCao.Icon");
            printPreviewBaoCao.Name = "printPreviewBaoCao";
            printPreviewBaoCao.Visible = false;
            // 
            // printCB0
            // 
            printCB0.PrintPage += printCB0_PrintPage;
            // 
            // printCB1
            // 
            printCB1.PrintPage += printCB1_PrintPage;
            // 
            // printCB2
            // 
            printCB2.PrintPage += printCB2_PrintPage;
            // 
            // formBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 767);
            Controls.Add(btnBaoCao);
            Controls.Add(dgvBaoCao);
            Controls.Add(btnXemChiTiet);
            Controls.Add(cbxBaoCao);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formBaoCao";
            Text = "Báo cáo";
            Load += formBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label4;
        private ComboBox cbxBaoCao;
        private Button btnXemChiTiet;
        private DataGridView dgvBaoCao;
        private Button btnBaoCao;
        private PrintPreviewDialog printPreviewBaoCao;
        private System.Drawing.Printing.PrintDocument printCB0;
        private System.Drawing.Printing.PrintDocument printCB1;
        private System.Drawing.Printing.PrintDocument printCB2;
    }
}