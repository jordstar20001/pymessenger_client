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
    public partial class CreateRoomDialog : Form
    {
        public string ErrorMessage;

        public ToAPI.CreateRoomDetails RoomDetails;
        public CreateRoomDialog()
        {
            InitializeComponent();
        }

        private void CreateRoomDialog_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnCreateRoom_Click(object sender, EventArgs e)
        {
            var roomDetails = new ToAPI.CreateRoomDetails()
            {
                description = txtDescription.Text,
                max_users = (int)numMaxUsers.Value,
                room_password = txtPassword.Text,
                title = txtTitle.Text,
                username = Main.Username

            };
            var response = await Helpers.PostRequestAsync("/2/chatrooms/create", Main.UserToken, roomDetails);

            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                RoomDetails = roomDetails;
                this.DialogResult = DialogResult.OK;
            }

            else if(response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                var obj = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                this.ErrorMessage = obj.message;

                this.DialogResult = DialogResult.Abort;
            }

            
        }

        private void chkPasswordProtected_CheckedChanged(object sender, EventArgs e)
        {
            panelPassword.Visible = chkPasswordProtected.Checked;
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkViewPassword.Checked;
        }
    }
}
