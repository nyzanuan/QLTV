﻿using _3.GUI.GUI;

namespace QLTV
{
    public partial class formGiaoDien : Form
    {
        public formGiaoDien()
        {
            InitializeComponent();
            hideMenuCon();
        }
        public bool isClose = true;


        Form currentChildForm = null;


        private void OpenForm(Form ChildForm, PictureBox ptb)
        {
            // Đóng form con hiện tại (nếu có)
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm = null;
                panelChild.Controls.Clear();
            }
            if (ptb.Controls.Count > 0)
            {
                foreach (Control control in ptb.Controls)
                {
                    if (control is Form form)
                    {
                        form.Close();
                    }
                }
            }

            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }      

            private void formGiaoDien_Load(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard(panelChild.Width);

            OpenForm(frmDashBoard, ptbIntro);

        }

        public event EventHandler DangXuat;


        private void formGiaoDien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
                Application.Exit();
        }

        private void formGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClose)
            {
                if (MessageBox.Show("Bạn có chắc là muốn thoát chương trình không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void hideMenuCon()
        {

            panelDanhMucCon.Visible = false;
            panelMuonSachCon.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenuCon();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMucCon);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            formDocGia formDocGia = new formDocGia();
            OpenForm(formDocGia, ptbIntro);
            hideMenuCon();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

            formNhanVien formNhanVien = new formNhanVien();
            OpenForm(formNhanVien, ptbIntro);
            hideMenuCon();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {

            formTacGia formTacGia = new formTacGia();
            OpenForm(formTacGia, ptbIntro);
            hideMenuCon();
        }

        private void btnTheLoaiSach_Click(object sender, EventArgs e)
        {
            formTheLoai formTheLoai = new formTheLoai();
            OpenForm(formTheLoai, ptbIntro);
            hideMenuCon();

        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            formNXB formNXB = new formNXB();
            OpenForm(formNXB, ptbIntro);
            hideMenuCon();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            formQuanLySach formQuanLySach = new formQuanLySach();
            OpenForm(formQuanLySach, ptbIntro);
            hideMenuCon();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            formMuonSach formMuonSach = new formMuonSach();
            OpenForm(formMuonSach, ptbIntro);
            hideMenuCon();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            formTraSach formTraSach = new formTraSach();
            OpenForm(formTraSach, ptbIntro);
            hideMenuCon();
        }

        private void btnMTSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMuonSachCon);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            formBaoCao formBaoCao = new formBaoCao();
            OpenForm(formBaoCao, ptbIntro);
            hideMenuCon();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            try
            {
                DangXuat(this, new EventArgs());
            }
            catch
            {

            }

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            formChart formBaoCao = new formChart();
            OpenForm(formBaoCao, ptbIntro);
            hideMenuCon();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

            }
}
