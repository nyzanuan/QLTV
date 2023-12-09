using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Data;
using Sharing.Model;
using Sharing.ReturnModel;


namespace QLTV
{
    public partial class formLogin : Form
    {
        private readonly IUserService _userService;
        public formLogin()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            ValueReturn result = _userService.Validate(txtAccount.Text, txtPassword.Text);
            if (result.Status)
            {
                User user = (User)result.Value.ListElemnent;
                UserInfo.Instance.SetUserInfo(user.Username, user.Role, user.UserId);
                formGiaoDien f = new formGiaoDien();
                f.DangXuat += F_DangXuat; 
                f.Show();
                this.Hide();
                txtAccount.Text = "";

                txtPassword.Text = "";


            }
            else
            {
                lblNoti.Text = result.Message;
                System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
                notificationTimer.Interval = 2000;
                notificationTimer.Tick += (sender, e) =>
                {
                    lblNoti.Text = "";
                    notificationTimer.Stop();
                    notificationTimer.Dispose();
                };


                notificationTimer.Start();


            }
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as formGiaoDien).isClose = false;
            (sender as formGiaoDien).Close();
            UserInfo.Instance.SetUserInfo("", UserRole.User, -1);

            this.Show();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
