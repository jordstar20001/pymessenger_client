namespace MessengerClient
{
    partial class ChatRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatRoom));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.timeGetData = new System.Windows.Forms.Timer(this.components);
            this.btnKickUser = new System.Windows.Forms.Button();
            this.rchTxtMessages = new System.Windows.Forms.RichTextBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.usrCtrlMessage1 = new MessengerClient.usrCtrlMessage();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(53, 881);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(404, 27);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Visible = false;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(467, 881);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(589, 60);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(184, 804);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.Visible = false;
            // 
            // timeGetData
            // 
            this.timeGetData.Interval = 1500;
            this.timeGetData.Tick += new System.EventHandler(this.timeGetData_Tick);
            // 
            // btnKickUser
            // 
            this.btnKickUser.Location = new System.Drawing.Point(589, 881);
            this.btnKickUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKickUser.Name = "btnKickUser";
            this.btnKickUser.Size = new System.Drawing.Size(185, 31);
            this.btnKickUser.TabIndex = 4;
            this.btnKickUser.Text = "Kick User";
            this.btnKickUser.UseVisualStyleBackColor = true;
            this.btnKickUser.Visible = false;
            this.btnKickUser.Click += new System.EventHandler(this.btnKickUser_Click);
            // 
            // rchTxtMessages
            // 
            this.rchTxtMessages.Location = new System.Drawing.Point(53, 60);
            this.rchTxtMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchTxtMessages.Name = "rchTxtMessages";
            this.rchTxtMessages.ReadOnly = true;
            this.rchTxtMessages.Size = new System.Drawing.Size(484, 804);
            this.rchTxtMessages.TabIndex = 5;
            this.rchTxtMessages.Text = "";
            this.rchTxtMessages.Visible = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(782, 752);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.usrCtrlMessage1;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 752);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.rchTxtMessages);
            this.Controls.Add(this.btnKickUser);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ChatRoom";
            this.Text = "Chat Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatRoom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatRoom_FormClosed);
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Timer timeGetData;
        private System.Windows.Forms.Button btnKickUser;
        private System.Windows.Forms.RichTextBox rchTxtMessages;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private usrCtrlMessage usrCtrlMessage1;
    }
}