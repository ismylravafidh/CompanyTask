﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //user.UserName = (user.Name + "." + user.SurName).ToLower();
        //user.Email = (user.UserName + "@gmail.com").ToLower();
        
    }
}
