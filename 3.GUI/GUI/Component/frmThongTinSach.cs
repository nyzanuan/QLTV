using _1.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.GUI.Component
{
    public partial class frmThongTinSach : Form
    {
       
        public frmThongTinSach(Book book)
        {
            InitializeComponent();

            if (book.Image != null && book.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(book.Image))
                {
                    Image image = Image.FromStream(ms);
                    ptbHinhAnh.Image = image;
                }
            }
        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            
        }
    }
}
