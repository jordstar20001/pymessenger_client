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
        private FromAPI.GetMessagesContainer msgData = new FromAPI.GetMessagesContainer();

        public FromAPI.GetMessagesContainer currentMessageData
        {
            set
            {
                
                
                    CurrentMessageData_Changed(value);
                    msgData = value;
                
            }
        }

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
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                currentMessageData = await Helpers.Deserialised<FromAPI.GetMessagesContainer>(response);
            }
            else
            {
                var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                MessageBox.Show(data.message);

                if(response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    this.Close();
                }
            }


            // Get users.

            var userGetReq = new ToAPI.GetChatRoomContainer()
            {
                owner = RoomOwner
            };

            var usersResponse = await Helpers.PostRequestAsync("/2/chatrooms/get", Main.UserToken, userGetReq);

            var respDict = await Helpers.Deserialised<FromAPI.SingleRoomContainer>(usersResponse);

            lstUsers.Items.Clear();

            foreach(var user in respDict.users)
            {
                lstUsers.Items.Add(user);
            }



            
        }

        private void CurrentMessageData_Changed(FromAPI.GetMessagesContainer data)
        {
            rchTxtMessages.SuspendLayout();

            rchTxtMessages.Clear();

            var formatter = new RichTextBox();

            //foreach (var message in data.messages)
            //{
            //    int lengthOfTxt = rchTxtMessages.Text.Length;
            //    int lengthOfMessage = message.message.Length;
            //    formatter.AppendText(string.Format("{0} SAID: {1}\n\n", message.sender.ToUpper(), message.message));
            //    formatter.Select(lengthOfTxt, message.sender.Length + " SAID: ".Length);
            //    formatter.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Bold);
            //    formatter.Select(lengthOfTxt + message.sender.Length + " SAID: ".Length, lengthOfMessage);
            //    formatter.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Italic);
            //    formatter.DeselectAll();
            //}

            //rchTxtMessages.Text = formatter.Text;

            rchTxtMessages.Enabled = false;

            foreach (var message in data.messages)
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

            rchTxtMessages.Enabled = true;

            rchTxtMessages.ScrollToCaret();

            rchTxtMessages.ResumeLayout();
        }


        private void ChatRoom_Load(object sender, EventArgs e)
        {
            timeGetData.Enabled = true;
        }

        private async void btnKickUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex > -1)
            {


                var userToKick = (string)lstUsers.Items[lstUsers.SelectedIndex];

                var reqHeaders = new List<Extras.Header>()
                {
                    new Extras.Header()
                    {
                        name="Owner",
                        value=RoomOwner
                    },

                    new Extras.Header()
                    {
                        name="UserKick",
                        value=userToKick
                    }
                };

                var response = await Helpers.DeleteRequestAsync("/2/chatrooms/management/users", Main.UserToken, reqHeaders);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(string.Format("User {0} was kicked from the room.", userToKick));
                }

                else
                {
                    var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                    MessageBox.Show(data.message);
                }
            }

        }

        private async void ChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            var userToKick = Main.Username;

            var reqHeaders = new List<Extras.Header>()
            {
                new Extras.Header()
                {
                    name="Owner",
                    value=RoomOwner
                },

                new Extras.Header()
                {
                    name="UserKick",
                    value=userToKick
                }
            };

            var response = await Helpers.DeleteRequestAsync("/2/chatrooms/management/users", Main.UserToken, reqHeaders);
        
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, EventArgs.Empty);
            }
        }
    }
}
