using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Data;
using iTextSharp.text;
using Sharing.Model;
using Sharing.ReturnModel;
using Timer = System.Windows.Forms.Timer;
namespace _3.GUI.GUI
{
    public partial class formTraSach : Form
    {
        int pageNow = 1;
        int pageSize = 5;
        int totalPage = 0;
        int totalElement = 0;
        private Timer searchTimer;
        private readonly IReturnService _returnService;
        public formTraSach()
        {
            InitializeComponent();
            _returnService = new ReturnService();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }
        private void SearchTimer_Tick(object? sender, EventArgs e)
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
        private void setting(bool bl_readOnly, bool bl_add, bool bl_upd_del)
        {
            //txt_book_name.ReadOnly =
            //txt_user_id.ReadOnly = bl_readOnly;
            //cmb_loan_id.Enabled = !bl_readOnly;


            //btnHuy.Enabled = bl_add || bl_upd_del;

            //btnLuu.Enabled = bl_add;

            //btnUpdate.Enabled =
            //btnXoa.Enabled = bl_upd_del;

        }
        private void refreshField()
        {
            //txt_id.Text =
            //txt_name.Text =
            //txt_phone.Text =
            //txt_email.Text = "";
            //cBox_gioiTinh.SelectedItem = Gender.Nam;
            //ptbChonAnh.Image = null;
        }
        private void loadData()
        {
            ValueReturn result = _returnService.GetAllReceipt(pageNow, pageSize, txt_search.Text, LoanReceiptStatus.Borrowed);

            book_dataGridView.DataSource = result.Value.ListElemnent;
            book_dataGridView.Columns["BookId"].Visible = false;
            book_dataGridView.Columns["CustomerId"].Visible = false;
            book_dataGridView.Columns["ReceiveDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            book_dataGridView.Columns["ReceiveDate"].HeaderText = "Ngày đặt";

            book_dataGridView.Columns["ReturnDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            book_dataGridView.Columns["ReturnDate"].HeaderText = "Ngày trả";

            book_dataGridView.Columns["Status"].HeaderText = "Tình trạng";
            book_dataGridView.Columns["ImageCustomer"].HeaderText = "Hình ảnh khách hàng";
            book_dataGridView.Columns["ImageBook"].HeaderText = "Hình ảnh sách";
            book_dataGridView.Columns["LoanId"].HeaderText = "Mã đơn mượn";
            book_dataGridView.Columns["BookName"].HeaderText = "Tên sách";
            book_dataGridView.Columns["CustomerName"].HeaderText = "Tên khách hàng";

            DataGridViewImageColumn column = new DataGridViewImageColumn();
            column = (DataGridViewImageColumn)book_dataGridView.Columns["ImageBook"];
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn column2 = new DataGridViewImageColumn();
            column2 = (DataGridViewImageColumn)book_dataGridView.Columns["ImageCustomer"];
            column2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalElement = result.Value.TotalElemnent;
            totalPage = (int)(Math.Ceiling((float)totalElement / pageSize));
            updateNumberPage();
        }
        private void formTraSach_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private async void btnTraSach_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = UserInfo.Instance;
            DataGridViewSelectedRowCollection rows = book_dataGridView.SelectedRows;
            LoanReceipt newLoan = new LoanReceipt()
            {
                LoanReceiptId = Convert.ToInt16(rows[0].Cells["LoanId"].Value),
                CustomerId = Convert.ToInt16(txt_user_id.Text),
                BookId = Convert.ToInt16(rows[0].Cells["BookId"].Value),
                BorrowDate = borrow_dateTimePicker.Value,
                ReturnDate = refund_dateTimePicker.Value,
                BorrowerId = userInfo.UserId != null && userInfo.UserId != 0 ? userInfo.UserId : 1,
            };
            bool rs = await _returnService.returnBook(newLoan);
            if (rs)
            {
                MessageBox.Show("tác vụ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("tác vụ thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGiaHan_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = UserInfo.Instance;
            DataGridViewSelectedRowCollection rows = book_dataGridView.SelectedRows;
            if (extend_dateTimePicker.Value <= refund_dateTimePicker.Value)
            {
                MessageBox.Show("Ngày gia hạn phải sau ngày trả sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoanReceipt newLoan = new LoanReceipt()
                {
                    LoanReceiptId = Convert.ToInt16(rows[0].Cells["LoanId"].Value),
                    CustomerId = Convert.ToInt16(txt_user_id.Text),
                    BookId = Convert.ToInt16(rows[0].Cells["BookId"].Value),
                    BorrowDate = borrow_dateTimePicker.Value,
                    ReturnDate = extend_dateTimePicker.Value,
                    BorrowerId = userInfo.UserId != null && userInfo.UserId != 0 ? userInfo.UserId : 1,
                };
                bool rs = await _returnService.renewBook(newLoan);
                if (rs)
                {
                    MessageBox.Show("Gia hạn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void book_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < book_dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = book_dataGridView.Rows[e.RowIndex];
                txt_loan_id.Text = selectedRow.Cells["LoanId"].Value.ToString();
                txt_user_id.Text = selectedRow.Cells["CustomerId"].Value.ToString();
                txt_book_name.Text = selectedRow.Cells["BookName"].Value.ToString();
                borrow_dateTimePicker.Value = (DateTime)selectedRow.Cells["ReceiveDate"].Value;
                refund_dateTimePicker.Value = (DateTime)selectedRow.Cells["ReturnDate"].Value;
                extend_dateTimePicker.Value = (DateTime)selectedRow.Cells["ReturnDate"].Value;
                //setting(false, false, true);
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

        private void cmb_loan_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
