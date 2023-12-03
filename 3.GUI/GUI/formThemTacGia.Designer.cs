namespace _3.GUI.GUI
{
    partial class formThemTacGia
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
            ptbHinhAnh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Location = new Point(213, 36);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(179, 159);
            ptbHinhAnh.TabIndex = 0;
            ptbHinhAnh.TabStop = false;
            ptbHinhAnh.Click += ptbHinhAnh_Click;
            // 
            // formThemTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 538);
            Controls.Add(ptbHinhAnh);
            Name = "formThemTacGia";
            Text = "formThemTacGia";
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbHinhAnh;
    }
}