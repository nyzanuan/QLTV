using Sharing.Model;

namespace _3.GUI.Data
{

    public class UserInfo
    {
        private static UserInfo instance;
        public int UserId { get; set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public UserRole Role { get; private set; }

        private UserInfo() { }

        public static UserInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInfo();
                }
                return instance;
            }
        }

        public void SetUserInfo(string username, UserRole role, int id)
        {
            Username = username;
            this.Role = role;
            UserId = id;
        }
    }

}
