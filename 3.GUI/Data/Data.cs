﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GUI.Data
{
   
    public class UserInfo
    {
        private static UserInfo instance;

        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool isAdmin { get; private set; }

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

        public void SetUserInfo(string username, bool isAdmin)
        {
            Username = username;
            this.isAdmin = isAdmin;
        }
    }

}
