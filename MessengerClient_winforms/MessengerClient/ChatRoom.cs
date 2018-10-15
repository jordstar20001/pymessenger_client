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

        private async void timeGetData_Tick(object sender, EventArgs e)
        {
            var ownerHeader = new Extras.Header()
            {
                name = "Owner",
                value = RoomOwner
            };

            var response = await Helpers.GetRequestAsync("/2/chatrooms/message", Main.UserToken, ownerHeader);
            var data = await Helpers.Deserialised<FromAPI.GetMessagesContainer>(response);

            rchTxtMessages.SuspendLayout();

            rchTxtMessages.Clear();

            foreach(var message in data.messages)
            {
                int lengthOfTxt = rchTxtMessages.Text.Length;
                int lengthOfMessage = message.message.Length;
                rchTxtMessages.AppendText(string.Format("{0} SAID: {1}\n\n", message.sender.ToUpper(), message.message));
                rchTxtMessages.Select(lengthOfTxt, message.sender.Length + " SAID: ".Length);
                rchTxtMessages.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Bold);
                rchTxtMessages.Select(lengthOfTxt + message.sender.Length + " SAID: ".Length, lengthOfMessage);
                rchTxtMessages.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Italic);
                rchTxtMessages.DeselectAll();
            }

            rchTxtMessages.ResumeLayout();
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            timeGetData.Enabled = true;
        }
    }
}
