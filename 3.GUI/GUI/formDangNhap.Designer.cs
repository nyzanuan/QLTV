
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
            pictureBox4 = new PictureBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ImageAlign = ContentAlignment.MiddleRight;
            btn_login.Location = new Point(111, 402);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(178, 55);
            btn_login.TabIndex = 0;
            btn_login.Text = "Đăng nhập";
            btn_login.TextAlign = ContentAlignment.MiddleLeft;
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
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(127, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 312);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(247, 41);
            txtPassword.TabIndex = 7;
            // 
            // lblNoti
            // 
            lblNoti.AutoSize = true;
            lblNoti.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoti.ForeColor = Color.IndianRed;
            lblNoti.Location = new Point(127, 373);
            lblNoti.Name = "lblNoti";
            lblNoti.Size = new Size(0, 26);
            lblNoti.TabIndex = 9;
            lblNoti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = _3.GUI.Properties.Resources.login1;
            pictureBox4.Location = new Point(236, 414);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.Location = new Point(306, 402);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(122, 55);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // formLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(561, 492);
            Controls.Add(btnThoat);
            Controls.Add(pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox4;
        private Button btnThoat;
    }
}

