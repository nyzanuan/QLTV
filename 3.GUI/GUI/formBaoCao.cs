using _2.BUS.IService;
using _2.BUS.Service;

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

                dgvBaoCao.Columns["NameUser"].HeaderText = "Tên độc giả";
                dgvBaoCao.Columns["EmailUser"].HeaderText = "Email";
                dgvBaoCao.Columns["BookName"].HeaderText = "Tên sách";
                dgvBaoCao.Columns["StatusBook"].HeaderText = "Trạng thái sách";
                dgvBaoCao.Columns["DayBorrow"].HeaderText = "Ngày mượn";
                dgvBaoCao.Columns["DayBorrow"].DefaultCellStyle.Format = "dddd dd/MM/yyyy";
                dgvBaoCao.Columns["DayReturn"].HeaderText = "Ngày trả";
                dgvBaoCao.Columns["DayReturn"].DefaultCellStyle.Format = "dddd dd/MM/yyyy";

            }
            else if (cbxBaoCao.SelectedIndex == 1)
            {
                var result = _reportService.GetBook(startDate, endDate);
                dgvBaoCao.DataSource = result;

                dgvBaoCao.Columns["BookName"].HeaderText = "Tên sách";
                dgvBaoCao.Columns["Category"].HeaderText = "Thể loại";
                dgvBaoCao.Columns["Publisher"].HeaderText = "Nhà xuất bản";
                dgvBaoCao.Columns["Language"].HeaderText = "Ngôn ngữ";
                dgvBaoCao.Columns["BorrowDate"].HeaderText = "Ngày mượn";
                dgvBaoCao.Columns["BorrowDate"].DefaultCellStyle.Format = "dddd dd/MM/yyyy";
                dgvBaoCao.Columns["ReturnDate"].HeaderText = "Ngày trả";
                dgvBaoCao.Columns["ReturnDate"].DefaultCellStyle.Format = "dddd dd/MM/yyyy";
                dgvBaoCao.Columns["sumBorrowBook"].HeaderText = "Số lượt mượn";

            }
            else if (cbxBaoCao.SelectedIndex == 2)
            {
                var result = _reportService.GetQuantityBook();
                dgvBaoCao.DataSource = result;
                dgvBaoCao.Columns["BookName"].HeaderText = "Tên sách";
                dgvBaoCao.Columns["Category"].HeaderText = "Thể loại";
                dgvBaoCao.Columns["Publisher"].HeaderText = "Nhà xuất bản";
                dgvBaoCao.Columns["Language"].HeaderText = "Ngôn ngữ";
                dgvBaoCao.Columns["AvailableCopies"].HeaderText = "Số lượng hiện có";
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
            // e.Graphics.DrawString("Trạng thái", new System.Drawing.Font("Times new roman",
            // 12, FontStyle.Bold), Brushes.Black, new Point(440, y));
            e.Graphics.DrawString("Ngày mượn", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(560, y));
            e.Graphics.DrawString("Ngày trả", new System.Drawing.Font("Times new roman",
            12, FontStyle.Bold), Brushes.Black, new Point(700, y));

            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount; i++)
            {
                y += 30;

                string tenDocgia = dgvBaoCao.Rows[i].Cells["NameUser"].Value.ToString();
                string email = dgvBaoCao.Rows[i].Cells["EmailUser"].Value.ToString();
                string tenSach = dgvBaoCao.Rows[i].Cells["BookName"].Value.ToString();
                string trangThai = dgvBaoCao.Rows[i].Cells["StatusBook"].Value.ToString();
                string ngayMuon = dgvBaoCao.Rows[i].Cells["DayBorrow"].FormattedValue.ToString();
                string ngayTra = dgvBaoCao.Rows[i].Cells["DayReturn"].FormattedValue.ToString();


                e.Graphics.DrawString(tenDocgia, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(email, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(160, y));
                e.Graphics.DrawString(tenSach, new System.Drawing.Font("Times new roman",
                12, FontStyle.Regular), Brushes.Black, new Point(300, y));
                // e.Graphics.DrawString(trangThai, new System.Drawing.Font("Times new roman",
                // 12, FontStyle.Regular), Brushes.Black, new Point(440, y));
                e.Graphics.DrawString(ngayMuon, new System.Drawing.Font("Times new roman",
                10, FontStyle.Regular), Brushes.Black, new Point(560, y));
                e.Graphics.DrawString(ngayTra, new System.Drawing.Font("Times new roman",
                10, FontStyle.Regular), Brushes.Black, new Point(700, y));

            }
            y += 70;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);


        }

        private void printCB1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();

            //Header
            e.Graphics.DrawString("QUẢN LÝ THƯ VIỆN".ToUpper(), new System.Drawing.Font("Times new roman",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));

            e.Graphics.DrawString("SÁCH ĐƯỢC MƯỢN NHIỀU TRONG THÁNG".ToUpper(), new System.Drawing.Font("Times new roman",
                18, FontStyle.Bold), Brushes.Black, new Point(180, 100));
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

            e.Graphics.DrawString("Tên sách", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Thể loại", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(260, y));
            e.Graphics.DrawString("Nhà xuất bản", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(400, y));
            e.Graphics.DrawString("Ngôn ngữ", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(600, y));
            //e.Graphics.DrawString("Ngày mượn", new System.Drawing.Font("Times new roman",
            // 11, FontStyle.Bold), Brushes.Black, new Point(560, y));
            //e.Graphics.DrawString("Ngày trả", new System.Drawing.Font("Times new roman",
            //11, FontStyle.Bold), Brushes.Black, new Point(700, y));
            e.Graphics.DrawString("Số lượt mượn", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(750, y));

            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount; i++)
            {
                y += 30;

                string tenSach = dgvBaoCao.Rows[i].Cells["BookName"].Value.ToString();
                string theLoai = dgvBaoCao.Rows[i].Cells["Category"].Value.ToString();
                string NXB = dgvBaoCao.Rows[i].Cells["Publisher"].Value.ToString();
                string ngonNgu = dgvBaoCao.Rows[i].Cells["Language"].Value.ToString();
                string ngayMuon = dgvBaoCao.Rows[i].Cells["BorrowDate"].FormattedValue.ToString();
                string ngayTra = dgvBaoCao.Rows[i].Cells["ReturnDate"].FormattedValue.ToString();
                string tongMuon = dgvBaoCao.Rows[i].Cells["sumBorrowBook"].Value.ToString();


                e.Graphics.DrawString(tenSach, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(theLoai, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(260, y));
                e.Graphics.DrawString(NXB, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(400, y));
                e.Graphics.DrawString(ngonNgu, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(600, y));
                e.Graphics.DrawString(tongMuon, new System.Drawing.Font("Times new roman",
                11, FontStyle.Bold), Brushes.Black, new Point(750, y));

            }
            y += 70;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);
        }

        private void printCB2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();

            //Header
            e.Graphics.DrawString("QUẢN LÝ THƯ VIỆN".ToUpper(), new System.Drawing.Font("Times new roman",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));

            e.Graphics.DrawString("SỐ SÁCH HIỆN CÓ".ToUpper(), new System.Drawing.Font("Times new roman",
                18, FontStyle.Bold), Brushes.Black, new Point(330, 100));
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

            e.Graphics.DrawString("Tên sách", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Thể loại", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(180, y));
            e.Graphics.DrawString("Nhà xuất bản", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(380, y));
            e.Graphics.DrawString("Ngôn ngữ", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(560, y));
            e.Graphics.DrawString("Số lượng hiện có", new System.Drawing.Font("Times new roman",
            11, FontStyle.Bold), Brushes.Black, new Point(650, y));
            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount; i++)
            {
                y += 30;

                string tenSach = dgvBaoCao.Rows[i].Cells["BookName"].Value.ToString();
                string theLoai = dgvBaoCao.Rows[i].Cells["Category"].Value.ToString();
                string NXB = dgvBaoCao.Rows[i].Cells["Publisher"].Value.ToString();
                string ngonNgu = dgvBaoCao.Rows[i].Cells["Language"].Value.ToString();
                string hienCo = dgvBaoCao.Rows[i].Cells["AvailableCopies"].Value.ToString();


                e.Graphics.DrawString(tenSach, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(theLoai, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(NXB, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(380, y));
                e.Graphics.DrawString(ngonNgu, new System.Drawing.Font("Times new roman",
                11, FontStyle.Regular), Brushes.Black, new Point(560, y));
                e.Graphics.DrawString(hienCo, new System.Drawing.Font("Times new roman",
                11, FontStyle.Bold), Brushes.Black, new Point(650, y));

            }
            y += 70;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formBaoCao_Load(object sender, EventArgs e)
        {
        }
    }

}

