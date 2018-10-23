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
    /// Interaction logic for usrCtrlSplash.xaml
    /// </summary>
    public partial class usrCtrlSplash : UserControl
    {
        public usrCtrlSplash()
        {
            InitializeComponent();
        }

        private void userControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (SystemParameters.IsGlassEnabled)
            {
                this.Background = SystemParameters.WindowGlassBrush;
            }
        }
    }
}
