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
            var uName = txtSignupUsername.Text;

            var pWord = txtSignupPassword.Text;

            if (!LoginInputValid())
            {
                // Error message
                return;
            }


            var loginObj = new ToAPI.UserLogin(uName, pWord);


            var response = await Helpers.PostRequestAsync("/1/signup", loginObj);

            
            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Account created! Logging in...");
                var statusCode = await LoginUser(uName, pWord);
                if(statusCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("Successfully logged in.");
                    Main.menuForm = new Menu();
                    Main.menuForm.Show();
                    this.Close();
                    this.DestroyHandle();
                }

                else if(statusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Error. User not found.");
                }

                else if(statusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Error. Check that you are not already logged in elsewhere.");
                }
            }

            else if(response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                MessageBox.Show("Error when signing up. " + (await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response)).message); 
            }
        }

        private bool LoginInputValid()
        {
            return true;
        }

        private async Task<System.Net.HttpStatusCode> LoginUser(string uname, string pword)
        {
            var loginObj = new ToAPI.UserLogin(uname, pword);
            var response = await Helpers.PostRequestAsync("/1/login", loginObj);
            // Get JSON 
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                FromAPI.TokenContainer container = await Helpers.Deserialised<FromAPI.TokenContainer>(response);
                Main.UserToken = container.token;
                
            }

            return response.StatusCode;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var uName = txtLoginUsername.Text;

            var pWord = txtLoginPassword.Text;

            var loginObj = new ToAPI.UserLogin(uName, pWord);

            var statusCode = await LoginUser(uName, pWord);
            if (statusCode == System.Net.HttpStatusCode.Accepted)
            {
                MessageBox.Show("Successfully logged in.");
                Main.menuForm = new Menu();
                Main.menuForm.Show();
                this.Close();
                this.DestroyHandle();
                
            }

            else if (statusCode == System.Net.HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Error. User not found.");
            }

            else if (statusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                MessageBox.Show("Error. Check that you are not already logged in elsewhere.");
            }
            
        }
    }

    
}
