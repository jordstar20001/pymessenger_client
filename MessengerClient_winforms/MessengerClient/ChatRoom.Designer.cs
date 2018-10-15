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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.timeGetData = new System.Windows.Forms.Timer(this.components);
            this.btnKickUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(40, 573);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(304, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(40, 39);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(364, 524);
            this.lstMessages.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(350, 573);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(54, 20);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(442, 39);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(139, 524);
            this.lstUsers.TabIndex = 3;
            // 
            // timeGetData
            // 
            this.timeGetData.Interval = 2500;
            this.timeGetData.Tick += new System.EventHandler(this.timeGetData_Tick);
            // 
            // btnKickUser
            // 
            this.btnKickUser.Location = new System.Drawing.Point(442, 573);
            this.btnKickUser.Name = "btnKickUser";
            this.btnKickUser.Size = new System.Drawing.Size(139, 20);
            this.btnKickUser.TabIndex = 4;
            this.btnKickUser.Text = "Kick User";
            this.btnKickUser.UseVisualStyleBackColor = true;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 629);
            this.Controls.Add(this.btnKickUser);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.txtMessage);
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Timer timeGetData;
        private System.Windows.Forms.Button btnKickUser;
    }
}