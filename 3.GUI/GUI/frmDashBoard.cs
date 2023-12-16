using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.GUI.Component;

namespace _3.GUI.GUI
{
    public partial class frmDashBoard : Form
    {
        private readonly IBookService _bookService;
        private readonly int width;
        public frmDashBoard(int width)
        {
            InitializeComponent();
            _bookService = new BookService();
            this.width = width;
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            List<Book> rs = _bookService.GetAllBook();
            //int len = rs.Count;
            //int phantudu = width / 325;

            //int margin = (int)Math.Floor((width - phantudu * 325) / (double)(phantudu * 2) - 10);

            foreach (Book book in rs)
            {

                var panel = new BookControl(book);

                panel.Margin = new Padding(10, 10, 10, 10);
                flowLayout.Controls.Add(panel);
            }


        }
    }
}
