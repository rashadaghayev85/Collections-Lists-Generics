
using Collections_Lists_Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Service.Interfaces
{
    internal interface IUserService
    {
        public User[] GetAll();

        public string Login(User[] users, string username, string password);

        public string Login2(User[] users, string email, string password);
    }
}
