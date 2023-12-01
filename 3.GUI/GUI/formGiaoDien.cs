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
    }
}
