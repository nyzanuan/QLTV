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
                panel1.Controls.Clear();
            }

            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            ChildForm.Show();

        }
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formQuanLySach = new formQuanLySach();
            OpenForm(formQuanLySach);
        }

        private void danhMuc_toolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formDocGia = new formDocGia();
            OpenForm(formDocGia);
        }

        private void formGiaoDien_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler DangXuat;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }



        private void menuTacGia_Click(object sender, EventArgs e)
        {
            formTacGia formTacGia = new formTacGia();
            OpenForm(formTacGia);
        }

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMuonSach formMuonSach = new formMuonSach();
            OpenForm(formMuonSach);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNhanVien formNhanVien = new formNhanVien();
            OpenForm(formNhanVien);

        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTimKiemDocGia formTimKiemDocGia = new formTimKiemDocGia();
            OpenForm(formTimKiemDocGia);
        }


    }
}
