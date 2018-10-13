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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsers)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create A Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max Users";
            // 
            // chkPasswordProtected
            // 
            this.chkPasswordProtected.AutoSize = true;
            this.chkPasswordProtected.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPasswordProtected.Location = new System.Drawing.Point(230, 315);
            this.chkPasswordProtected.Name = "chkPasswordProtected";
            this.chkPasswordProtected.Size = new System.Drawing.Size(121, 17);
            this.chkPasswordProtected.TabIndex = 24;
            this.chkPasswordProtected.Text = "Password Protected";
            this.chkPasswordProtected.UseVisualStyleBackColor = true;
            this.chkPasswordProtected.CheckedChanged += new System.EventHandler(this.chkPasswordProtected_CheckedChanged);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(122, 451);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(333, 49);
            this.btnCreateRoom.TabIndex = 20;
            this.btnCreateRoom.Text = "Create and Join Room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(212, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(226, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(122, 199);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(333, 90);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.Text = "";
            // 
            // numMaxUsers
            // 
            this.numMaxUsers.Location = new System.Drawing.Point(212, 129);
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
            this.numMaxUsers.Size = new System.Drawing.Size(67, 20);
            this.numMaxUsers.TabIndex = 26;
            this.numMaxUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMaxUsers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(0, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 20);
            this.txtPassword.TabIndex = 27;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.AutoSize = true;
            this.chkViewPassword.Location = new System.Drawing.Point(122, 38);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(98, 17);
            this.chkViewPassword.TabIndex = 28;
            this.chkViewPassword.Text = "View Password";
            this.chkViewPassword.UseVisualStyleBackColor = true;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.chkViewPassword);
            this.panelPassword.Location = new System.Drawing.Point(122, 358);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(333, 67);
            this.panelPassword.TabIndex = 29;
            this.panelPassword.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Description";
            // 
            // CreateRoomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.numMaxUsers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPasswordProtected);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Name = "CreateRoomDialog";
            this.Text = "CreateRoomDialog";
            this.Load += new System.EventHandler(this.CreateRoomDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsers)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
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
    }
}