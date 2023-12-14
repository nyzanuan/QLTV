using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;

namespace _3.GUI.GUI
{
    public partial class formTheLoai : Form
    {
        int pageNow = 1;
        int pageSize = 5;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly ICategoryService _categoryService;
        public formTheLoai()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
            dgvTheLoai.AutoGenerateColumns = false;
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
            ValueReturn rs = _categoryService.GetAllCategory(pageNow, pageSize, txtTimKiem.Text);
            dgvTheLoai.DataSource = rs.Value.ListElemnent;
            totalElement = rs.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();
        }
        private void formTheLoai_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void setting(bool bl_readOnly, bool bl_add, bool bl_upd_del)
        {
            txt_name.ReadOnly = bl_readOnly;


            btnHuy.Enabled = bl_add || bl_upd_del;

            btnLuu.Enabled = bl_add;
            btnThem.Enabled = bl_readOnly;

            btnUpdate.Enabled =
            btnXoa.Enabled = bl_upd_del;
        }
        private void refreshField()
        {
            txt_id.Text =
            txt_name.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setting(false, true, false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryId = int.Parse(txt_id.Text),
                Name = txt_name.Text,

            };
            bool result = _categoryService.UpdateCategory(category);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, có thể do lỗi hoặc do không có sự thay đổi ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn rầng bạn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (int.TryParse(txt_id.Text, out int id))
                {
                    bool result = _categoryService.DeleteCategory(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
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
            Category category = new Category()
            {
                Name = txt_name.Text,
            };

            bool result = _categoryService.AddCategory(category);
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



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
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

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTheLoai.Rows.Count)
            {
                int id = Convert.ToInt16(dgvTheLoai.Rows[e.RowIndex].Cells[0].Value.ToString());
                Category category = _categoryService.GetCategory(id);

                if (category.Image != null && category.Image.Length > 0)
                {
                    if (category.Image is byte[] imageBytes)
                    {
                        using (MemoryStream stream = new MemoryStream(imageBytes))
                        {
                            stream.Seek(0, SeekOrigin.Begin);

                        }
                    }
                }

                txt_id.Text = id.ToString();
                txt_name.Text = category.Name;
                setting(false, false, true);

            }
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
