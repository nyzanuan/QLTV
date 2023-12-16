using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Helper;
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
            txt_title.ReadOnly =
            txt_quantity.ReadOnly = bl_readOnly;
            cBox_language.Enabled =
            cBox_Status.Enabled =
            cBox_Author.Enabled =
            cBox_Publisher.Enabled =
            cBox_Caterogy.Enabled =
            btnChonAnh.Enabled = !bl_readOnly;

            btnHuy.Enabled = bl_add || bl_upd_del;

            btnLuu.Enabled = bl_add;
            btnThemTacGia.Enabled = bl_readOnly;

            btnUpdate.Enabled =
            btnXoa.Enabled = bl_upd_del;

        }
        private void refreshField()
        {
            txt_book_id.Text =
            txt_title.Text =
            txt_book_name.Text =
            txt_quantity.Text = "";
            cBox_language.SelectedValue = -1;
            cBox_Author.SelectedValue = -1;
            cBox_Caterogy.SelectedValue = -1;
            cBox_Publisher.SelectedValue = -1;
            cBox_Caterogy.SelectedItem = BookStatus.Active;
            ptbChonAnh.Image = null;
            //dgvSach.SelectedRows.Clear();
            //dgvSach.SelectedCells.Clear();
        }
        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            setting(false, true, false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var book = new Book()
            {
                BookId = int.Parse(txt_book_id.Text),
                Name = txt_book_name.Text,
                Title = txt_title.Text,
                AvailableCopies = Convert.ToInt16(txt_quantity.Text),
                TotalCopies = Convert.ToInt16(txt_quantity.Text) + borrowedCopies,
                Status = (BookStatus)cBox_Status.SelectedItem,
                AuthorId = Convert.ToInt16(cBox_Author.SelectedValue),
                LanguageId = Convert.ToInt16(cBox_language.SelectedValue),
                CategoryId = Convert.ToInt16(cBox_Caterogy.SelectedValue),
                PublisherId = Convert.ToInt16(cBox_Publisher.SelectedValue),
                Image = HelperImage.ChangeImageToByte(ptbChonAnh)
            };
            bool result = _bookService.UpdateBook(book);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                refreshField();
                setting(true, false, false);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, có thể do lỗi hoặc do không có ựu thay đổi ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn rầng bạn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (int.TryParse(txt_book_id.Text, out int id))
                {
                    bool result = _bookService.DeleteBook(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        setting(true, false, false);
                        refreshField();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại Id", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = txt_book_name.Text,
                Title = txt_title.Text,
                AvailableCopies = Convert.ToInt16(txt_quantity.Text != "" ? txt_quantity.Text : "0"),
                TotalCopies = Convert.ToInt16(txt_quantity.Text != "" ? txt_quantity.Text : "0"),
                Status = (BookStatus)cBox_Status.SelectedItem,
                AuthorId = Convert.ToInt16(cBox_Author.SelectedValue.ToString()),
                PublisherId = Convert.ToInt16(cBox_Publisher.SelectedValue.ToString()),
                CategoryId = Convert.ToInt16(cBox_Caterogy.SelectedValue.ToString()),
                LanguageId = Convert.ToInt16(cBox_language.SelectedValue.ToString()),
            };
            if (ptbChonAnh.Image != null)
            {
                book.Image = HelperImage.ChangeImageToByte(ptbChonAnh);
            }
            bool result = _bookService.AddBook(book);
            if (result)
            {
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setting(true, false, false);
            refreshField();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn hình ảnh";
            openFileDialog.Filter = "Tệp hình ảnh|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Tất cả các tệp|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    string[] imageExtensions = { ".bmp", ".jpg", ".jpeg", ".png", ".gif" };
                    if (Array.Exists(imageExtensions, ext => ext.Equals(System.IO.Path.GetExtension(openFileDialog.FileName), StringComparison.OrdinalIgnoreCase)))
                    {
                        ptbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;

                        try
                        {
                            // Mở FileStream
                            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                                // Tạo hình ảnh từ FileStream
                                using (Image image = Image.FromStream(fs))
                                {
                                    // Gán hình ảnh cho PictureBox
                                    ptbChonAnh.Image = new Bitmap(image);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một tệp hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }



        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (pageNow != 1)
            {
                pageNow = 1;
                loadData();
            }
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (pageNow - 1 > 0)
            {
                pageNow = pageNow - 1;
                loadData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNow + 1 <= totalPage)
            {
                pageNow = pageNow + 1;
                loadData();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (pageNow != totalPage)
            {
                pageNow = totalPage;
                loadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSach.Rows.Count)
            {
                int id = Convert.ToInt16(dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString());
                Book book = _bookService.GetBook(id);

                if (book.Image != null && book.Image.Length > 0)
                {
                    if (book.Image is byte[] imageBytes)
                    {
                        using (MemoryStream stream = new MemoryStream(imageBytes))
                        {
                            stream.Seek(0, SeekOrigin.Begin);
                            ptbChonAnh.Image = Image.FromStream(stream);
                        }
                    }
                }
                else
                {
                    ptbChonAnh.Image = null;
                }
                txt_book_id.Text = id.ToString();
                txt_book_name.Text = book.Name;
                txt_title.Text = book.Title;
                txt_quantity.Text = book.AvailableCopies.ToString();
                cBox_Author.SelectedValue = book.AuthorId;
                cBox_Caterogy.SelectedValue = book.CategoryId;
                cBox_language.SelectedValue = book.LanguageId;
                cBox_Publisher.SelectedValue = book.PublisherId;
                cBox_Status.SelectedItem = book.Status;
                borrowedCopies = book.BorrowedCopies;
                setting(false, false, true);

            }
        }
    }
}
