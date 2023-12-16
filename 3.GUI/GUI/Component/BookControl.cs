using _1.DAL.Model;

namespace _3.GUI.GUI.Component
{
    public partial class BookControl : UserControl
    {
        private readonly Book _book;
        public BookControl(Book book)
        {
            InitializeComponent();
            _book = book;
        }

        private void BookControl_Load(object sender, EventArgs e)
        {
            rating.Value = 4;

            lblTenSach.Text = _book.Name;
            labelConLai.Text = "Còn lại : " + _book.TotalCopies;


            if (_book.Image != null && _book.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(_book.Image))
                {
                    Image image = Image.FromStream(ms);
                    ptbAnh.Image = image;
                }
            }





        }
    }
}
