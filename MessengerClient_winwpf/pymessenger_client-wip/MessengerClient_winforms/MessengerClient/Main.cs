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

        public static ChatRoom chatRoomForm;

        public static Menu menuForm;

        public static string UserToken;

        public static string Username;

        public static Main i;

        public static NotifyIcon MainNotifyIcon = new NotifyIcon();

        System.Windows.Controls.ContextMenu iconMenu = new System.Windows.Controls.ContextMenu();

        System.Windows.Controls.MenuItem iconMenuItemExit = new System.Windows.Controls.MenuItem();

        System.Windows.Controls.MenuItem iconMenuItemAbout = new System.Windows.Controls.MenuItem();

        System.Windows.Window window = new System.Windows.Window();

        usrCtrlSplash usrCtrlSplash1 = new usrCtrlSplash();

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
                this.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tmrMain = new Timer()
            {
                Interval = 7000
            };
            tmrMain.Tick += TmrMain_Tick;
            usrCtrlSplash1.IsVisibleChanged += UsrCtrlSplash1_IsVisibleChanged;
            System.Windows.Controls.Frame frame = new System.Windows.Controls.Frame();
            window.Content = frame;
            frame.Navigate(new Splash());
            window.AllowsTransparency = true;
            window.WindowStyle = System.Windows.WindowStyle.None;
            window.ResizeMode = System.Windows.ResizeMode.NoResize;
            window.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            window.ShowInTaskbar = false;
            window.Background = null;
            window.Foreground = System.Windows.Media.Brushes.Black;
            window.Show();
            tmrMain.Start();

            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);
            MainNotifyIcon.Icon = Properties.Resources.icon;
            MainNotifyIcon.Visible = true;
            MainNotifyIcon.Click += MainNotifyIcon_Click;
            iconMenuItemAbout.Header = "About";
            iconMenu.Items.Add(iconMenuItemAbout);
            iconMenuItemExit.Header = "Exit";
            iconMenu.Items.Add(iconMenuItemExit);
            iconMenuItemExit.Click += IconMenuItemExit_Click;
            iconMenuItemAbout.Click += IconMenuItemAbout_Click;
            txtAddress.Text = Properties.Settings.Default.messageServer;
            txtPort.Value = Properties.Settings.Default.messageServerPort;
            chkEncryption.Checked = Properties.Settings.Default.useEncryption;
            
        }

        private void UsrCtrlSplash1_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (usrCtrlSplash1.Visibility == System.Windows.Visibility.Collapsed)
            {
                elementHost1.Hide();
            }
        }

        private void IconMenuItemAbout_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void MainNotifyIcon_Click(object sender, EventArgs e)
        {
            if (iconMenu.IsOpen == false)
            {
                iconMenu.IsOpen = true;
            } 
            else if (iconMenu.IsOpen == true)
            {
                iconMenu.IsOpen = false;
            }
        }

        private void IconMenuItemExit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TmrMain_Tick(object sender, EventArgs e)
        {
            window.Close();
            elementHost1.Child = usrCtrlSplash1;
            this.Opacity = 1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
   
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
                       //MessageBox.Show("Found server: " + (await Helpers.Deserialised<FromAPI.NameContainer>(response)).name);
                        userForm = new UserAccountManagement();
                        userForm.Show();
                        Properties.Settings.Default.messageServer = txtAddress.Text;
                        Properties.Settings.Default.messageServerPort = (int)txtPort.Value;
                        Properties.Settings.Default.useEncryption = chkEncryption.Checked;

                        this.Hide();
                        //this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Error. Server may be offline.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch
                {
                    MessageBox.Show("Error. Either server not found at that address, or encryption does not match your selection.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            panel1.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Blocks;

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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count < 2)
            {
                Application.Exit();
            }


            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
            txtAddress.Text = Properties.Settings.Default.messageServer;
            txtPort.Value = Properties.Settings.Default.messageServerPort;
            chkEncryption.Checked = Properties.Settings.Default.useEncryption;
        }
    }

   
}
