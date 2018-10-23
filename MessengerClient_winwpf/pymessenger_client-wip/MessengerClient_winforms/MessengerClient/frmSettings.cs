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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {

            }
            Font = SystemFonts.MessageBoxFont;
            usrCtrlSettings1.btnCancel.Click += CloseBtn_Click;
            usrCtrlSettings1.btnOk.Click += CloseBtn_Click;
        }

        private void CloseBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
