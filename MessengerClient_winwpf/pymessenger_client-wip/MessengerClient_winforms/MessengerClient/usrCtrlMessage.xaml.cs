using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MessengerClient
{
    /// <summary>
    /// Interaction logic for usrCtrlMessage.xaml
    /// </summary>
    public partial class usrCtrlMessage : UserControl
    {
        public usrCtrlMessage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            
            //usrCtrlMessenger usrCtrlMessenger1 = new usrCtrlMessenger();
            //usrCtrlMessenger1.lblMessage.Content = txtMessage.Text;

            //lstMessages.Items.Add(usrCtrlMessenger1);

        }

        private void txtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            //(System.Windows.Media.Animation.Storyboard)FindResource("StryBrdShowSendBtn").Begin();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer Sender = (ScrollViewer)sender;
            e.Handled = true;
            // Dim i As New Animation.Storyboard
            // i.SetValue(Animation.Storyboard.TargetProperty, Sender)


            try
            {
                Sender.ScrollToVerticalOffset(Sender.VerticalOffset - e.Delta * 10 * System.Windows.Forms.SystemInformation.MouseWheelScrollLines / (double)120);
            }
            catch
            {
            }
        }

        private void btnEmoji_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Focus();
            System.Windows.Forms.Application.DoEvents();
            keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_VKEY, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_VKEY, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0);
        }
        private const int VK_STARTKEY = 0x5B;
        private const int VK_VKEY = 0xba;
        private const int KEYEVENTF_KEYUP = 0x2;
        private const int KEYEVENTF_KEYDOWN = 0x0;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool keybd_event(int bVk, int bScan, int dwFlags, int dwExtraInfo);

        private void btnTK_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Focus();
            try
            {
                System.Diagnostics.Process.Start("tabtip.exe");
            }
            catch
            {

                try
                {
                    System.Diagnostics.Process.Start("osk.exe");
                }
                catch
                {

                    
                }
            }
        }

        private void menuItemCopy_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in lstMessages.SelectedItems)
            {
                try
                {
                    usrCtrlMessenger message = (usrCtrlMessenger)item;
                    Clipboard.SetText(message.lblMessage.Content.ToString());
                }
                catch { }
            }

        }

        private void lstMessages_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.C)
            {
                if (Keyboard.IsKeyDown(Key.LeftCtrl) || (Keyboard.IsKeyDown(Key.RightCtrl)))
                {
                    foreach (var item in lstMessages.SelectedItems)
                    {
                        try
                        {
                            usrCtrlMessenger message = (usrCtrlMessenger)item;
                            Clipboard.SetText(message.lblMessage.Content.ToString());
                        }
                        catch { }
                    }
                }
            }
        }

        private void chkboxSpellCheck_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.SpellCheck.IsEnabled = (bool)chkboxSpellCheck.IsChecked;
        }
    }
}
