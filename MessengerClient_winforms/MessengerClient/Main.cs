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
    public partial class Main : Form
    {
        public static string ServerAddress;

        public static int ServerPort;

        public static UserAccountManagement userForm;

        public static Menu menuForm;

        public static string UserToken;

        public static string Username;

        public static Main i;

        public Main()
        {
            InitializeComponent();
            if (i == null)
            {
                i = this;
            }
            else if(i != this)
            {

                this.Close();
                this.DestroyHandle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            if (InputValid())
            {
                ServerAddress = txtAddress.Text;
                ServerPort = int.Parse(txtPort.Text);

                if(!(ServerAddress.StartsWith("http://") || ServerAddress.StartsWith("https://")))
                {
                    if (chkEncryption.Checked)
                    {
                        ServerAddress = "https://" + ServerAddress;
                    }

                    else
                    {
                        ServerAddress = "http://" + ServerAddress;
                    }
                }

                //MessageBox.Show(ServerAddress, )

                try
                {
                    var response = await Helpers.GetRequestAsync("/0");
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Found server: " + (await Helpers.Deserialised<FromAPI.NameContainer>(response)).name);
                        userForm = new UserAccountManagement();
                        userForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Error. Server may be offline.");
                    }
                }

                catch
                {
                    MessageBox.Show("Error. Either server not found at that address, or encryption does not match your selection.");
                }
            }

            btnOpen.Enabled = true;

        }

        private bool InputValid()
        {
            try
            {
                int.Parse(txtPort.Text);
            }

            catch
            {
                MessageBox.Show("Error. Port must be an integer.");
                return false;
            }

            var port = int.Parse(txtPort.Text); 

            if (port < 0 || port > 65535)
            {
                MessageBox.Show("Error. Port not within range (0 to 65535)");
                return false;
            }

            return true;


        }

    }

   
}
