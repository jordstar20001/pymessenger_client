using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
namespace MessengerClient
{
    

    public partial class UserAccountManagement : Form
    {
        

        public UserAccountManagement()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            if (!LoginValid())
            {
                // Error message
                return;
            }


            var loginObj = new UserLogin(txtSignupUsername.Text, txtSignupPassword.Text);


            var response = await Helpers.PostRequestAsync("/1/signup", loginObj);

            
            MessageBox.Show(response.ToString());
        }

        private bool LoginValid()
        {
            return true;
        }
    }

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
