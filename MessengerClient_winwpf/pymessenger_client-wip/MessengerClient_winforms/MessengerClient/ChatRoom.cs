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
    public partial class ChatRoom : Form
    {
        private string messages = "";

        private FromAPI.GetMessagesContainer msgData = new FromAPI.GetMessagesContainer();

        List<string> Users = new List<string>();

        public FromAPI.GetMessagesContainer currentMessageData

        {
            set
            {
                
                
                    CurrentMessageData_Changed(value);
                    msgData = value;
                
            }
        }

        private string RoomOwner;

        private string users;

        public ChatRoom()
        {
            InitializeComponent();
        }

        public ChatRoom(string roomOwner)
        {
            InitializeComponent();
            RoomOwner = roomOwner;
        }

        private async void NewBtnSend_Click()
        {
            var request = new ToAPI.SendMessageToChatRoomContainer()
            {
                username = Main.Username,
                owner = RoomOwner,
                message = txtMessage.Text
            };

            var response = await Helpers.PostRequestAsync("/2/chatrooms/message", Main.UserToken, request);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                txtMessage.Text = "";
                return;
            }

            else
            {
                var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                var error = data.message;

                MessageBox.Show("Error. " + error);

            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var request = new ToAPI.SendMessageToChatRoomContainer()
            {
                username = Main.Username,
                owner = RoomOwner,
                message = txtMessage.Text
            };

            var response = await Helpers.PostRequestAsync("/2/chatrooms/message", Main.UserToken, request);

            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                usrCtrlMessage1.txtMessage.Text = "";
                return;
            }

            else
            {
                var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                var error = data.message;

                MessageBox.Show("Error. " + error);

            }
            

        }

        private async void timeGetData_Tick(object sender, EventArgs e)
        {
            try
            {
                var ownerHeader = new Extras.Header()
                {
                    name = "Owner",
                    value = RoomOwner
                };

                var response = await Helpers.GetRequestAsync("/2/chatrooms/message", Main.UserToken, ownerHeader);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    currentMessageData = await Helpers.Deserialised<FromAPI.GetMessagesContainer>(response);
                }
                else
                {
                    var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);
                    timeGetData.Stop();
                    MessageBox.Show(data.message);
                    timeGetData.Start();
                    if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                    {
                        this.Close();
                    }
                }


                // Get users.

                var userGetReq = new ToAPI.GetChatRoomContainer()
                {
                    owner = RoomOwner
                };

                var usersResponse = await Helpers.PostRequestAsync("/2/chatrooms/get", Main.UserToken, userGetReq);

                var respDict = await Helpers.Deserialised<FromAPI.SingleRoomContainer>(usersResponse);



                //Users.Clear();

                string newUsers = "";

                foreach (var user in respDict.users)
                {
                    newUsers = newUsers + "\n" + user;
                    //Users.Add(user);
                }
                if (newUsers != users)
                {
                    //ListBox.SelectedIndexCollection indicies = lstUsers.SelectedIndices;
                    users = "";
                    usrCtrlMessage1.lstUsers.Items.Clear();
                    foreach (var user in respDict.users)
                    {
                        users = users + "\n" + user;
                        usrCtrlMessage1.lstUsers.Items.Add(user);
                        //Users.Add(user);
                    }
                    //usrCtrlMessage1.lstUsers.set
                    //foreach (var index in indicies)
                    //{

                    //}



                    //foreach (var user in Users)
                    //{
                    //    usrCtrlMessage1.lstUsers.Items.Add(user);
                    //}



                }
            }
            catch { }
            
        }

        private void CurrentMessageData_Changed(FromAPI.GetMessagesContainer data)
        {
            try
            {
                rchTxtMessages.SuspendLayout();

                rchTxtMessages.Clear();

                var formatter = new RichTextBox();

                //foreach (var message in data.messages)
                //{
                //    int lengthOfTxt = rchTxtMessages.Text.Length;
                //    int lengthOfMessage = message.message.Length;
                //    formatter.AppendText(string.Format("{0} SAID: {1}\n\n", message.sender.ToUpper(), message.message));
                //    formatter.Select(lengthOfTxt, message.sender.Length + " SAID: ".Length);
                //    formatter.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Bold);
                //    formatter.Select(lengthOfTxt + message.sender.Length + " SAID: ".Length, lengthOfMessage);
                //    formatter.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Italic);
                //    formatter.DeselectAll();
                //}

                //rchTxtMessages.Text = formatter.Text;

                rchTxtMessages.Enabled = false;

                foreach (var message in data.messages)
                {
                    int lengthOfTxt = rchTxtMessages.Text.Length;
                    int lengthOfMessage = message.message.Length;
                    rchTxtMessages.AppendText(string.Format("{0} SAID: {1}\n", message.sender.ToUpper(), message.message));
                    rchTxtMessages.Select(lengthOfTxt, message.sender.Length + " SAID: ".Length);
                    rchTxtMessages.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Bold);
                    rchTxtMessages.Select(lengthOfTxt + message.sender.Length + " SAID: ".Length, lengthOfMessage);
                    rchTxtMessages.SelectionFont = new Font(rchTxtMessages.Font, FontStyle.Italic);
                    rchTxtMessages.DeselectAll();
                }

                rchTxtMessages.Enabled = true;

                rchTxtMessages.ScrollToCaret();

                rchTxtMessages.ResumeLayout();

                if (rchTxtMessages.Text != messages)
                {
                    messages = rchTxtMessages.Text;
                    usrCtrlMessage1.lstMessages.Items.Clear();

                    foreach (var message in rchTxtMessages.Lines)
                    {
                        usrCtrlMessenger usrCtrlMessenger1 = new usrCtrlMessenger();
                        usrCtrlMessenger1.lblMessage.Content = message;

                        usrCtrlMessage1.lstMessages.Items.Add(usrCtrlMessenger1);
                    }
                    usrCtrlMessage1.lstMessages.UpdateLayout();
                    usrCtrlMessage1.lstMessages.ScrollIntoView(usrCtrlMessage1.lstMessages.Items.GetItemAt(usrCtrlMessage1.lstMessages.Items.Count - 1));
                    usrCtrlMessenger lastMessage = (usrCtrlMessenger)usrCtrlMessage1.lstMessages.Items.GetItemAt(usrCtrlMessage1.lstMessages.Items.Count - 2);
                    if (lastMessage.lblMessage.Content.ToString().ToUpper().StartsWith(Main.Username.ToUpper()) == false) { 
                        Main.MainNotifyIcon.ShowBalloonTip(7000, "jMessages", lastMessage.lblMessage.Content.ToString().ToUpper(), ToolTipIcon.None);
}
                }
            }
            catch
            { }
            }
            

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            Font = System.Drawing.SystemFonts.MessageBoxFont;
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);
            try
            {
                AddTouchKeyboardSupport();
            }
            catch
            {

            }
            usrCtrlMessage1.btnSend.Click += BtnSend_Click;
            usrCtrlMessage1.btnLeave.Click += BtnLeave_Click;
            usrCtrlMessage1.sldrOpacity.ValueChanged += SldrOpacity_ValueChanged;
            usrCtrlMessage1.menuItemKick.Click += MenuItemCopy_Click;
            usrCtrlMessage1.chkboxTopmost.Click += ChkboxTopmost_Click;
            timeGetData.Enabled = true;
        }

        private void ChkboxTopmost_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.TopMost = (bool)usrCtrlMessage1.chkboxTopmost.IsChecked;
        }

        private async void MenuItemCopy_Click(object sender, System.Windows.RoutedEventArgs e)
        {

           //MessageBox.Show("T");
                foreach (string userToKick in usrCtrlMessage1.lstUsers.SelectedItems)
                {
                    //var userToKick = (string)lstUsers.Items[lstUsers.SelectedIndex];

                    var reqHeaders = new List<Extras.Header>()
                {
                    new Extras.Header()
                    {
                        name="Owner",
                        value=RoomOwner
                    },

                    new Extras.Header()
                    {
                        name="UserKick",
                        value=userToKick
                    }
                };
                
                    var response = await Helpers.DeleteRequestAsync("/2/chatrooms/management/users", Main.UserToken, reqHeaders);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show(string.Format("User {0} was kicked from the room.", userToKick), Application.ProductName);
                    }

                    else
                    {
                        var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                        MessageBox.Show(data.message, Application.ProductName);
                    }
                }
            
        }

        private void SldrOpacity_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            this.Opacity = usrCtrlMessage1.sldrOpacity.Value;
        }

        private void BtnLeave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private async void BtnSend_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //MessageBox.Show(usrCtrlMessage1.txtMessage.Text);
            var request = new ToAPI.SendMessageToChatRoomContainer()
            {
                username = Main.Username,
                owner = RoomOwner,
                message = usrCtrlMessage1.txtMessage.Text
            };

            var response = await Helpers.PostRequestAsync("/2/chatrooms/message", Main.UserToken, request);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                usrCtrlMessage1.txtMessage.Text = "";
                return;
            }

            else
            {
                var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                var error = data.message;

                MessageBox.Show("Error. " + error);

            }
            //txtMessage.Text = "";
        }

        private async void btnKickUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex > -1)
            {


                var userToKick = (string)lstUsers.Items[lstUsers.SelectedIndex];

                var reqHeaders = new List<Extras.Header>()
                {
                    new Extras.Header()
                    {
                        name="Owner",
                        value=RoomOwner
                    },

                    new Extras.Header()
                    {
                        name="UserKick",
                        value=userToKick
                    }
                };

                var response = await Helpers.DeleteRequestAsync("/2/chatrooms/management/users", Main.UserToken, reqHeaders);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(string.Format("User {0} was kicked from the room.", userToKick));
                }

                else
                {
                    var data = await Helpers.Deserialised<FromAPI.ErrorMessageContainer>(response);

                    MessageBox.Show(data.message);
                }
            }

        }

        private async void ChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {

            var userToKick = Main.Username;

            var reqHeaders = new List<Extras.Header>()
            {
                new Extras.Header()
                {
                    name="Owner",
                    value=RoomOwner
                },

                new Extras.Header()
                {
                    name="UserKick",
                    value=userToKick
                }
            };

            var response = await Helpers.DeleteRequestAsync("/2/chatrooms/management/users", Main.UserToken, reqHeaders);
        
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSend_Click(null, EventArgs.Empty);
            }
        }

        public void TKShowing(Windows.UI.ViewManagement.Core.CoreInputView sender, Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs args)
        {
            //MessageBox.Show("TK");
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    usrCtrlMessage1.Margin = new System.Windows.Thickness(0);
                    usrCtrlMessage1.UpdateLayout();

                    bool MoveUp = false;
                    double MoveUpBy = 0;
                    foreach (var Occlusion in Windows.UI.ViewManagement.Core.CoreInputView.GetForCurrentView().GetCoreInputViewOcclusions())
                    {
                        //Console.WriteLine(Occlusion.OccludingRect.Height);
                        if (Occlusion.OcclusionKind == Windows.UI.ViewManagement.Core.CoreInputViewOcclusionKind.Docked)
                        {
                            MoveUp = true;

                            MoveUpBy = Occlusion.OccludingRect.Height;
                        }
                    }
                    try
                    {
                        //System.Resources("strybrdTK").Children.Item(0).KeyFrames.Item(0).Value = MoveUpBy;
                        //System.Resources("strybrdTK").Begin();
                        //return;
                    }
                    catch
                    {
                    }
                    if (MoveUp == true)
                    {
                        // MsgBox(PresentationSource.FromVisual(Me).CompositionTarget.TransformFromDevice.M11)
                        // MsgBox(MoveUpBy)
                        usrCtrlMessage1.Margin = new System.Windows.Thickness(0, 0, 0, MoveUpBy); // * PresentationSource.FromVisual(Me).CompositionTarget.TransformFromDevice.M11
                        //object f = usrCtrlMessage1.FocusManager.GetFocusedElement(this);
                        //f.BringIntoView();
                    }
                    else
                        usrCtrlMessage1.Margin = new System.Windows.Thickness(0);
                }
            }
            catch
            {
            }

        }

        public void AddTouchKeyboardSupport()
        {
            try
            {
                Windows.UI.ViewManagement.Core.CoreInputView.GetForCurrentView().OcclusionsChanged += TKShowing;
            }
            catch
            {
            }
        }

        private void ChatRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            timeGetData.Stop();
        }
    }

}
