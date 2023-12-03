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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }
    }
}
