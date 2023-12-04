using _2.BUS.IService;
using _2.BUS.Service;

namespace QLTV
{
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

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {


        }

        private void formTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = _authorService.GetAllAuthor(pageNow,pageSize,null).Value;
        }
    }
}
