
namespace QLTV
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            btn_login = new Button();
            txtAccount = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            lblNoti = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(209, 406);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(155, 55);
            btn_login.TabIndex = 0;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(191, 247);
            txtAccount.Multiline = true;
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(247, 41);
            txtAccount.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(127, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(127, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 312);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 41);
            txtPassword.TabIndex = 7;
            // 
            // lblNoti
            // 
            lblNoti.AutoSize = true;
            lblNoti.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoti.ForeColor = Color.IndianRed;
            lblNoti.Location = new Point(91, 377);
            lblNoti.Name = "lblNoti";
            lblNoti.Size = new Size(0, 26);
            lblNoti.TabIndex = 9;
            lblNoti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 492);
            Controls.Add(lblNoti);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtAccount);
            Controls.Add(btn_login);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += formLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txtAccount;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private Label lblNoti;
    }
}

