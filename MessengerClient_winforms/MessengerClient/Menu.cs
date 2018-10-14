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
    public partial class Menu : Form
    {
        private List<string> usersOnline = new List<string>();

        private List<string> roomsOnline = new List<string>();

        public Menu()
        {
            InitializeComponent();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            
            var response = await Helpers.DeleteRequestAsync("/1/login", Main.UserToken);
            Main.menuForm = null;
            Main.i.Show();
            this.Dispose();
        }

        private async void timeCheckForUsers_Tick(object sender, EventArgs e)
        {
            var response = await Helpers.GetRequestAsync("/2/users", Main.UserToken);
            FromAPI.OnlineUsersContainer container = await Helpers.Deserialised<FromAPI.OnlineUsersContainer>(response);
            var users = container.users;

            if(users != usersOnline)
            {
                usersOnline = users;
                var selectedIndex = lstUsersOnline.SelectedIndex;
                lstUsersOnline.Items.Clear();
                foreach (string user in usersOnline)
                {

                    lstUsersOnline.Items.Add(user);
                }

                try
                {
                    lstUsersOnline.SelectedIndex = selectedIndex;
                }
                catch
                {
                    lstUsersOnline.SelectedIndex = -1;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timeCheckForUsers.Enabled = true;
            timeCheckForRooms.Enabled = true;

            txtToken.Text = Main.UserToken;
            txtUsername.Text = Main.Username;

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(null, EventArgs.Empty);
        }

        private async void timeCheckForRooms_Tick(object sender, EventArgs e)
        {
            var response = await Helpers.GetRequestAsync("/2/chatrooms/getall", Main.UserToken);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                FromAPI.AllRoomsContainer container = await Helpers.Deserialised<FromAPI.AllRoomsContainer>(response);
                
                if (roomsOnline != container.rooms)
                {
                    roomsOnline = container.rooms;
                    var selectedIndex = lstRooms.SelectedIndex;
                    lstRooms.Items.Clear();
                    foreach(string room in roomsOnline)
                    {
                        lstRooms.Items.Add(room);
                    }

                    try
                    {
                        lstRooms.SelectedIndex = selectedIndex;
                    }

                    catch
                    {
                        lstRooms.SelectedIndex = -1;
                    }
                }
                

            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            var roomCreator = new CreateRoomDialog();

            var verdict = roomCreator.ShowDialog();

            if (verdict == DialogResult.OK)
            {

                MessageBox.Show("Done!");
            }

            else if(verdict == DialogResult.Abort)
            {
                
                MessageBox.Show("Error. " + roomCreator.ErrorMessage);
                
            }
            
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstRooms.Items.Count == 0)
            {
                lstRooms.SelectedIndex = -1;
                panelSingleRoom.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void lstRooms_Click(object sender, EventArgs e)
        {

            if(lstRooms.SelectedIndex != -1)
            {
                panelSingleRoom.Visible = true;
            }

            try
            {
                var request = new ToAPI.GetChatRoomContainer()
                {
                    owner = roomsOnline[lstRooms.SelectedIndex]

                };
                var response = await Helpers.PostRequestAsync("/2/chatrooms/get", Main.UserToken, request);
                FromAPI.SingleRoomContainer container = await Helpers.Deserialised<FromAPI.SingleRoomContainer>(response);

                // Set textbox values

                txtTitle.Text = container.title;

                txtOwner.Text = roomsOnline[lstRooms.SelectedIndex];

                txtUsers.Text = container.users.Count + "/" + container.max_users;

                lstRoomUsers.Items.Clear();

                foreach (string user in container.users)
                {
                    lstRoomUsers.Items.Add(user);
                }

                txtDescription.Text = container.description;

                chkPasswordProtected.Checked = container.password_enabled;
            }
            catch
            {

            }

        }
    }
}
