﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Test_N
{
    class AccountData
    {
        private string username;
        private string password;

        public AccountData(string username, string password) {
        
            this.username = username;
            this.password = password;
        }
        

        public string Username {
            get{ return Username;}
            set { username = value;}
                                }

        public string Password {
            get { return password;}
            set { username = value;}
                                }
    }
}
