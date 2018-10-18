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
    public partial class RoomPasswordDialog : Form
    {
        public string Password = "";

        public RoomPasswordDialog()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chkShowPassword.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RoomPasswordDialog_Load(object sender, EventArgs e)
        {
            this.Font = SystemFonts.MessageBoxFont;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewMouseDown += UsrCtrlPasswordRevealBtn1_MouseDown;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewMouseUp += UsrCtrlPasswordRevealBtn1_MouseUp;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewKeyUp += UsrCtrlPasswordRevealBtn2_KeyDown;
            usrCtrlPasswordRevealBtn1.btnRevealPassword.PreviewKeyDown += BtnRevealPassword_PreviewKeyDown;
        }


        private void BtnRevealPassword_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void UsrCtrlPasswordRevealBtn2_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void UsrCtrlPasswordRevealBtn1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("Up");
            txtPassword.UseSystemPasswordChar = true;
        }

        private void UsrCtrlPasswordRevealBtn1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("Down");
            txtPassword.UseSystemPasswordChar = false;
        }
    }

}
