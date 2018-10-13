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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstUsersOnline = new System.Windows.Forms.ListBox();
            this.timeCheckForUsers = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(828, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 58);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(383, 537);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(247, 49);
            this.btnCreateRoom.TabIndex = 1;
            this.btnCreateRoom.Text = "Logout";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lstUsersOnline
            // 
            this.lstUsersOnline.FormattingEnabled = true;
            this.lstUsersOnline.Location = new System.Drawing.Point(383, 109);
            this.lstUsersOnline.Name = "lstUsersOnline";
            this.lstUsersOnline.Size = new System.Drawing.Size(247, 381);
            this.lstUsersOnline.TabIndex = 3;
            // 
            // timeCheckForUsers
            // 
            this.timeCheckForUsers.Interval = 1000;
            this.timeCheckForUsers.Tick += new System.EventHandler(this.timeCheckForUsers_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 642);
            this.Controls.Add(this.lstUsersOnline);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.btnLogout);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstUsersOnline;
        private System.Windows.Forms.Timer timeCheckForUsers;
    }
}