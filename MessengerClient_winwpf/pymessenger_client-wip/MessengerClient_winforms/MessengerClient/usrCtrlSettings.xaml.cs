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
    /// Interaction logic for usrCtrlSettings.xaml
    /// </summary>
    public partial class usrCtrlSettings : UserControl
    {
        public usrCtrlSettings()
        {
            InitializeComponent();
        }


        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to save settings because the following error occured:" + ex.Message, System.Windows.Forms.Application.ProductName);
            }
            btnApply.IsEnabled = false;
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            propertyGrdMySettings.SelectedObject = Properties.Settings.Default;
            chkboxSpellCheck.IsChecked = Properties.Settings.Default.spellCheckEabled;
            txtAddress.Text = Properties.Settings.Default.messageServer;
            numUpDownPort.Text = Properties.Settings.Default.messageServerPort.ToString();
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
            System.Windows.Media.Animation.Storyboard strybrdFadeIn = (System.Windows.Media.Animation.Storyboard)FindResource("strybrdFadeIn");
            strybrdFadeIn.Begin();
        }

        private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            btnApply.IsEnabled = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            
            Properties.Settings.Default.Reload();
        
        }

        private void btnDefaults_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Reset();
            if (MessageBox.Show("Are you sure you want to reset settings to defaults?", System.Windows.Forms.Application.ProductName, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                System.Windows.Media.Animation.Storyboard strybrdFadeOut = (System.Windows.Media.Animation.Storyboard)FindResource("strybrdFadeOut");
                strybrdFadeOut.Begin();
}
        }

        private void lnkAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void chkboxSpellCheck_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.spellCheckEabled = (bool)chkboxSpellCheck.IsChecked;

        }

        private void txtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.messageServer = txtAddress.Text;
        }

        private void numUpDownPort_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.messageServerPort = int.Parse(numUpDownPort.Text);
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            UserControl_Loaded(null, null);
        }
    }
}
