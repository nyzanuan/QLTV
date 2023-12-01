using _1.DAL.Model;
using _2.BUS.IService;
using _2.BUS.Service;
using _3.GUI.Data;
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
                Form f = new formGiaoDien();
                f.ShowDialog();

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
                User user = (User)result.Value;
                UserInfo.Instance.SetUserInfo(txtUsername.Text);

            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
