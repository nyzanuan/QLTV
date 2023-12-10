using _3.GUI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void OpenForm(Form ChildForm)
        {
            // Đóng form con hiện tại (nếu có)
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm = null;
                panelMain.Controls.Clear();
            }

            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ChildForm);
            ChildForm.Show();

        }
        private void formGiaoDien_Load(object sender, EventArgs e)
        {

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
            OpenForm(formDocGia);
            hideMenuCon();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

            formNhanVien formNhanVien = new formNhanVien();
            OpenForm(formNhanVien);
            hideMenuCon();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {

            formTacGia formTacGia = new formTacGia();
            OpenForm(formTacGia);
            hideMenuCon();
        }

        private void btnTheLoaiSach_Click(object sender, EventArgs e)
        {
            formTheLoai formTheLoai = new formTheLoai();
            OpenForm(formTheLoai);
            hideMenuCon();

        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            formNXB formNXB = new formNXB();
            OpenForm(formNXB);
            hideMenuCon();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            formQuanLySach formQuanLySach = new formQuanLySach();
            OpenForm(formQuanLySach);
            hideMenuCon();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            formMuonSach formMuonSach = new formMuonSach();
            OpenForm(formMuonSach);
            hideMenuCon();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            formTraSach formTraSach = new formTraSach();
            OpenForm(formTraSach);
            hideMenuCon();
        }

        private void btnMTSach_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMuonSachCon);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            formBaoCao formBaoCao = new formBaoCao();
            OpenForm(formBaoCao);
            hideMenuCon();
        }
    }
}
