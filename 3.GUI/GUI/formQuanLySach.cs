using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using Sharing.Model;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;
namespace QLTV
{
    public partial class formQuanLySach : Form
    {
        int pageNow = 1;
        int pageSize = 5;
        int totalPage = 0;
        int totalElement = 0;
        int borrowedCopies = 0;
        private Timer searchTimer;
        private readonly IBookService _bookService;
        public formQuanLySach()
        {
            InitializeComponent();
            _bookService = new BookService();
            cBox_Status.DataSource = Enum.GetValues(typeof(BookStatus));
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
            dgvSach.AutoGenerateColumns = false;
        }
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            pageNow = 1;
            loadData();
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
        private void loadData()
        {
            ValueReturn rs = _bookService.GetAllBook(pageNow, pageSize, txtTimKiem.Text);
            dgvSach.DataSource = rs.Value.ListElemnent;
            totalElement = rs.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();
        }
        private void LoadAuthor()
        {
            List<Author> result = _bookService.GetAllAuthor(cBox_Author.Text);
            result.Insert(0, new Author { Name = "Chọn tác giả", AuthorId = -1 });

            cBox_Author.DataSource = result;
            cBox_Author.DisplayMember = "Name";
            cBox_Author.ValueMember = "AuthorId";
        }
        private void LoadLan()
        {
            List<Language> result = _bookService.GetAllLanguage(cBox_language.Text);
            result.Insert(0, new Language { Name = "Chọn ngôn ngữ", LanguageId = -1 });

            cBox_language.DataSource = result;
            cBox_language.DisplayMember = "Name";
            cBox_language.ValueMember = "LanguageId";
        }
        private void LoadPub()
        {
            List<Publisher> result = _bookService.GetAllPublisher(cBox_Publisher.Text);
            result.Insert(0, new Publisher { Name = "Chọn NSX", PublisherId = -1 });

            cBox_Publisher.DataSource = result;
            cBox_Publisher.DisplayMember = "Name";
            cBox_Publisher.ValueMember = "PublisherId";
        }
        private void LoadCate()
        {
            List<Category> result = _bookService.GetAllCategory(cBox_Caterogy.Text);
            result.Insert(0, new Category { Name = "Chọn thể loại", CategoryId = -1 });

            cBox_Caterogy.DataSource = result;
            cBox_Caterogy.DisplayMember = "Name";
            cBox_Caterogy.ValueMember = "CategoryId";
        }
        private void formQuanLySach_Load(object sender, EventArgs e)
        {
            loadData();
            LoadAuthor();
            LoadCate();
            LoadLan();
            LoadPub();
        }
        private void setting(bool bl_readOnly, bool bl_add, bool bl_upd_del)
        {
            txt_book_name.ReadOnly =
            txt_quantity.ReadOnly = bl_readOnly;
            cBox_language.Enabled =
            cBox_Caterogy.Enabled =
            cBox_Author.Enabled =
            cBox_Publisher.Enabled =
            cBox_Status.Enabled =

            btnHuy.Enabled = bl_add || bl_upd_del;

            btnLuu.Enabled = bl_add;
            btnThemTacGia.Enabled = bl_readOnly;

            btnUpdate.Enabled =
            btnXoa.Enabled = bl_upd_del;

        }
        private void refreshField()
        {
            txt_book_id.Text =
            txt_book_name.Text =
            txt_quantity.Text = "";
            cBox_language.SelectedValue = -1;
            cBox_Author.SelectedValue = -1;
            cBox_Caterogy.SelectedValue = -1;
            cBox_Publisher.SelectedValue = -1;
            cBox_Status.SelectedItem = BookStatus.Active;
            dgvSach.SelectedRows.Clear();
            dgvSach.SelectedCells.Clear();
        }
        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            setting(false, true, false);
        }


    }
}
