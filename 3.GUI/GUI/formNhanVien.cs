using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Helper;
using Sharing.Model;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;

namespace _3.GUI.GUI
{
    public partial class formNhanVien : Form
    {
        int pageNow = 1;
        int pageSize = 2;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly IUserService _userService;
        public formNhanVien()
        {
            InitializeComponent();
            _userService = new UserService();

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
            txtSoDienThoai.Enabled = status;
            txtUserName.Enabled = status;
            txtEmail.Enabled = status;
            cmbGioiTinh.Enabled = status;
            cmbVaiTro.Enabled = status;
            txtEmail.Enabled = status;
            txtSoDienThoai.Enabled = status;
            txtTenNhanVien.Enabled = status;
            txtMatKhau.Enabled = status;
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
            ValueReturn result = _userService.GetAllUser(pageNow, pageSize, txtSearch.Text, Convert.ToInt32(cmbSearchRole.SelectedValue));
            dgvNhanVien.DataSource = result.Value.ListElemnent;
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column = (DataGridViewImageColumn)dgvNhanVien.Columns["Image"];
            if (column != null) column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            totalElement = result.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();

        }
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, int>> roleList = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Chọn vai trò", -1),

                new KeyValuePair<string, int>("User", 0),
                new KeyValuePair<string, int>("Admin", 1)
            };
            List<KeyValuePair<string, int>> gioiTinhList = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("Chọn giới tính", -1),
                new KeyValuePair<string, int>("Nam", 0),
                new KeyValuePair<string, int>("Nữ", 1)
            };
            cmbVaiTro.DataSource = new List<KeyValuePair<string, int>>(roleList);
            cmbVaiTro.DisplayMember = "Key";
            cmbVaiTro.ValueMember = "Value";

            cmbGioiTinh.DataSource = new List<KeyValuePair<string, int>>(gioiTinhList);
            cmbGioiTinh.DisplayMember = "Key";
            cmbGioiTinh.ValueMember = "Value";

            cmbSearchRole.DataSource = new List<KeyValuePair<string, int>>(roleList);
            cmbSearchRole.DisplayMember = "Key";
            cmbSearchRole.ValueMember = "Value";


            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditInput(true);

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Visible = true;
            btnThem.Enabled = false;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                UserId = Convert.ToInt16(txtMaNhanVien.Text),
                Username = txtUserName.Text,
                Password = txtMatKhau.Text,
                FullName = txtTenNhanVien.Text,
                Email = txtEmail.Text,
                Phone = txtSoDienThoai.Text,
                Role = (UserRole)cmbVaiTro.SelectedValue,
                Gender = (Gender)cmbGioiTinh.SelectedValue,
                Image = ptbChonAnh.Image != null ? HelperImage.ChangeImageToByte(ptbChonAnh) : null,
            };
            ValueReturn result = await _userService.UpdateUser(user);
            if (result.Status)
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show($"{result.Message} ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn rầng bạn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (int.TryParse(txtMaNhanVien.Text, out int maTacGia))
                {
                    bool result = _userService.DeleteUser(maTacGia);
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

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                User newUser = new User()
                {
                    Username = txtUserName.Text,
                    Phone = txtSoDienThoai.Text,
                    FullName = txtTenNhanVien.Text,
                    Gender = (Gender)cmbGioiTinh.SelectedValue,
                    Role = (UserRole)cmbVaiTro.SelectedValue,
                    Email = txtEmail.Text,
                    Password = txtMatKhau.Text,

                };
                if (ptbChonAnh.Image != null)
                {
                    newUser.Image = HelperImage.ChangeImageToByte(ptbChonAnh);
                }
                ValueReturn result = await _userService.AddUser(newUser);
                if (result.Status)
                {
                    MessageBox.Show($"{result.Message}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"{result.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được điền id vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNhanVien.Text = "";
            }
        }
        private void ResetInput()
        {
            txtUserName.Text = "";
            txtMaNhanVien.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhanVien.Text = "";
            txtMatKhau.Text = "";
            ptbChonAnh.Image = null;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditInput(false);
            ResetInput();
            cmbVaiTro.SelectedValue = -1;
            cmbGioiTinh.SelectedValue = -1;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnUpdate.Enabled = false;
            btnChonAnh.Visible = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;


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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];

                string maNhanVien = selectedRow.Cells["UserId"].Value.ToString();
                string tenNhanVien = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string fullName = selectedRow.Cells["FullName"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                int isAdmin = Convert.ToInt32(selectedRow.Cells["Role"].Value);
                int gender = Convert.ToInt32(selectedRow.Cells["Gender"].Value);
                string phone = selectedRow.Cells["Phone"].Value.ToString();

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
                txtMaNhanVien.Text = maNhanVien;
                txtEmail.Text = email;
                txtSoDienThoai.Text = phone;
                txtUserName.Text = tenNhanVien;
                cmbVaiTro.SelectedValue = isAdmin;
                cmbGioiTinh.SelectedValue = gender;
                txtTenNhanVien.Text = fullName;
                txtMatKhau.Text = password;
                btnUpdate.Enabled = true;
                btnChonAnh.Visible = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnThem.Enabled = false;
                EditInput(true);

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetInput();

            searchTimer.Stop();
            searchTimer.Start();
        }

        private void cmbSearchRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetInput();
            searchTimer.Stop();
            searchTimer.Start();
        }
    }
}
