using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Company
    {
        public string CompanyName { get; set; }

        public User[] Users;
        public Company()
        {
            Users = new User[0];
        }
        //public void AddUser(User user)
        //{
        //    Array.Resize(ref Users, Users.Length+1);
        //    Users[Users.Length-1] = user;
        //}



        public void Register(User user)
        {

            user.UserName = (user.Name + "." + user.SurName).ToLower();
            user.Email = (user.UserName + "@gmail.com").ToLower();
            Array.Resize(ref Users, Users.Length + 1);
            Users[Users.Length - 1] = user;
            
        }
        //public void Login()
        //{

        //}
    }
}
