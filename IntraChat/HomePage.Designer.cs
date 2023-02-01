namespace IntraChat
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.YourBox = new System.Windows.Forms.GroupBox();
            this.YourPortNumberLabel = new System.Windows.Forms.Label();
            this.YourIpAdressLabel = new System.Windows.Forms.Label();
            this.YourPortTextBox = new System.Windows.Forms.TextBox();
            this.YourIpTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FriendsPortLabel = new System.Windows.Forms.Label();
            this.FriendsIpAddressLabel = new System.Windows.Forms.Label();
            this.FriendsPortTextBox = new System.Windows.Forms.TextBox();
            this.FriendsIpAddressTextBox = new System.Windows.Forms.TextBox();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YourBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YourBox
            // 
            this.YourBox.Controls.Add(this.YourPortNumberLabel);
            this.YourBox.Controls.Add(this.YourIpAdressLabel);
            this.YourBox.Controls.Add(this.YourPortTextBox);
            this.YourBox.Controls.Add(this.YourIpTextBox);
            this.YourBox.Location = new System.Drawing.Point(12, 27);
            this.YourBox.Name = "YourBox";
            this.YourBox.Size = new System.Drawing.Size(257, 103);
            this.YourBox.TabIndex = 0;
            this.YourBox.TabStop = false;
            this.YourBox.Text = "Your";
            // 
            // YourPortNumberLabel
            // 
            this.YourPortNumberLabel.AutoSize = true;
            this.YourPortNumberLabel.Location = new System.Drawing.Point(16, 63);
            this.YourPortNumberLabel.Name = "YourPortNumberLabel";
            this.YourPortNumberLabel.Size = new System.Drawing.Size(76, 15);
            this.YourPortNumberLabel.TabIndex = 4;
            this.YourPortNumberLabel.Text = "Port Number";
            // 
            // YourIpAdressLabel
            // 
            this.YourIpAdressLabel.AutoSize = true;
            this.YourIpAdressLabel.Location = new System.Drawing.Point(16, 28);
            this.YourIpAdressLabel.Name = "YourIpAdressLabel";
            this.YourIpAdressLabel.Size = new System.Drawing.Size(62, 15);
            this.YourIpAdressLabel.TabIndex = 3;
            this.YourIpAdressLabel.Text = "IP Address";
            // 
            // YourPortTextBox
            // 
            this.YourPortTextBox.Location = new System.Drawing.Point(106, 60);
            this.YourPortTextBox.Name = "YourPortTextBox";
            this.YourPortTextBox.Size = new System.Drawing.Size(132, 23);
            this.YourPortTextBox.TabIndex = 1;
            // 
            // YourIpTextBox
            // 
            this.YourIpTextBox.Location = new System.Drawing.Point(106, 25);
            this.YourIpTextBox.Name = "YourIpTextBox";
            this.YourIpTextBox.Size = new System.Drawing.Size(132, 23);
            this.YourIpTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FriendsPortLabel);
            this.groupBox2.Controls.Add(this.FriendsIpAddressLabel);
            this.groupBox2.Controls.Add(this.FriendsPortTextBox);
            this.groupBox2.Controls.Add(this.FriendsIpAddressTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend\'s";
            // 
            // FriendsPortLabel
            // 
            this.FriendsPortLabel.AutoSize = true;
            this.FriendsPortLabel.Location = new System.Drawing.Point(16, 67);
            this.FriendsPortLabel.Name = "FriendsPortLabel";
            this.FriendsPortLabel.Size = new System.Drawing.Size(76, 15);
            this.FriendsPortLabel.TabIndex = 4;
            this.FriendsPortLabel.Text = "Port Number";
            // 
            // FriendsIpAddressLabel
            // 
            this.FriendsIpAddressLabel.AutoSize = true;
            this.FriendsIpAddressLabel.Location = new System.Drawing.Point(16, 32);
            this.FriendsIpAddressLabel.Name = "FriendsIpAddressLabel";
            this.FriendsIpAddressLabel.Size = new System.Drawing.Size(62, 15);
            this.FriendsIpAddressLabel.TabIndex = 3;
            this.FriendsIpAddressLabel.Text = "IP Address";
            // 
            // FriendsPortTextBox
            // 
            this.FriendsPortTextBox.Location = new System.Drawing.Point(106, 64);
            this.FriendsPortTextBox.Name = "FriendsPortTextBox";
            this.FriendsPortTextBox.Size = new System.Drawing.Size(132, 23);
            this.FriendsPortTextBox.TabIndex = 1;
            // 
            // FriendsIpAddressTextBox
            // 
            this.FriendsIpAddressTextBox.Location = new System.Drawing.Point(106, 29);
            this.FriendsIpAddressTextBox.Name = "FriendsIpAddressTextBox";
            this.FriendsIpAddressTextBox.Size = new System.Drawing.Size(132, 23);
            this.FriendsIpAddressTextBox.TabIndex = 0;
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.HorizontalScrollbar = true;
            this.ChatBox.ItemHeight = 15;
            this.ChatBox.Location = new System.Drawing.Point(290, 35);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(488, 304);
            this.ChatBox.TabIndex = 2;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 357);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(672, 72);
            this.MessageTextBox.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(690, 374);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(88, 43);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(88, 255);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(100, 43);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(88, 304);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(100, 43);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.YourBox);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Intra Chat";
            this.YourBox.ResumeLayout(false);
            this.YourBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox YourBox;
        private TextBox YourPortTextBox;
        private TextBox YourIpTextBox;
        private GroupBox groupBox2;
        private TextBox FriendsPortTextBox;
        private TextBox FriendsIpAddressTextBox;
        private Label YourPortNumberLabel;
        private Label YourIpAdressLabel;
        private Label FriendsPortLabel;
        private Label FriendsIpAddressLabel;
        private ListBox ChatBox;
        private TextBox MessageTextBox;
        private Button Send;
        private Button Connect;
        private Button Disconnect;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}