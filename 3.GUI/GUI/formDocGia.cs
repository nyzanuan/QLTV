using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Helper;
using Sharing.Model;
using Sharing.ReturnModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace QLTV
{
    public partial class formDocGia : Form
    {
        int pageNow = 1;
        int pageSize = 5;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly ICustomerService _customerService;
        public formDocGia()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            cBox_gioiTinh.DataSource = Enum.GetValues(typeof(Gender));
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
            dgvDocGia.AutoGenerateColumns = false;
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
            ValueReturn rs = _customerService.GetAllCustomer(pageNow, pageSize, txtTimKiem.Text);
            dgvDocGia.DataSource = rs.Value.ListElemnent;
            totalElement = rs.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();
        }
        private void formDocGia_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private void settingAdd(bool bl_add)
        {
            txt_name.ReadOnly =
            txt_phone.ReadOnly =
            txt_email.ReadOnly = !bl_add;

            cBox_gioiTinh.Enabled =
            btnChonAnh.Enabled =
            btnLuu.Enabled =
            btnHuy.Enabled = bl_add;

            btnThem.Enabled =
            btnUpdate.Enabled =
            btnXoa.Enabled = !bl_add;
        }
        private void settingUpd_Del(bool bl_upd_del)
        {
            txt_name.ReadOnly =
            txt_phone.ReadOnly =
            txt_email.ReadOnly = !bl_upd_del;

            cBox_gioiTinh.Enabled =
            btnChonAnh.Enabled =
            btnUpdate.Enabled =
            btnXoa.Enabled =
            btnLuu.Enabled =
            btnHuy.Enabled = bl_upd_del;

            btnThem.Enabled = !bl_upd_del;
        }
        private void settingCancel(bool bl_cancel)
        {
            txt_name.ReadOnly =
            txt_phone.ReadOnly =
            txt_email.ReadOnly = bl_cancel;

            cBox_gioiTinh.Enabled =
            btnChonAnh.Enabled =
            btnUpdate.Enabled =
            btnXoa.Enabled =
            btnLuu.Enabled =
            btnHuy.Enabled = !bl_cancel;

            btnThem.Enabled = bl_cancel;
        }
        private void refreshField()
        {
            txt_id.Text =
            txt_name.Text =
            txt_phone.Text =
            txt_email.Text = "";
            cBox_gioiTinh.SelectedItem = Gender.Nam;
            ptbChonAnh.Image = null;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            settingAdd(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txt_name.Text,
                Phone = txt_phone.Text,
                Email = txt_email.Text,
                Gender = (Gender)cBox_gioiTinh.SelectedItem,
                CreateAt = DateTime.Now,
            };
            if (ptbChonAnh.Image != null)
            {
                customer.Image = HelperImage.ChangeImageToByte(ptbChonAnh);
            }
            bool result = _customerService.AddCustomer(customer);
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
            settingCancel(true);
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
                        ptbChonAnh.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một tệp hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerId = int.Parse(txt_id.Text),
                Name = txt_name.Text,
                Phone = txt_phone.Text,
                Email = txt_email.Text,
                Gender = (Gender)cBox_gioiTinh.SelectedItem,
                Image = HelperImage.ChangeImageToByte(ptbChonAnh)
            };
            bool result = _customerService.UpdateCustomer(customer);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
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
                if (int.TryParse(txt_id.Text, out int id))
                {
                    bool result = _customerService.DeleteCustomer(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
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

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocGia.Rows.Count)
            {
                int id = Convert.ToInt16(dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString());
                Customer customer = _customerService.GetCustomer(id);

                if (customer.Image != null && customer.Image.Length>0)
                {
                    if (customer.Image is byte[] imageBytes)
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
                txt_id.Text = id.ToString();
                txt_name.Text = customer.Name;
                txt_phone.Text = customer.Phone;
                txt_email.Text = customer.Email;
                settingUpd_Del(true);

            }
        }
    }
}
