﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class Administrator
    {
        private string username;
        private string password;

        public Administrator()
        {
            Username = "nerminamamela";
            Password = "cao";

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
