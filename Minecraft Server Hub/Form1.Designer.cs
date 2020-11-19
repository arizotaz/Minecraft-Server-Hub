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
            this.hubPanel = new System.Windows.Forms.Panel();
            this.newServer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteServer = new System.Windows.Forms.Button();
            this.openServerCreation = new System.Windows.Forms.Button();
            this.selectedServerStatus = new System.Windows.Forms.Label();
            this.openport = new System.Windows.Forms.Button();
            this.stopServer = new System.Windows.Forms.Button();
            this.startserver = new System.Windows.Forms.Button();
            this.selectedServerName = new System.Windows.Forms.Label();
            this.newServerName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newServerMotd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newServerPort = new System.Windows.Forms.TextBox();
            this.newServerDownloadSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
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
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minecraft Server Hub";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Blue;
            this.TitleBar.Controls.Add(this.button1);
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Location = new System.Drawing.Point(-1, -1);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(646, 40);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // hubPanel
            // 
            this.hubPanel.AllowDrop = true;
            this.hubPanel.AutoScroll = true;
            this.hubPanel.Location = new System.Drawing.Point(-1, 45);
            this.hubPanel.Name = "hubPanel";
            this.hubPanel.Size = new System.Drawing.Size(646, 441);
            this.hubPanel.TabIndex = 9;
            // 
            // newServer
            // 
            this.newServer.Location = new System.Drawing.Point(512, 122);
            this.newServer.Margin = new System.Windows.Forms.Padding(2);
            this.newServer.Name = "newServer";
            this.newServer.Size = new System.Drawing.Size(107, 26);
            this.newServer.TabIndex = 5;
            this.newServer.Text = "Create Server";
            this.newServer.UseVisualStyleBackColor = true;
            this.newServer.Click += new System.EventHandler(this.newServer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.deleteServer);
            this.panel1.Controls.Add(this.openServerCreation);
            this.panel1.Controls.Add(this.selectedServerStatus);
            this.panel1.Controls.Add(this.openport);
            this.panel1.Controls.Add(this.stopServer);
            this.panel1.Controls.Add(this.startserver);
            this.panel1.Controls.Add(this.selectedServerName);
            this.panel1.Location = new System.Drawing.Point(12, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 126);
            this.panel1.TabIndex = 10;
            // 
            // deleteServer
            // 
            this.deleteServer.Location = new System.Drawing.Point(543, 71);
            this.deleteServer.Name = "deleteServer";
            this.deleteServer.Size = new System.Drawing.Size(75, 23);
            this.deleteServer.TabIndex = 6;
            this.deleteServer.Text = "Delete";
            this.deleteServer.UseVisualStyleBackColor = true;
            this.deleteServer.Click += new System.EventHandler(this.deleteServer_Click);
            // 
            // openServerCreation
            // 
            this.openServerCreation.Location = new System.Drawing.Point(0, 102);
            this.openServerCreation.Name = "openServerCreation";
            this.openServerCreation.Size = new System.Drawing.Size(128, 23);
            this.openServerCreation.TabIndex = 5;
            this.openServerCreation.Text = "Open Server Creation";
            this.openServerCreation.UseVisualStyleBackColor = true;
            this.openServerCreation.Click += new System.EventHandler(this.openServerCreation_Click);
            // 
            // selectedServerStatus
            // 
            this.selectedServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectedServerStatus.Location = new System.Drawing.Point(414, 3);
            this.selectedServerStatus.Name = "selectedServerStatus";
            this.selectedServerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedServerStatus.Size = new System.Drawing.Size(123, 23);
            this.selectedServerStatus.TabIndex = 4;
            this.selectedServerStatus.Text = "Port";
            this.selectedServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openport
            // 
            this.openport.Location = new System.Drawing.Point(543, 3);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(75, 23);
            this.openport.TabIndex = 3;
            this.openport.Text = "Open";
            this.openport.UseVisualStyleBackColor = true;
            // 
            // stopServer
            // 
            this.stopServer.Location = new System.Drawing.Point(543, 100);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(75, 23);
            this.stopServer.TabIndex = 2;
            this.stopServer.Text = "Stop";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // startserver
            // 
            this.startserver.Location = new System.Drawing.Point(462, 100);
            this.startserver.Name = "startserver";
            this.startserver.Size = new System.Drawing.Size(75, 23);
            this.startserver.TabIndex = 1;
            this.startserver.Text = "Start";
            this.startserver.UseVisualStyleBackColor = true;
            this.startserver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startserver_Click);
            this.startserver.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startserver_MouseUp);
            // 
            // selectedServerName
            // 
            this.selectedServerName.AutoSize = true;
            this.selectedServerName.Location = new System.Drawing.Point(12, 13);
            this.selectedServerName.Name = "selectedServerName";
            this.selectedServerName.Size = new System.Drawing.Size(35, 13);
            this.selectedServerName.TabIndex = 0;
            this.selectedServerName.Text = "Name";
            // 
            // newServerName
            // 
            this.newServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerName.Location = new System.Drawing.Point(15, 32);
            this.newServerName.Margin = new System.Windows.Forms.Padding(2);
            this.newServerName.Name = "newServerName";
            this.newServerName.Size = new System.Drawing.Size(143, 23);
            this.newServerName.TabIndex = 6;
            this.newServerName.Text = "My Server";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.newServerDownloadSelect);
            this.panel2.Controls.Add(this.newServerMotd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.newServer);
            this.panel2.Controls.Add(this.newServerPort);
            this.panel2.Controls.Add(this.newServerName);
            this.panel2.Location = new System.Drawing.Point(12, 638);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 150);
            this.panel2.TabIndex = 11;
            // 
            // newServerMotd
            // 
            this.newServerMotd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerMotd.Location = new System.Drawing.Point(15, 89);
            this.newServerMotd.Margin = new System.Windows.Forms.Padding(2);
            this.newServerMotd.Name = "newServerMotd";
            this.newServerMotd.Size = new System.Drawing.Size(308, 23);
            this.newServerMotd.TabIndex = 11;
            this.newServerMotd.Text = "A minecraft server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server Motd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(177, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server Port:";
            // 
            // newServerPort
            // 
            this.newServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerPort.Location = new System.Drawing.Point(180, 32);
            this.newServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.newServerPort.Name = "newServerPort";
            this.newServerPort.Size = new System.Drawing.Size(143, 23);
            this.newServerPort.TabIndex = 7;
            this.newServerPort.Text = "25565";
            // 
            // newServerDownloadSelect
            // 
            this.newServerDownloadSelect.Location = new System.Drawing.Point(349, 32);
            this.newServerDownloadSelect.Name = "newServerDownloadSelect";
            this.newServerDownloadSelect.Size = new System.Drawing.Size(152, 21);
            this.newServerDownloadSelect.TabIndex = 12;
            this.newServerDownloadSelect.Click += new System.EventHandler(this.serverDownloadSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(346, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Server Version:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(645, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.hubPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel hubPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openport;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Button startserver;
        private System.Windows.Forms.Label selectedServerName;
        private System.Windows.Forms.Label selectedServerStatus;
        private System.Windows.Forms.Button newServer;
        private System.Windows.Forms.TextBox newServerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox newServerPort;
        private System.Windows.Forms.Button openServerCreation;
        private System.Windows.Forms.TextBox newServerMotd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteServer;
        private System.Windows.Forms.ComboBox newServerDownloadSelect;
        private System.Windows.Forms.Label label5;
    }
}

