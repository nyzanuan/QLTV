namespace _3.GUI.GUI.Component
{
    partial class frmThongTinSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinSach));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            ptbHinhAnh = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(ptbHinhAnh, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(301, 365);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 326);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 17);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Sách về tình yêu tuổi học trò, xin chao cacac ";
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Dock = DockStyle.Fill;
            ptbHinhAnh.Image = (Image)resources.GetObject("ptbHinhAnh.Image");
            ptbHinhAnh.Location = new Point(3, 3);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(295, 299);
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHinhAnh.TabIndex = 0;
            ptbHinhAnh.TabStop = false;
            // 
            // frmThongTinSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 365);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinSach";
            Text = "frmThongTinSach";
            Load += frmThongTinSach_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ptbHinhAnh;
        private Label lblTitle;
    }
}