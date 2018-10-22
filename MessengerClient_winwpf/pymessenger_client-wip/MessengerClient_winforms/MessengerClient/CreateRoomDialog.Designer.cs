namespace MessengerClient
{
    partial class CreateRoomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoomDialog));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPasswordProtected = new System.Windows.Forms.CheckBox();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.numMaxUsers = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkViewPassword = new System.Windows.Forms.CheckBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.usrCtrlPasswordRevealBtn1 = new MessengerClient.usrCtrlPasswordRevealBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsers)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 62);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create A Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Max Users:";
            // 
            // chkPasswordProtected
            // 
            this.chkPasswordProtected.AutoSize = true;
            this.chkPasswordProtected.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPasswordProtected.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkPasswordProtected.Location = new System.Drawing.Point(307, 388);
            this.chkPasswordProtected.Margin = new System.Windows.Forms.Padding(4);
            this.chkPasswordProtected.Name = "chkPasswordProtected";
            this.chkPasswordProtected.Size = new System.Drawing.Size(163, 25);
            this.chkPasswordProtected.TabIndex = 7;
            this.chkPasswordProtected.Text = "Password Protected";
            this.chkPasswordProtected.UseVisualStyleBackColor = true;
            this.chkPasswordProtected.CheckedChanged += new System.EventHandler(this.chkPasswordProtected_CheckedChanged);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Enabled = false;
            this.btnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(163, 555);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(444, 60);
            this.btnCreateRoom.TabIndex = 10;
            this.btnCreateRoom.Text = "Create and Join Room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.AllowDrop = true;
            this.txtTitle.Location = new System.Drawing.Point(283, 86);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(320, 27);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.EnableAutoDragDrop = true;
            this.txtDescription.Location = new System.Drawing.Point(0, 0);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 106);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // numMaxUsers
            // 
            this.numMaxUsers.Location = new System.Drawing.Point(283, 159);
            this.numMaxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.numMaxUsers.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMaxUsers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMaxUsers.Name = "numMaxUsers";
            this.numMaxUsers.Size = new System.Drawing.Size(89, 27);
            this.numMaxUsers.TabIndex = 4;
            this.numMaxUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMaxUsers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(0, 4);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.AutoSize = true;
            this.chkViewPassword.Location = new System.Drawing.Point(163, 47);
            this.chkViewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(128, 24);
            this.chkViewPassword.TabIndex = 9;
            this.chkViewPassword.Text = "View Password";
            this.chkViewPassword.UseVisualStyleBackColor = true;
            this.chkViewPassword.Visible = false;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.elementHost1);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.chkViewPassword);
            this.panelPassword.Location = new System.Drawing.Point(163, 441);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(4);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(444, 82);
            this.panelPassword.TabIndex = 29;
            this.panelPassword.Visible = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(416, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(25, 27);
            this.elementHost1.TabIndex = 10;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.usrCtrlPasswordRevealBtn1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(162, 623);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(444, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Location = new System.Drawing.Point(162, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 108);
            this.panel1.TabIndex = 6;
            // 
            // CreateRoomDialog
            // 
            this.AcceptButton = this.btnCreateRoom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(756, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.numMaxUsers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPasswordProtected);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRoomDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Room";
            this.Load += new System.EventHandler(this.CreateRoomDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsers)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPasswordProtected;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numMaxUsers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkViewPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private usrCtrlPasswordRevealBtn usrCtrlPasswordRevealBtn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}