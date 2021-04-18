using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    class User
    {
   

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

        }


        public string username { get; set; }
        public string password { get; set; }

    }
}
