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
            txtDescription.Font = System.Drawing.SystemFonts.MessageBoxFont;
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewMouseDown += UsrCtrlPasswordRevealBtn1_MouseDown;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewMouseUp += UsrCtrlPasswordRevealBtn1_MouseUp;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewKeyUp += UsrCtrlPasswordRevealBtn2_KeyDown;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewKeyDown += BtnRevealPassword_PreviewKeyDown;
            validateInput();
        }


        private void BtnRevealPassword_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void UsrCtrlPasswordRevealBtn2_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void UsrCtrlPasswordRevealBtn1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("Up");
            txtPassword.UseSystemPasswordChar = true;
        }

        private void UsrCtrlPasswordRevealBtn1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("Down");
            txtPassword.UseSystemPasswordChar = false;
        }

        private async void btnCreateRoom_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
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

                MessageBox.Show("Error. " + this.ErrorMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("An unknown error occurred.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;

            
        }

        private void chkPasswordProtected_CheckedChanged(object sender, EventArgs e)
        {
            panelPassword.Visible = chkPasswordProtected.Checked;
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkViewPassword.Checked;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            validateInput();
        }

        private void validateInput()
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                btnCreateRoom.Enabled = false;
            }
            else
            {
                btnCreateRoom.Enabled = true;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            validateInput();
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnCreateRoom;
        }
    }
}
