using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Helper;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;

namespace _3.GUI.GUI
{
    public partial class formTacGia : Form
    {

        int pageNow = 1;
        int pageSize = 2;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly IAuthorService _authorService;


        public formTacGia()
        {
            InitializeComponent();
            _authorService = new AuthorService();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;

        }
        void EditInput(bool status)
        {
            txtTenTacGia.Enabled = status;
            dtpNgaySinh.Enabled = status;
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
            ValueReturn result = _authorService.GetAllAuthor(pageNow, pageSize, txtSearch.Text);
            dgvTacGia.DataSource = result.Value.ListElemnent;
            totalElement = result.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();

        }
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            EditInput(true);
            txtTenTacGia.Text = "";
            txtMaTacGia.Text = "";
            txtMaTacGia.Text = "Mã sinh tự động";
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Visible = true;
            btnThemTacGia.Enabled = false;

        }

        private void formTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column = (DataGridViewImageColumn)dgvTacGia.Columns["Image"];
            if (column != null) column.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            pageNow = 1;
            LoadData();
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditInput(false);
            txtTenTacGia.Text = "";
            txtMaTacGia.Text = "";
            txtMaTacGia.Text = "";
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnUpdate.Enabled = false;
            btnChonAnh.Visible = false;
            btnThemTacGia.Enabled = true;
            btnXoa.Enabled = false;
            ptbChonAnh.Image = null;

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
                        ptbChonAnh.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một tệp hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTacGia.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvTacGia.Rows[e.RowIndex];

                string maTacGia = selectedRow.Cells["AuthorId"].Value.ToString();
                string tenTacGia = selectedRow.Cells["Name"].Value.ToString();
                object rawImageValue = selectedRow.Cells["Image"].Value;

                if (rawImageValue != null && rawImageValue != DBNull.Value)
                {
                    if (rawImageValue is byte[] imageBytes)
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
                txtMaTacGia.Text = maTacGia;
                txtTenTacGia.Text = tenTacGia;
                dtpNgaySinh.Value = (DateTime)selectedRow.Cells["BirthDay"].Value;
                btnUpdate.Enabled = true;
                btnChonAnh.Visible = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnThemTacGia.Enabled = false;
                EditInput(true);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text == "Mã sinh tự động")
            {
                Author newTacgia = new Author()
                {
                    BirthDay = dtpNgaySinh.Value,
                    Name = txtTenTacGia.Text,
                };
                if (ptbChonAnh.Image != null)
                {
                    newTacgia.Image = HelperImage.ChangeImageToByte(ptbChonAnh);
                }
                bool result = _authorService.AddAuthor(newTacgia);
                if (result)
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var author = new Author
            {
                AuthorId = int.Parse(txtMaTacGia.Text),
                Name = txtTenTacGia.Text,
                BirthDay = (DateTime)dtpNgaySinh.Value,
                Image = HelperImage.ChangeImageToByte(ptbChonAnh)
            };
            bool result = _authorService.UpdateAuthor(author);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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
                if (int.TryParse(txtMaTacGia.Text, out int maTacGia))
                {
                    bool result = _authorService.DeleteAuthor(maTacGia);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
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
