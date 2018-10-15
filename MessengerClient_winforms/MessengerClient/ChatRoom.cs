using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerClient
{
    public partial class ChatRoom : Form
    {
        private string RoomOwner;

        public ChatRoom()
        {
            InitializeComponent();
        }

        public ChatRoom(string roomOwner)
        {
            InitializeComponent();
            RoomOwner = roomOwner;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var request = new ToAPI.SendMessageToChatRoomContainer()
            {
                username = Main.Username,
                owner = RoomOwner,
                message = txtMessage.Text
            };

            MessageBox.Show(request.owner);

            var response = await Helpers.PostRequestAsync("/2/chatrooms/message", Main.UserToken, request);

            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                txtMessage.Text = "";
                return;
            }

            else
            {
                var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                var error = data.message;

                MessageBox.Show("Error. " + error);

            }
            

        }

        private void timeGetData_Tick(object sender, EventArgs e)
        {

        }
    }
}
