namespace MessengerClient
{
    partial class Menu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstUsersOnline = new System.Windows.Forms.ListBox();
            this.timeCheckForUsers = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.panelSingleRoom = new System.Windows.Forms.Panel();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstRoomUsers = new System.Windows.Forms.ListBox();
            this.chkPasswordProtected = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJoinRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.timeCheckForRooms = new System.Windows.Forms.Timer(this.components);
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelSingleRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(773, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 72);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(473, 3);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(107, 49);
            this.btnCreateRoom.TabIndex = 1;
            this.btnCreateRoom.Text = "+";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lstUsersOnline
            // 
            this.lstUsersOnline.FormattingEnabled = true;
            this.lstUsersOnline.Location = new System.Drawing.Point(62, 105);
            this.lstUsersOnline.Name = "lstUsersOnline";
            this.lstUsersOnline.Size = new System.Drawing.Size(247, 524);
            this.lstUsersOnline.TabIndex = 3;
            // 
            // timeCheckForUsers
            // 
            this.timeCheckForUsers.Interval = 1000;
            this.timeCheckForUsers.Tick += new System.EventHandler(this.timeCheckForUsers_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstRooms);
            this.panel1.Controls.Add(this.panelSingleRoom);
            this.panel1.Controls.Add(this.btnCreateRoom);
            this.panel1.Location = new System.Drawing.Point(361, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 525);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rooms Available";
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(13, 65);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(236, 446);
            this.lstRooms.TabIndex = 6;
            this.lstRooms.Click += new System.EventHandler(this.lstRooms_Click);
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // panelSingleRoom
            // 
            this.panelSingleRoom.Controls.Add(this.txtUsers);
            this.panelSingleRoom.Controls.Add(this.label6);
            this.panelSingleRoom.Controls.Add(this.lstRoomUsers);
            this.panelSingleRoom.Controls.Add(this.chkPasswordProtected);
            this.panelSingleRoom.Controls.Add(this.label5);
            this.panelSingleRoom.Controls.Add(this.btnJoinRoom);
            this.panelSingleRoom.Controls.Add(this.label3);
            this.panelSingleRoom.Controls.Add(this.label2);
            this.panelSingleRoom.Controls.Add(this.txtTitle);
            this.panelSingleRoom.Controls.Add(this.txtOwner);
            this.panelSingleRoom.Controls.Add(this.txtDescription);
            this.panelSingleRoom.Location = new System.Drawing.Point(255, 58);
            this.panelSingleRoom.Name = "panelSingleRoom";
            this.panelSingleRoom.Size = new System.Drawing.Size(325, 464);
            this.panelSingleRoom.TabIndex = 9;
            this.panelSingleRoom.Visible = false;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(105, 101);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ReadOnly = true;
            this.txtUsers.Size = new System.Drawing.Size(87, 20);
            this.txtUsers.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Users";
            // 
            // lstRoomUsers
            // 
            this.lstRoomUsers.FormattingEnabled = true;
            this.lstRoomUsers.Location = new System.Drawing.Point(15, 130);
            this.lstRoomUsers.Name = "lstRoomUsers";
            this.lstRoomUsers.Size = new System.Drawing.Size(292, 108);
            this.lstRoomUsers.TabIndex = 13;
            // 
            // chkPasswordProtected
            // 
            this.chkPasswordProtected.AutoSize = true;
            this.chkPasswordProtected.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPasswordProtected.Enabled = false;
            this.chkPasswordProtected.Location = new System.Drawing.Point(122, 367);
            this.chkPasswordProtected.Name = "chkPasswordProtected";
            this.chkPasswordProtected.Size = new System.Drawing.Size(121, 17);
            this.chkPasswordProtected.TabIndex = 14;
            this.chkPasswordProtected.Text = "Password Protected";
            this.chkPasswordProtected.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinRoom.Location = new System.Drawing.Point(15, 403);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(292, 49);
            this.btnJoinRoom.TabIndex = 10;
            this.btnJoinRoom.Text = "Join Room";
            this.btnJoinRoom.UseVisualStyleBackColor = true;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Owner:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(202, 20);
            this.txtTitle.TabIndex = 9;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(105, 64);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(202, 20);
            this.txtOwner.TabIndex = 8;
            this.txtOwner.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 257);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(292, 90);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // timeCheckForRooms
            // 
            this.timeCheckForRooms.Interval = 2000;
            this.timeCheckForRooms.Tick += new System.EventHandler(this.timeCheckForRooms_Tick);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(361, 21);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(249, 20);
            this.txtToken.TabIndex = 6;
            this.txtToken.Text = "txtToken";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(361, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUsersOnline);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSingleRoom.ResumeLayout(false);
            this.panelSingleRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstUsersOnline;
        private System.Windows.Forms.Timer timeCheckForUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Panel panelSingleRoom;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstRoomUsers;
        private System.Windows.Forms.CheckBox chkPasswordProtected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJoinRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Timer timeCheckForRooms;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtUsername;
    }
}