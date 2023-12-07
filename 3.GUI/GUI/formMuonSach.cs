using _2.BUS.IService;
using _2.BUS.Service;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;

namespace QLTV
{
    public partial class formMuonSach : Form
    {
        int pageNow = 1;
        int pageSize = 2;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly IReceiptService _receiptService;
        public formMuonSach()
        {
            InitializeComponent();
            _receiptService = new ReceiptService();

            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void SearchTimer_Tick(object? sender, EventArgs e)
        {
            searchTimer.Stop();
            pageNow = 1;
            LoadData();
        }
        void EditInput(bool status)
        {
            cmbDocGia.Enabled = status;
            cmbSach.Enabled = status;
            dtpNgayMuon.Enabled = status;
            dtpNgayTra.Enabled = status;

        }
        void updateNumberPage()
        {
            txtNumberPage.Text = pageNow + "/" + totalPage;
            if (pageNow == 1)
            {
                btnFirstPage.Enabled = false;
                btnPrePage.Enabled = false;

            }
            else
            {
                btnFirstPage.Enabled = true;
                btnPrePage.Enabled = true;
            }
            if (pageNow == totalPage)
            {
                btnLastPage.Enabled = false;
                btnNextPage.Enabled = false;

            }
            else
            {
                btnLastPage.Enabled = true;
                btnNextPage.Enabled = true;
            }
        }
        private void LoadData()
        {
            ValueReturn result = _receiptService.GetAllReceipt(pageNow, pageSize, txtSearch.Text, null);
            dgvMuonSach.DataSource = result.Value.ListElemnent;
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            if (column != null) column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            totalElement = result.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();

        }
        private void ResetInput()
        {
            cmbSach.SelectedIndex = -1;
            cmbDocGia.SelectedIndex = -1;
            dtpNgayTra.Value = DateTime.Now.AddDays(4);
            dtpNgayMuon.Value = DateTime.Now;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void formMuonSach_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageNow != 1)
            {
                pageNow = 1;
                LoadData();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageNow != totalPage)
            {
                pageNow = totalPage;
                LoadData();
            }
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (pageNow - 1 > 0)
            {
                pageNow = pageNow - 1;
                LoadData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNow + 1 <= totalPage)
            {
                pageNow = pageNow + 1;
                LoadData();
            }
        }
    }
}
