using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerClient
{
    namespace ToAPI
    {
        public class UserLogin
        {
            public string username;

            public string password;

            public UserLogin(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
        }
    }

    namespace FromAPI
    {
        public class TokenAuth
        {
            public string token;
        }
    }
}
