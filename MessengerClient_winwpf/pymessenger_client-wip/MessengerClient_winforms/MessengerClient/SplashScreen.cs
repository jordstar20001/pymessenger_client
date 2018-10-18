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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //Application.Run(new Main());
            tmrMain.Stop();
            this.Hide();
            Main main = new Main();
            main.Show();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //AnimateWindow(this.Handle, 0x000000C8, 0x00080010);
            //while (this.Opacity < 1)
            //    {
            //    this.Opacity += 0.01;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(100);
            //}
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            //Application.DoEvents();
            //this.Opacity += 0.05;
            System.Windows.Window window = new System.Windows.Window();
            System.Windows.Controls.Frame frame = new System.Windows.Controls.Frame();
            window.Content = frame;
            frame.Navigate(new Splash());
            window.AllowsTransparency = true;
            window.WindowStyle = System.Windows.WindowStyle.None;
            window.ResizeMode = System.Windows.ResizeMode.NoResize;
            window.Show();
            tmrMain.Start();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
    
       
    }
    }
    //[DllImport("User32.dll")]
    //private static extern IntPtr GetWindowDC(IntPtr hWnd);

    

