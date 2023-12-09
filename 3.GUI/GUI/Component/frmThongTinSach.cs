
namespace _3.GUI.GUI.Component
{
    public partial class frmThongTinSach : Form
    {
        private Size panelSize;
        public frmThongTinSach(byte[]? ImagePar, string title, Size panelSize)
        {
            InitializeComponent();



            tableLayoutPanel1.Dock = DockStyle.Fill;



            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;


            lblTitle.Text = title;

            tableLayoutPanel1.Controls.Add(ptbHinhAnh, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            if (ImagePar != null && ImagePar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ImagePar))
                {
                    Image image = Image.FromStream(ms);
                    ptbHinhAnh.Image = image;
                }
            }


            Controls.Add(tableLayoutPanel1);


            this.panelSize = panelSize;
            lblTitle.MaximumSize = new Size(this.panelSize.Width, 20);
            Size = new Size(this.panelSize.Width, this.panelSize.Height);
        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {

        }
    }
}
