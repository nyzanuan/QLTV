using _2.BUS.IService;
using _2.BUS.Service;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _3.GUI.GUI
{
    public partial class formBaoCao : Form
    {
        private System.Data.DataTable dataTable;
        private readonly IReportService _reportService;

        public formBaoCao()
        {
            InitializeComponent();
            _reportService = new ReportService();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxBaoCao.SelectedIndex == 0)
            {
                printPreviewBaoCao.Document = printCB0;
                printPreviewBaoCao.ShowDialog();
            }
            else if (cbxBaoCao.SelectedIndex == 1)
            {
                printPreviewBaoCao.Document = printCB1;
                printPreviewBaoCao.ShowDialog();
            }
            else if (cbxBaoCao.SelectedIndex == 2)
            {
                printPreviewBaoCao.Document = printCB2;
                printPreviewBaoCao.ShowDialog();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;


            if (cbxBaoCao.SelectedIndex == 0)
            {

                var result = _reportService.GetReceipt(startDate, endDate);
                dgvBaoCao.DataSource = result;

            }
            else if (cbxBaoCao.SelectedIndex == 1)
            {
                var result = _reportService.GetBook();
                dgvBaoCao.DataSource = result;


            }
            else if (cbxBaoCao.SelectedIndex == 2)
            {
                var result = _reportService.GetQuantityBook();
                dgvBaoCao.DataSource = result;

            }
        }

        private void printCB0_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();

            //Header
            e.Graphics.DrawString("QUẢN LÝ THƯ VIỆN".ToUpper(), new System.Drawing.Font("Times new roman",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            
            e.Graphics.DrawString("DANH SÁCH ĐỘC GIẢ MƯỢN SÁCH".ToUpper(), new System.Drawing.Font("Times new roman",
                18, FontStyle.Bold), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString(startDate.ToUpper(), new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString(endDate.ToUpper(), new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(500, 200));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 280;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName

            e.Graphics.DrawString("Tên độc giả", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Email", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(160, y));
            e.Graphics.DrawString("Tên sách", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(300, y));
            e.Graphics.DrawString("Trạng thái", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(440, y));
            e.Graphics.DrawString("Ngày mượn", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(560, y));
            e.Graphics.DrawString("Ngày trả", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(700, y));

            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount - 1 ; i++)
            {
                y += 20;

                string tenDocgia = dgvBaoCao.Rows[i].Cells["Tên độc giả"].Value.ToString();
                string email = dgvBaoCao.Rows[i].Cells["Email"].Value.ToString();
                string tenSach = dgvBaoCao.Rows[i].Cells["Tên sách"].Value.ToString();             
                string trangThai = dgvBaoCao.Rows[i].Cells["Tên sách"].Value.ToString();              
                string ngayMuon = dgvBaoCao.Rows[i].Cells["Ngày mượn"].Value.ToString();
                string ngayTra = dgvBaoCao.Rows[i].Cells["Ngày trả"].Value.ToString();


                e.Graphics.DrawString(tenDocgia, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(email, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(160, y));
                e.Graphics.DrawString(tenSach, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(300, y));
                e.Graphics.DrawString(trangThai, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(440, y));
                e.Graphics.DrawString(ngayMuon, new System.Drawing.Font("Times new roman",
                10, FontStyle.Regular), Brushes.Black, new Point(560, y));
                e.Graphics.DrawString(ngayTra, new System.Drawing.Font("Times new roman",
                10, FontStyle.Regular), Brushes.Black, new Point(700, y));

            }
            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);


        }
    }

}

