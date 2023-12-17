using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Data;
using _3.GUI.GUI.Component;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;

namespace QLTV
{
    public partial class formMuonSach : Form
    {
        int pageNow = 1;
        int pageSize = 2;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly IReceiptService _receiptService;

        public formMuonSach()
        {
            InitializeComponent();
            _receiptService = new ReceiptService();

            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
            dtpNgayTra.Value = DateTime.Now.AddDays(4);
        }
        private void LoadBook()
        {
            List<Book> result = _receiptService.getAllBook(cmbSach.Text);
            result = result.ToList();
            var newBook = new Book
            {
                BookId = -1,
                Name = "Hãy chọn sách"

            };
            result.Insert(0, newBook);

            cmbSach.DataSource = result;
            cmbSach.DisplayMember = "Name";
            cmbSach.ValueMember = "BookId";
        }
        private void SearchTimer_Tick(object? sender, EventArgs e)
        {
            searchTimer.Stop();
            pageNow = 1;
            LoadData();
        }
        void EditInput(bool status)
        {
            cmbDocGia.Enabled = status;
            cmbSach.Enabled = status;
            dtpNgayTra.Enabled = status;
            dtpNgayMuon.Enabled = status;

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
        private void LoadUser()
        {
            List<Customer> result = _receiptService.getAllCustomer(cmbDocGia.Text);
            result.Insert(0, new Customer { Name = "Hãy chọn khách mượn sách", CustomerId = -1 });



            cmbDocGia.DataSource = result;
            cmbDocGia.DisplayMember = "Name";
            cmbDocGia.ValueMember = "CustomerId";


        }



        private void LoadData()
        {
            ValueReturn result = _receiptService.GetAllReceipt(pageNow, pageSize, txtSearch.Text, null);



            dgvMuonSach.DataSource = result.Value.ListElemnent;
            dgvMuonSach.Columns["BookId"].Visible = false;
            dgvMuonSach.Columns["CustomerId"].Visible = false;
            dgvMuonSach.Columns["ReceiveDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvMuonSach.Columns["ReceiveDate"].HeaderText = "Ngày đặt";

            dgvMuonSach.Columns["ReturnDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvMuonSach.Columns["ReturnDate"].HeaderText = "Ngày trả";

            dgvMuonSach.Columns["Status"].HeaderText = "Tình trạng";
            dgvMuonSach.Columns["ImageCustomer"].HeaderText = "Hình ảnh khách hàng";
            dgvMuonSach.Columns["ImageBook"].HeaderText = "Hình ảnh sách";
            dgvMuonSach.Columns["LoanId"].HeaderText = "Mã đơn mượn";
            dgvMuonSach.Columns["BookName"].HeaderText = "Tên sách";
            dgvMuonSach.Columns["CustomerName"].HeaderText = "Tên khách hàng";

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column = (DataGridViewImageColumn)dgvMuonSach.Columns["ImageBook"];
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn column2 = new DataGridViewImageColumn();
            column2 = (DataGridViewImageColumn)dgvMuonSach.Columns["ImageCustomer"];
            column2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            totalElement = result.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();

        }
        private void ResetInput()
        {
            cmbSach.SelectedIndex = -1;
            cmbDocGia.SelectedIndex = -1;
            dtpNgayTra.Value = DateTime.Now.AddDays(4);
            dtpNgayMuon.Value = DateTime.Now;
        }

        private void formMuonSach_Load(object sender, EventArgs e)
        {
            dgvMuonSach.RowHeadersVisible = true;
            LoadData();
            LoadUser();
            LoadBook();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditInput(true);

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnLocSach.Enabled = true;
            btnLocDocGia.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = UserInfo.Instance;
            DataGridViewSelectedRowCollection rows = dgvMuonSach.SelectedRows;
            LoanReceipt newLoan = new LoanReceipt()
            {
                LoanReceiptId = Convert.ToInt16(rows[0].Cells["LoanId"].Value),
                BookId = Convert.ToInt16(cmbSach.SelectedValue),
                ReturnDate = dtpNgayTra.Value,
                CustomerId = Convert.ToInt16(cmbDocGia.SelectedValue),


            };

            ValueReturn result = await _receiptService.UpdateLoanReceipt(newLoan);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditInput(false);
            ResetInput();
            btnLocDocGia.Enabled = false;
            btnLocSach.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnUpdate.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {

            UserInfo userInfo = UserInfo.Instance;
            LoanReceipt newLoan = new LoanReceipt()
            {
                BookId = Convert.ToInt16(cmbSach.SelectedValue),
                //BorrowDate = DateTime.Now,
                BorrowDate = dtpNgayMuon.Value,
                ReturnDate = dtpNgayTra.Value,
                CustomerId = Convert.ToInt16(cmbDocGia.SelectedValue),
                BorrowerId = userInfo.UserId != null && userInfo.UserId != 0 ? userInfo.UserId : 1,


            };

            ValueReturn result = await _receiptService.AddLoanReceipt(newLoan);
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



        private void cmbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocGia.SelectedItem != null)
            {
                Customer selectedCustomer = (Customer)cmbDocGia.SelectedItem;

                if (selectedCustomer.CustomerId != -1)
                {
                    frmThongTinSach frmThongTinSach = new frmThongTinSach(selectedCustomer.Image, selectedCustomer.Name, panelHinhAnhDocGia.Size);

                    frmThongTinSach.TopLevel = false;
                    panelHinhAnhDocGia.Controls.Clear();
                    panelHinhAnhDocGia.Controls.Add(frmThongTinSach);
                    frmThongTinSach.Show();
                }
                else
                {
                    panelHinhAnhDocGia.Controls.Clear();

                }
            }
        }

        private void btnLocDocGia_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void cmbDocGia_TextChanged(object sender, EventArgs e)
        {
            if (cmbDocGia.Text.Length == 0)
            {
                LoadUser();
            }
        }
        private void btnLocSach_Click(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void cmbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSach.SelectedItem != null)
            {
                Book selectedCustomer = (Book)cmbSach.SelectedItem;

                if (selectedCustomer.BookId != -1)
                {
                    frmThongTinSach frmThongTinSach = new frmThongTinSach(selectedCustomer.Image, selectedCustomer.Name, panelHinhAnhSach.Size);

                    frmThongTinSach.TopLevel = false;
                    panelHinhAnhSach.Controls.Clear();
                    panelHinhAnhSach.Controls.Add(frmThongTinSach);
                    frmThongTinSach.Show();
                }
                else
                {
                    panelHinhAnhSach.Controls.Clear();

                }
            }
        }


        private void cmbSach_TextChanged(object sender, EventArgs e)
        {
            if (cmbSach.Text.Length == 0)
            {
                LoadBook();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvMuonSach.SelectedRows;

            if (rows.Count > 0)
            {
                if (int.TryParse(rows[0].Cells["LoanId"].Value.ToString(), out int LoanId))
                {
                    if (MessageBox.Show("Bạn có chắc chắn rằng muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        bool result = _receiptService.DeleteLoanReceipt(LoanId);
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
                }
                else
                {
                    MessageBox.Show("Có lỗi ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng cần sửa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMuonSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvMuonSach.Rows[e.RowIndex];

                int BookId = Convert.ToInt16(selectedRow.Cells["BookId"].Value);
                int CustomerId = Convert.ToInt16(selectedRow.Cells["CustomerId"].Value);

                DateTime ReceiveDate = (DateTime)selectedRow.Cells["ReceiveDate"].Value;
                DateTime ReturnDate = (DateTime)selectedRow.Cells["ReturnDate"].Value;

                string CustomerName = selectedRow.Cells["CustomerName"].Value.ToString();
                string BookName = selectedRow.Cells["BookName"].Value.ToString();
                byte[] ImageBook = (byte[])selectedRow.Cells["ImageBook"].Value;
                byte[] ImageCustomer = (byte[])selectedRow.Cells["ImageCustomer"].Value;


                cmbDocGia.SelectedValue = CustomerId;
                cmbSach.SelectedValue = BookId;
                dtpNgayMuon.Value = ReceiveDate;
                dtpNgayTra.Value = ReturnDate;
                btnUpdate.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnThem.Enabled = false;
                btnLocDocGia.Enabled = true;
                btnLocSach.Enabled = true;
                EditInput(true);

                if (BookId != -1)
                {
                    frmThongTinSach frmThongTinSach = new frmThongTinSach(ImageBook, BookName, panelHinhAnhSach.Size);

                    frmThongTinSach.TopLevel = false;
                    panelHinhAnhDocGia.Controls.Clear();
                    panelHinhAnhDocGia.Controls.Add(frmThongTinSach);
                    frmThongTinSach.Show();
                }
                else
                {
                    panelHinhAnhDocGia.Controls.Clear();

                }

                if (CustomerId != -1)
                {
                    frmThongTinSach frmThongTinSach = new frmThongTinSach(ImageCustomer, CustomerName, panelHinhAnhDocGia.Size);

                    frmThongTinSach.TopLevel = false;
                    panelHinhAnhDocGia.Controls.Clear();
                    panelHinhAnhDocGia.Controls.Add(frmThongTinSach);
                    frmThongTinSach.Show();
                }
                else
                {
                    panelHinhAnhDocGia.Controls.Clear();

                }

            }
        }
    }
}
