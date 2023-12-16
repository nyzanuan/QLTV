namespace _3.GUI.GUI.Component
{
    partial class BookControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ptbAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            rating = new Guna.UI2.WinForms.Guna2RatingStar();
            lblTenSach = new Guna.UI2.WinForms.Guna2HtmlLabel();
            labelConLai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // ptbAnh
            // 
            ptbAnh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ptbAnh.CustomizableEdges = customizableEdges1;
            ptbAnh.ImageRotate = 0F;
            ptbAnh.Location = new Point(20, 12);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ptbAnh.Size = new Size(288, 322);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 0;
            ptbAnh.TabStop = false;
            // 
            // rating
            // 
            rating.Anchor = AnchorStyles.None;
            rating.Location = new Point(62, 340);
            rating.Name = "rating";
            rating.RatingColor = Color.Red;
            rating.Size = new Size(193, 36);
            rating.TabIndex = 1;
            // 
            // lblTenSach
            // 
            lblTenSach.Anchor = AnchorStyles.None;
            lblTenSach.BackColor = Color.Transparent;
            lblTenSach.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenSach.Location = new Point(65, 418);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(153, 25);
            lblTenSach.TabIndex = 2;
            lblTenSach.Text = "guna2HtmlLabel1";
            lblTenSach.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // labelConLai
            // 
            labelConLai.Anchor = AnchorStyles.None;
            labelConLai.BackColor = Color.Transparent;
            labelConLai.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelConLai.Location = new Point(81, 382);
            labelConLai.Name = "labelConLai";
            labelConLai.Size = new Size(137, 21);
            labelConLai.TabIndex = 3;
            labelConLai.Text = "guna2HtmlLabel1";
            labelConLai.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(labelConLai);
            Controls.Add(lblTenSach);
            Controls.Add(rating);
            Controls.Add(ptbAnh);
            Name = "BookControl";
            Size = new Size(325, 465);
            Load += BookControl_Load;
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptbAnh;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSach;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelConLai;
    }
}
