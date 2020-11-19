namespace Minecraft_Server_Hub
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Server1 = new System.Windows.Forms.Panel();
            this.ServerStarting = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.Label();
            this.hubPanel = new System.Windows.Forms.Panel();
            this.newServer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedServerStatus = new System.Windows.Forms.Label();
            this.openport = new System.Windows.Forms.Button();
            this.stopServer = new System.Windows.Forms.Button();
            this.startserver = new System.Windows.Forms.Button();
            this.selectedServerName = new System.Windows.Forms.Label();
            this.newServerName = new System.Windows.Forms.TextBox();
            this.TitleBar.SuspendLayout();
            this.Server1.SuspendLayout();
            this.hubPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minecraft Server Hub";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Blue;
            this.TitleBar.Controls.Add(this.button1);
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Location = new System.Drawing.Point(-2, -2);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(969, 62);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Server1
            // 
            this.Server1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Server1.Controls.Add(this.ServerStarting);
            this.Server1.Controls.Add(this.ServerPort);
            this.Server1.Controls.Add(this.ServerName);
            this.Server1.Location = new System.Drawing.Point(951, 5);
            this.Server1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Server1.Name = "Server1";
            this.Server1.Size = new System.Drawing.Size(884, 91);
            this.Server1.TabIndex = 4;
            this.Server1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Server1_MouseClick);
            // 
            // ServerStarting
            // 
            this.ServerStarting.AutoSize = true;
            this.ServerStarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ServerStarting.ForeColor = System.Drawing.Color.White;
            this.ServerStarting.Location = new System.Drawing.Point(723, 48);
            this.ServerStarting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerStarting.Name = "ServerStarting";
            this.ServerStarting.Size = new System.Drawing.Size(63, 25);
            this.ServerStarting.TabIndex = 7;
            this.ServerStarting.Text = "active";
            this.ServerStarting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ServerPort.ForeColor = System.Drawing.Color.White;
            this.ServerPort.Location = new System.Drawing.Point(654, 18);
            this.ServerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(188, 25);
            this.ServerPort.TabIndex = 5;
            this.ServerPort.Text = "Runs on port: 25565";
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ServerName.ForeColor = System.Drawing.Color.White;
            this.ServerName.Location = new System.Drawing.Point(26, 18);
            this.ServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(195, 52);
            this.ServerName.TabIndex = 6;
            this.ServerName.Text = "The Boiz";
            // 
            // hubPanel
            // 
            this.hubPanel.AllowDrop = true;
            this.hubPanel.AutoScroll = true;
            this.hubPanel.Controls.Add(this.Server1);
            this.hubPanel.Location = new System.Drawing.Point(-2, 69);
            this.hubPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hubPanel.Name = "hubPanel";
            this.hubPanel.Size = new System.Drawing.Size(969, 678);
            this.hubPanel.TabIndex = 9;
            // 
            // newServer
            // 
            this.newServer.Location = new System.Drawing.Point(0, 154);
            this.newServer.Name = "newServer";
            this.newServer.Size = new System.Drawing.Size(108, 40);
            this.newServer.TabIndex = 5;
            this.newServer.Text = "New Server";
            this.newServer.UseVisualStyleBackColor = true;
            this.newServer.Click += new System.EventHandler(this.newServer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.newServerName);
            this.panel1.Controls.Add(this.newServer);
            this.panel1.Controls.Add(this.selectedServerStatus);
            this.panel1.Controls.Add(this.openport);
            this.panel1.Controls.Add(this.stopServer);
            this.panel1.Controls.Add(this.startserver);
            this.panel1.Controls.Add(this.selectedServerName);
            this.panel1.Location = new System.Drawing.Point(18, 757);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 194);
            this.panel1.TabIndex = 10;
            // 
            // selectedServerStatus
            // 
            this.selectedServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectedServerStatus.Location = new System.Drawing.Point(621, 5);
            this.selectedServerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedServerStatus.Name = "selectedServerStatus";
            this.selectedServerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedServerStatus.Size = new System.Drawing.Size(184, 35);
            this.selectedServerStatus.TabIndex = 4;
            this.selectedServerStatus.Text = "Port";
            this.selectedServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openport
            // 
            this.openport.Location = new System.Drawing.Point(814, 5);
            this.openport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(112, 35);
            this.openport.TabIndex = 3;
            this.openport.Text = "Open";
            this.openport.UseVisualStyleBackColor = true;
            // 
            // stopServer
            // 
            this.stopServer.Location = new System.Drawing.Point(814, 154);
            this.stopServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(112, 35);
            this.stopServer.TabIndex = 2;
            this.stopServer.Text = "Stop";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // startserver
            // 
            this.startserver.Location = new System.Drawing.Point(693, 154);
            this.startserver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startserver.Name = "startserver";
            this.startserver.Size = new System.Drawing.Size(112, 35);
            this.startserver.TabIndex = 1;
            this.startserver.Text = "Start";
            this.startserver.UseVisualStyleBackColor = true;
            this.startserver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startserver_Click);
            this.startserver.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startserver_MouseUp);
            // 
            // selectedServerName
            // 
            this.selectedServerName.AutoSize = true;
            this.selectedServerName.Location = new System.Drawing.Point(18, 20);
            this.selectedServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedServerName.Name = "selectedServerName";
            this.selectedServerName.Size = new System.Drawing.Size(51, 20);
            this.selectedServerName.TabIndex = 0;
            this.selectedServerName.Text = "Name";
            // 
            // newServerName
            // 
            this.newServerName.Location = new System.Drawing.Point(114, 163);
            this.newServerName.Name = "newServerName";
            this.newServerName.Size = new System.Drawing.Size(100, 26);
            this.newServerName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(968, 969);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.hubPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.Server1.ResumeLayout(false);
            this.Server1.PerformLayout();
            this.hubPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel Server1;
        private System.Windows.Forms.Label ServerStarting;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Panel hubPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openport;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Button startserver;
        private System.Windows.Forms.Label selectedServerName;
        private System.Windows.Forms.Label selectedServerStatus;
        private System.Windows.Forms.Button newServer;
        private System.Windows.Forms.TextBox newServerName;
    }
}

