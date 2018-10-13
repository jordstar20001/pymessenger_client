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

        public static string UserToken;

        public static string Username;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputValid())
            {
                ServerAddress = txtAddress.Text;
                ServerPort = int.Parse(txtPort.Text);
                userForm = new UserAccountManagement();
                userForm.Show();
                this.Hide();
            }
        }

        private bool InputValid()
        {
            return true;


        }

    }

   
}
