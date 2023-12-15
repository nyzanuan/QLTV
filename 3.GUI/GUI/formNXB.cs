using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Data;
using _3.GUI.Helper;
using Sharing.Model;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;
namespace _3.GUI.GUI
{
    public partial class formNXB : Form
    {
        int pageNow = 1;
        int pageSize = 5;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly INXBService _nXBService;
        public formNXB()
        {
            InitializeComponent();
            _nXBService = new NXBService();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
            dgvNXB.AutoGenerateColumns = false;
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
            ValueReturn rs = _nXBService.GetAllPub(pageNow, pageSize, txtTimKiem.Text);
            dgvNXB.DataSource = rs.Value.ListElemnent;
            totalElement = rs.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();
        }
        private void formDocGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void setting(bool bl_readOnly, bool bl_add, bool bl_upd_del)
        {
            txtTen.ReadOnly =
            txtDiaChi.ReadOnly = bl_readOnly;
            btnChonAnh.Enabled = !bl_readOnly;

            btnHuy.Enabled = bl_add || bl_upd_del;

            btnLuu.Enabled = bl_add;
            btnThem.Enabled = bl_readOnly;

            btnUpdate.Enabled =
            btnXoa.Enabled = bl_upd_del;

        }
        private void refreshField()
        {
            txtMa.Text =
            txtTen.Text =
            txtDiaChi.Text = "";
            ptbChonAnh.Image = null;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formNXB_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var publisher = new Publisher()
            {
                PublisherId = int.Parse(txtMa.Text),
                Name = txtTen.Text,
                Image = HelperImage.ChangeImageToByte(ptbChonAnh)
            };
            bool result = _nXBService.UpdatePub(publisher);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            setting(false, true, false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn rầng bạn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (int.TryParse(txtMa.Text, out int id))
                {
                    bool result = _nXBService.DeletePub(id);
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
            Publisher publisher = new Publisher()
            {
                Name = txtTen.Text,
            };
            if (ptbChonAnh.Image != null)
            {
                publisher.Image = HelperImage.ChangeImageToByte(ptbChonAnh);
            }
            bool result = _nXBService.AddPub(publisher);
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

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ptbChonAnh.Image = null;
            if (e.RowIndex >= 0 && e.RowIndex < dgvNXB.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvNXB.Rows[e.RowIndex];
                txtMa.Text = selectedRow.Cells[0].Value.ToString();
                txtTen.Text = selectedRow.Cells[1].Value.ToString();
                object rawImageValue = selectedRow.Cells["COL_IMAGE"].Value;
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
                setting(false, false, true);

            }
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
    }
}
