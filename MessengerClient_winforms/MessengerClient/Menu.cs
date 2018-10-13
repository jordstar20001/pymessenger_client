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
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            var response = await Helpers.DeleteRequestAsync("/1/login", Main.UserToken);
            Main.menuForm = null;
            Main.i.Show();
            this.Close();
            this.DestroyHandle();
        }

        private async void timeCheckForUsers_Tick(object sender, EventArgs e)
        {
            var response = await Helpers.GetRequestAsync("/2/users", Main.UserToken);
            FromAPI.OnlineUsersContainer container = await Helpers.Deserialised<FromAPI.OnlineUsersContainer>(response);
            var users = container.users;

            lstUsersOnline.Items.Clear();

            foreach(string user in users)
            {
                lstUsersOnline.Items.Add(user);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timeCheckForUsers.Enabled = true;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLogout_Click(null, EventArgs.Empty);
        }
    }
}
