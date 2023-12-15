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
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 36);
            label1.TabIndex = 0;
            label1.Text = "Lập báo cáo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 69);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 1;
            label2.Text = "Từ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(477, 69);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 2;
            label3.Text = "Đến";
            // 
            // dtpStart
            // 
            dtpStart.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Location = new Point(128, 61);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(275, 29);
            dtpStart.TabIndex = 3;
            dtpStart.Value = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Location = new Point(533, 61);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(275, 29);
            dtpEnd.TabIndex = 4;
            dtpEnd.Value = new DateTime(2023, 12, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 121);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 5;
            label4.Text = "Chọn loại";
            // 
            // cbxBaoCao
            // 
            cbxBaoCao.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBaoCao.FormattingEnabled = true;
            cbxBaoCao.Items.AddRange(new object[] { "Danh sách mượn sách", "Sách được mượn nhiều nhất", "Số lượng sách hiện có" });
            cbxBaoCao.Location = new Point(247, 113);
            cbxBaoCao.Name = "cbxBaoCao";
            cbxBaoCao.Size = new Size(271, 27);
            cbxBaoCao.TabIndex = 6;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemChiTiet.Location = new Point(788, 115);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(120, 32);
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
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(1, 161);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowTemplate.Height = 25;
            dgvBaoCao.Size = new Size(922, 433);
            dgvBaoCao.TabIndex = 8;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaoCao.Location = new Point(524, 113);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(120, 32);
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
            // formBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 592);
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
            Name = "formBaoCao";
            Text = "Báo cáo";
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