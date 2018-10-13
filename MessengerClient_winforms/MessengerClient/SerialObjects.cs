using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace MessengerClient
{

    /// <summary>
    /// Contains classes that represent the deserialisation of JSON strings being sent TO the API.
    /// </summary>
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


    /// <summary>
    /// Contains classes that represent the deserialisation of JSON strings being sent FROM the API.
    /// </summary>
    namespace FromAPI
    {
        public class TokenContainer
        {
            public string token;
        }

        public class ErrorMessageContainer
        {
            [JsonProperty(PropertyName = "msg")]
            public string message;
        }

        public class NameContainer
        {
            public string name;
        }

        public class OnlineUsersContainer
        {
            public List<string> users;
        }
    }
}
