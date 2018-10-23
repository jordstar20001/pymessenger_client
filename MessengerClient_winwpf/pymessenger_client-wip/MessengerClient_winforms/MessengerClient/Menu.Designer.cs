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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
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
            this.lblUnlock = new System.Windows.Forms.Label();
            this.lblLock = new System.Windows.Forms.Label();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timeCheckForRooms = new System.Windows.Forms.Timer(this.components);
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panelSingleRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1019, 47);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(235, 57);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.toolTip1.SetToolTip(this.btnLogout, "Log out");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(620, 4);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(143, 60);
            this.btnCreateRoom.TabIndex = 25;
            this.btnCreateRoom.Text = "+";
            this.toolTip1.SetToolTip(this.btnCreateRoom, "Create a new room (Ctrl + N)");
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(164, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 27);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstUsersOnline
            // 
            this.lstUsersOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUsersOnline.FormattingEnabled = true;
            this.lstUsersOnline.ItemHeight = 20;
            this.lstUsersOnline.Location = new System.Drawing.Point(83, 129);
            this.lstUsersOnline.Margin = new System.Windows.Forms.Padding(4);
            this.lstUsersOnline.Name = "lstUsersOnline";
            this.lstUsersOnline.Size = new System.Drawing.Size(328, 624);
            this.lstUsersOnline.TabIndex = 4;
            // 
            // timeCheckForUsers
            // 
            this.timeCheckForUsers.Interval = 1000;
            this.timeCheckForUsers.Tick += new System.EventHandler(this.timeCheckForUsers_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstRooms);
            this.panel1.Controls.Add(this.panelSingleRoom);
            this.panel1.Controls.Add(this.btnCreateRoom);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(481, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 640);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rooms Available";
            // 
            // lstRooms
            // 
            this.lstRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 20;
            this.lstRooms.Location = new System.Drawing.Point(17, 80);
            this.lstRooms.Margin = new System.Windows.Forms.Padding(4);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(313, 524);
            this.lstRooms.TabIndex = 10;
            this.lstRooms.Click += new System.EventHandler(this.lstRooms_Click);
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // panelSingleRoom
            // 
            this.panelSingleRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSingleRoom.AutoScroll = true;
            this.panelSingleRoom.Controls.Add(this.lblUnlock);
            this.panelSingleRoom.Controls.Add(this.lblLock);
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
            this.panelSingleRoom.Location = new System.Drawing.Point(340, 71);
            this.panelSingleRoom.Margin = new System.Windows.Forms.Padding(4);
            this.panelSingleRoom.Name = "panelSingleRoom";
            this.panelSingleRoom.Size = new System.Drawing.Size(422, 565);
            this.panelSingleRoom.TabIndex = 11;
            this.panelSingleRoom.Visible = false;
            // 
            // lblUnlock
            // 
            this.lblUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnlock.AutoSize = true;
            this.lblUnlock.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblUnlock.Location = new System.Drawing.Point(330, 454);
            this.lblUnlock.Name = "lblUnlock";
            this.lblUnlock.Size = new System.Drawing.Size(24, 20);
            this.lblUnlock.TabIndex = 23;
            this.lblUnlock.Text = "Ï";
            this.lblUnlock.Visible = false;
            // 
            // lblLock
            // 
            this.lblLock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLock.AutoSize = true;
            this.lblLock.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblLock.Location = new System.Drawing.Point(330, 454);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(24, 20);
            this.lblLock.TabIndex = 22;
            this.lblLock.Text = "Ð";
            this.lblLock.Visible = false;
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(86, 125);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ReadOnly = true;
            this.txtUsers.Size = new System.Drawing.Size(115, 27);
            this.txtUsers.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Users";
            // 
            // lstRoomUsers
            // 
            this.lstRoomUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRoomUsers.FormattingEnabled = true;
            this.lstRoomUsers.ItemHeight = 20;
            this.lstRoomUsers.Location = new System.Drawing.Point(20, 160);
            this.lstRoomUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lstRoomUsers.Name = "lstRoomUsers";
            this.lstRoomUsers.Size = new System.Drawing.Size(377, 124);
            this.lstRoomUsers.TabIndex = 18;
            this.lstRoomUsers.SelectedIndexChanged += new System.EventHandler(this.lstRoomUsers_SelectedIndexChanged);
            // 
            // chkPasswordProtected
            // 
            this.chkPasswordProtected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPasswordProtected.AutoSize = true;
            this.chkPasswordProtected.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPasswordProtected.Enabled = false;
            this.chkPasswordProtected.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkPasswordProtected.Location = new System.Drawing.Point(163, 452);
            this.chkPasswordProtected.Margin = new System.Windows.Forms.Padding(4);
            this.chkPasswordProtected.Name = "chkPasswordProtected";
            this.chkPasswordProtected.Size = new System.Drawing.Size(163, 25);
            this.chkPasswordProtected.TabIndex = 21;
            this.chkPasswordProtected.Text = "Password Protected";
            this.chkPasswordProtected.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoinRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJoinRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinRoom.Location = new System.Drawing.Point(20, 496);
            this.btnJoinRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(378, 60);
            this.btnJoinRoom.TabIndex = 24;
            this.btnJoinRoom.Text = "Join Room";
            this.btnJoinRoom.UseVisualStyleBackColor = true;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Owner:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(86, 34);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(312, 27);
            this.txtTitle.TabIndex = 13;
            // 
            // txtOwner
            // 
            this.txtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwner.Location = new System.Drawing.Point(86, 79);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(312, 27);
            this.txtOwner.TabIndex = 15;
            this.txtOwner.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(20, 316);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(377, 110);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(361, 392);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(377, 104);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // timeCheckForRooms
            // 
            this.timeCheckForRooms.Interval = 2000;
            this.timeCheckForRooms.Tick += new System.EventHandler(this.timeCheckForRooms_Tick);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(481, 26);
            this.txtToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(331, 27);
            this.txtToken.TabIndex = 6;
            this.txtToken.Text = "txtToken";
            this.txtToken.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(1019, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(236, 27);
            this.txtUsername.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 45);
            this.label7.TabIndex = 0;
            this.label7.Text = "jMessages";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Online Users";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 755);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 20);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MessengerClient.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.AutoSize = true;
            this.lnkSettings.Location = new System.Drawing.Point(3, 733);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(62, 20);
            this.lnkSettings.TabIndex = 28;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Settings";
            this.lnkSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSettings_LinkClicked);
            // 
            // Menu
            // 
            this.AcceptButton = this.btnJoinRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1267, 782);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUsersOnline);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "jMessages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSingleRoom.ResumeLayout(false);
            this.panelSingleRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblLock;
        private System.Windows.Forms.Label lblUnlock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkSettings;
    }
}