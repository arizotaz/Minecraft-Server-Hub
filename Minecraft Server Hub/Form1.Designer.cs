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
            this.about = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.newServerDownloadSelect = new System.Windows.Forms.ComboBox();
            this.newServerMotd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newServerPort = new System.Windows.Forms.TextBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingPanelText = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.loadingPanel.SuspendLayout();
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
            this.TitleBar.Controls.Add(this.about);
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
            // about
            // 
            this.about.Location = new System.Drawing.Point(876, 11);
            this.about.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(33, 34);
            this.about.TabIndex = 3;
            this.about.Text = "?";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // hubPanel
            // 
            this.hubPanel.AllowDrop = true;
            this.hubPanel.AutoScroll = true;
            this.hubPanel.Location = new System.Drawing.Point(-2, 69);
            this.hubPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hubPanel.Name = "hubPanel";
            this.hubPanel.Size = new System.Drawing.Size(969, 678);
            this.hubPanel.TabIndex = 9;
            // 
            // newServer
            // 
            this.newServer.Location = new System.Drawing.Point(768, 188);
            this.newServer.Name = "newServer";
            this.newServer.Size = new System.Drawing.Size(160, 40);
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
            this.panel1.Location = new System.Drawing.Point(18, 757);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 194);
            this.panel1.TabIndex = 10;
            // 
            // deleteServer
            // 
            this.deleteServer.Location = new System.Drawing.Point(814, 109);
            this.deleteServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteServer.Name = "deleteServer";
            this.deleteServer.Size = new System.Drawing.Size(112, 35);
            this.deleteServer.TabIndex = 6;
            this.deleteServer.Text = "Delete";
            this.deleteServer.UseVisualStyleBackColor = true;
            this.deleteServer.Click += new System.EventHandler(this.deleteServer_Click);
            // 
            // openServerCreation
            // 
            this.openServerCreation.Location = new System.Drawing.Point(0, 157);
            this.openServerCreation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openServerCreation.Name = "openServerCreation";
            this.openServerCreation.Size = new System.Drawing.Size(192, 35);
            this.openServerCreation.TabIndex = 5;
            this.openServerCreation.Text = "Open Server Creation";
            this.openServerCreation.UseVisualStyleBackColor = true;
            this.openServerCreation.Click += new System.EventHandler(this.openServerCreation_Click);
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
            this.openport.Click += new System.EventHandler(this.openport_Click);
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
            this.newServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerName.Location = new System.Drawing.Point(22, 49);
            this.newServerName.Name = "newServerName";
            this.newServerName.Size = new System.Drawing.Size(212, 30);
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
            this.panel2.Location = new System.Drawing.Point(18, 982);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 231);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(519, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Server Version:";
            // 
            // newServerDownloadSelect
            // 
            this.newServerDownloadSelect.Location = new System.Drawing.Point(524, 49);
            this.newServerDownloadSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newServerDownloadSelect.Name = "newServerDownloadSelect";
            this.newServerDownloadSelect.Size = new System.Drawing.Size(226, 28);
            this.newServerDownloadSelect.TabIndex = 12;
            this.newServerDownloadSelect.Click += new System.EventHandler(this.serverDownloadSelect_Click);
            // 
            // newServerMotd
            // 
            this.newServerMotd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerMotd.Location = new System.Drawing.Point(22, 137);
            this.newServerMotd.Name = "newServerMotd";
            this.newServerMotd.Size = new System.Drawing.Size(460, 30);
            this.newServerMotd.TabIndex = 11;
            this.newServerMotd.Text = "A minecraft server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server Motd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(266, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server Port:";
            // 
            // newServerPort
            // 
            this.newServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newServerPort.Location = new System.Drawing.Point(270, 49);
            this.newServerPort.Name = "newServerPort";
            this.newServerPort.Size = new System.Drawing.Size(212, 30);
            this.newServerPort.TabIndex = 7;
            this.newServerPort.Text = "25565";
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.DimGray;
            this.loadingPanel.Controls.Add(this.loadingPanelText);
            this.loadingPanel.Location = new System.Drawing.Point(-2, -2);
            this.loadingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(15, 192);
            this.loadingPanel.TabIndex = 4;
            // 
            // loadingPanelText
            // 
            this.loadingPanelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingPanelText.AutoSize = true;
            this.loadingPanelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loadingPanelText.ForeColor = System.Drawing.Color.White;
            this.loadingPanelText.Location = new System.Drawing.Point(-444, -457);
            this.loadingPanelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingPanelText.Name = "loadingPanelText";
            this.loadingPanelText.Size = new System.Drawing.Size(162, 46);
            this.loadingPanelText.TabIndex = 0;
            this.loadingPanelText.Text = "Loading";
            this.loadingPanelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(968, 1231);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.panel2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
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
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label loadingPanelText;
    }
}

