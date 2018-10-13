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
            if (!LoginInputValid())
            {
                // Error message
                return;
            }


            var loginObj = new API.UserLogin(txtSignupUsername.Text, txtSignupPassword.Text);


            var response = await Helpers.PostRequestAsync("/1/signup", loginObj);

            
            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Account created! Logging in...");
                
            }
        }

        private bool LoginInputValid()
        {
            return true;
        }

        private async bool LoginUser(string uname, string pword)
        {
            var loginObj = new API.UserLogin(uname, pword);
            var response = await Helpers.PostRequestAsync("/1/login", loginObj);
            // Get JSON / 
            if(response.StatusCode = System.Net.HttpStatusCode.)
            JsonConvert.DeserializeObject<>
            if (response.)
        }
    }

    
}
