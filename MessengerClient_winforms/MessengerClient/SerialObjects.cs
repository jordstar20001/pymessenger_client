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

        public class CreateRoomDetails
        {
            public string username;
            
            public string title;
            public string description;
            public int max_users;
            public string room_password;

            
        }

        public class GetChatRoomContainer
        {
            public string owner;
        }

        public class JoinChatRoomContainer
        {
            public string owner;
            public string username;
            public string password;
        }

        public class SendMessageToChatRoomContainer
        {
            public string username;
            public string owner;
            public string message;
            
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

        public class AllRoomsContainer
        {
            public List<string> rooms;
        }

        public class SingleRoomContainer
        {
            public List<string> users;
            public string title;
            public string description;
            public int max_users;
            public bool password_enabled;
        }
    }

    namespace Extras
    {
        public class Header
        {
            public string name;
            public string value;
        }

        public class SingleRoomContainer
        {
            public List<string> users;
            public string owner;
            public string title;
            public string description;
            public int max_users;
            public bool password_enabled;
        }
    }
}
