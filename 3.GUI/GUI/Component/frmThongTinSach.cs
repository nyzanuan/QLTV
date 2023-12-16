
namespace _3.GUI.GUI.Component
{
    public partial class frmThongTinSach : Form
    {
        private Size panelSize;
        public frmThongTinSach(byte[]? ImagePar, string title, Size panelSize)
        {
            InitializeComponent();


            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;


            lblTitle.Text = title;

            if (ImagePar != null && ImagePar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ImagePar))
                {
                    Image image = Image.FromStream(ms);
                    ptbHinhAnh.Image = image;
                }
            }




            this.panelSize = panelSize;
            lblTitle.MaximumSize = new Size(this.panelSize.Width, 20);
            Size = new Size(this.panelSize.Width, this.panelSize.Height);
        }

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
