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
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJoinRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPasswordProtected = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timeCheckForRooms = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCreateRoom);
            this.panel1.Location = new System.Drawing.Point(361, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 525);
            this.panel1.TabIndex = 5;
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(13, 65);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(236, 446);
            this.lstRooms.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 257);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(292, 90);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.chkPasswordProtected);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnJoinRoom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(255, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 464);
            this.panel2.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(202, 20);
            this.txtTitle.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 108);
            this.listBox1.TabIndex = 13;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 16;
            // 
            // timeCheckForRooms
            // 
            this.timeCheckForRooms.Interval = 2000;
            this.timeCheckForRooms.Tick += new System.EventHandler(this.timeCheckForRooms_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 635);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkPasswordProtected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJoinRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timeCheckForRooms;
    }
}