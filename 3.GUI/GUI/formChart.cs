using Sharing.Model;

namespace _3.GUI.GUI
{
    public partial class formChart : Form
    {
        public formChart()
        {
            InitializeComponent();
            _dashBoard = new DashBoard();
        }
        private DashBoard _dashBoard;
        private void formChart_Load(object sender, EventArgs e)
        {
            dtpTo.Value = dtpTo.Value.AddDays(20);

            //chart1.DataSource = _dashBoard.ListBookWithDay;
            //chart1.Series["Series1"].XValueMember = "Date";
            //chart1.Series["Series1"].YValueMembers = "TotalBook";
            //chart1.DataBind();
            //        List<BookData> data = new List<BookData>()
            //{
            //            new BookData { Date = "1 Category 1", TotalBook = 10 },
            //    new BookData { Date = "2 Category 2", TotalBook = 25 },
            //    new BookData { Date = "3 Category 3", TotalBook = 15 },
            //    new BookData { Date = "4 Category 4", TotalBook = 30 }
            //};
            LoadData();

        }
        private void LoadData()
        {
            _dashBoard.LoadData(dtpFrom.Value, dtpTo.Value);
            chart1.DataSource = _dashBoard.ListBookWithDay;
            chart1.Series[0].XValueMember = "Date";
            chart1.Series[0].YValueMembers = "TotalBook";

            chart1.DataBind();
            _dashBoard.LoadDataNonStatic();

            lblTongCus.Text = _dashBoard.NumCustomers.ToString();
            lblTongSach.Text = _dashBoard.NumBook.ToString();
            lblTongUser.Text = _dashBoard.NumUser.ToString();

            chart2.DataSource = _dashBoard.TopBook;
            chart2.Series[0].XValueMember = "Key";
            chart2.Series[0].YValueMembers = "Value";
            chart2.DataBind();

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int xValue1 = 1;


            LoadData();
            //chart1.Series["Series1"].Points.AddXY(xValue1, (new Random().Next(1000, 20000)));
            //chart1.Series["Series1"].Points.AddXY(xValue2, (new Random().Next(1000, 20000)));
            //chart1.Series["Series1"].Points.AddXY(xValue3, (new Random().Next(1000, 20000)));
            //chart1.Series["Series1"].Points.AddXY(xValue4, (new Random().Next(1000, 20000)));

            //// Đặt nhãn văn bản cho trục X
            //chart1.ChartAreas[0].AxisX.CustomLabels.Add(xValue1 - 0.5, xValue1 + 0.5, "Thang 1");
            //chart1.ChartAreas[0].AxisX.CustomLabels.Add(xValue2 - 0.5, xValue2 + 0.5, "Thang 3");
            //chart1.ChartAreas[0].AxisX.CustomLabels.Add(xValue3 - 0.5, xValue3 + 0.5, "Thang 4");
            //chart1.ChartAreas[0].AxisX.CustomLabels.Add(xValue4 - 0.5, xValue4 + 0.5, "Thang 9");



        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            btnCheck.Visible = true;

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            btnCheck.Visible = false;

            LoadData();

        }

        private void btnLast7Day_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpFrom.Value.AddDays(-7);
            dtpTo.Value = DateTime.Now;
            btnCheck.Visible = false;

            LoadData();
        }

        private void btnLast30Day_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = dtpFrom.Value.AddMonths(-1);
            dtpTo.Value = DateTime.Now;
            btnCheck.Visible = false;

            LoadData();
        }
    }
}
