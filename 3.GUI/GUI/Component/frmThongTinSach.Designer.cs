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
            panel1 = new Panel();
            ptbHinhAnh = new PictureBox();
            lblTenSach = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTenSach);
            panel1.Controls.Add(ptbHinhAnh);
            panel1.Location = new Point(9, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 349);
            panel1.TabIndex = 0;
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Location = new Point(9, 6);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(240, 287);
            ptbHinhAnh.TabIndex = 0;
            ptbHinhAnh.TabStop = false;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenSach.Location = new Point(82, 311);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(84, 28);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên sách";
            lblTenSach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmThongTinSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 365);
            Controls.Add(panel1);
            Name = "frmThongTinSach";
            Text = "frmThongTinSach";
            Load += frmThongTinSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTenSach;
        private PictureBox ptbHinhAnh;
    }
}