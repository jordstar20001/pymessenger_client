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
        private usrCtrlPasswordRevealBtn usrCtrlPasswordRevealBtn1 = new usrCtrlPasswordRevealBtn();
        private bool exitOnClose = true;
        private async void btnSignup_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastUserName = txtSignupUsername.Text;

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
                //MessageBox.Show("Account created! Logging in...");
                var statusCode = await LoginUser(uName, pWord);
                if(statusCode == System.Net.HttpStatusCode.Accepted)
                {
                    //MessageBox.Show("Successfully logged in.");
                    Main.menuForm = new Menu();
                    Main.menuForm.Show();
                    exitOnClose = false;
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
                Main.Username = loginObj.username;
            }

            return response.StatusCode;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Properties.Settings.Default.LastUserName = txtSignupUsername.Text;
            var uName = txtSignupUsername.Text;

            var pWord = txtSignupPassword.Text;

            var loginObj = new ToAPI.UserLogin(uName, pWord);

            var statusCode = await LoginUser(uName, pWord);
            if (statusCode == System.Net.HttpStatusCode.Accepted)
            {
               // MessageBox.Show("Successfully logged in.");
                Main.menuForm = new Menu();
                Main.menuForm.Show();
                exitOnClose = false;
                this.Close();
                this.DestroyHandle();
                
            }

            else if (statusCode == System.Net.HttpStatusCode.Forbidden)
            {
                MessageBox.Show("Error. User not found.", Application.ProductName);
            }

            else if (statusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                MessageBox.Show("Error. Check that you are not already logged in elsewhere.", Application.ProductName);
            }
            this.Enabled = true;
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserAccountManagement_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void UserAccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (exitOnClose)
                {
                    Application.Exit();
                }



            }//Application.Exit();
        }

        private void UserAccountManagement_Load(object sender, EventArgs e)
        {
            usrCtrlPasswordRevealBtn2.btnRevealPassword.PreviewMouseDown += UsrCtrlPasswordRevealBtn1_MouseDown;
            usrCtrlPasswordRevealBtn2.btnRevealPassword.PreviewMouseUp += UsrCtrlPasswordRevealBtn1_MouseUp;
            usrCtrlPasswordRevealBtn2.btnRevealPassword.PreviewKeyUp += UsrCtrlPasswordRevealBtn2_KeyDown;
            usrCtrlPasswordRevealBtn2.btnRevealPassword.PreviewKeyDown += BtnRevealPassword_PreviewKeyDown;
            try
            {
            txtSignupUsername.Text = Properties.Settings.Default.LastUserName;
            }
            catch
            {

             
            }

            //elementHost1.Child = usrCtrlPasswordRevealBtn1;
        }

        private void BtnRevealPassword_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtSignupPassword.UseSystemPasswordChar = false;              
        }
    }

        private void UsrCtrlPasswordRevealBtn2_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtSignupPassword.UseSystemPasswordChar = true;
            }
        }

        private void UsrCtrlPasswordRevealBtn1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           //MessageBox.Show("Up");
            txtSignupPassword.UseSystemPasswordChar = true;
        }

        private void UsrCtrlPasswordRevealBtn1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("Down");
            txtSignupPassword.UseSystemPasswordChar = false;        }

        private void splitContainer1_Panel1_Enter(object sender, EventArgs e)
        {
            //this.AcceptButton = btnSignup;
        }

        private void splitContainer1_Panel2_Enter(object sender, EventArgs e)
        {
            //this.AcceptButton = btnLogin;
        }
    }

    
}
