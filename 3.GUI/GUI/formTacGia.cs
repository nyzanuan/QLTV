using _2.BUS.IService;
using _2.BUS.Service;

namespace QLTV
{
    public enum EditTacGia
    {
        Them,
        Xoa,
        Sua
    }
    public partial class formTacGia : Form
    {
        int pageNow = 1;
        int pageSize = 10;

        public formTacGia()
        {
            InitializeComponent();
            _authorService = new AuthorService();


        }
        private readonly IAuthorService _authorService;
        void EditInput(bool status)
        {
            txtMaTacGia.Enabled = status;
            txtTenTacGia.Enabled = status;
            dtpNgaySinh.Enabled = status;
        }
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            EditInput(true);
            txtTenTacGia.Text = "";
            txtMaTacGia.Text = "";
            txtMaTacGia.Enabled = false;
            txtMaTacGia.Text = "Mã sinh tự động";
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Visible = true;
            btnThemTacGia.Enabled = false;

        }

        private void formTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = _authorService.GetAllAuthor(pageNow, pageSize, null).Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = _authorService.GetAllAuthor(1, int.MaxValue, txtSearch.Text).Value;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditInput(false);
            txtTenTacGia.Text = "";
            txtMaTacGia.Text = "";
            txtMaTacGia.Text = "";
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnChonAnh.Visible = false;
            btnThemTacGia.Enabled = true;
        }
    }
}
