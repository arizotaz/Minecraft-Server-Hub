using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Minecraft_Server_Hub
{
    public partial class Form1 : Form
    {
        string version = "0.1";
        bool fullyloaded = false;

        public int selectedServer = -1;
        public class Server
        {
            public string Path = "";
            public string Name = "";
            public string Dir = "";
            public string Port = "Obtaining Port";
            public string Moto = "";
            public string Status = "Offline";
            public Panel UIBackground = new Panel();
            public Label ServerName = new Label();
            public Label ServerPort = new Label();
            public Label ServerMoto = new Label();
            public Label ServerStatus = new Label();
        }

        public class ServerDownload {
            public string name;
            public string url;
        }

        string serversPath = "";

        private static Server[] serverList;

        private static ServerDownload[] downloadsList;

        Point mouseDownPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingPanel.Size = new Size(646, 810);
            loadingPanel.Location = new Point(0,0);
            loadingPanel.Show();
            //Debug.WriteLine(serverList[0].Name);
            Size = new Size(645, 630);
        }


        public void Render()
        {

            hubPanel.Controls.Clear();
            for (int i = 0; i < serverList.Length; i++)
            {
                serverList[i].UIBackground.Location = new Point(15, (i * 70));
                serverList[i].UIBackground.Name = i.ToString();
                serverList[i].UIBackground.Size = new Size(589, 59);
                serverList[i].UIBackground.BackColor = Color.FromArgb(128, 128, 255);
                serverList[i].UIBackground.Click += new EventHandler(Server1_MouseClick);

                serverList[i].ServerName.Location = new Point(17, 12);
                serverList[i].ServerName.Name = i.ToString();
                serverList[i].ServerName.Text = serverList[i].Name;
                serverList[i].ServerName.Font = new Font("Microsoft Sans Serif", 12);
                serverList[i].ServerName.ForeColor = Color.FromArgb(255, 255, 255);
                serverList[i].ServerName.Size = new Size(250, 20);
                serverList[i].ServerName.Click += new EventHandler(Server1_MouseClick);

                serverList[i].ServerMoto.Location = new Point(17, 30);
                serverList[i].ServerMoto.Name = i.ToString();
                serverList[i].ServerMoto.Text = serverList[i].Moto;
                serverList[i].ServerMoto.Font = new Font("Microsoft Sans Serif", 8);
                serverList[i].ServerMoto.ForeColor = Color.FromArgb(255, 255, 255);
                serverList[i].ServerMoto.Size = new Size(250, 20);
                serverList[i].ServerMoto.Click += new EventHandler(Server1_MouseClick);

                serverList[i].ServerPort.Location = new Point(436, 12);
                serverList[i].ServerPort.Name = i.ToString();
                serverList[i].ServerPort.Text = serverList[i].Port;
                serverList[i].ServerPort.Font = new Font("Microsoft Sans Serif", 10);
                serverList[i].ServerPort.ForeColor = Color.FromArgb(255, 255, 255);
                serverList[i].ServerPort.Size = new Size(138, 17);
                serverList[i].ServerPort.Click += new EventHandler(Server1_MouseClick);

                serverList[i].ServerStatus.Location = new Point(436, 31);
                serverList[i].ServerStatus.Name = i.ToString();
                serverList[i].ServerStatus.Text = serverList[i].Status;
                serverList[i].ServerStatus.Font = new Font("Microsoft Sans Serif", 10);
                serverList[i].ServerStatus.ForeColor = Color.FromArgb(255, 255, 255);
                serverList[i].ServerStatus.Size = new Size(138, 17);
                serverList[i].ServerStatus.Click += new EventHandler(Server1_MouseClick);

                serverList[i].UIBackground.Controls.Add(serverList[i].ServerName);
                serverList[i].UIBackground.Controls.Add(serverList[i].ServerPort);
                serverList[i].UIBackground.Controls.Add(serverList[i].ServerMoto);
                serverList[i].UIBackground.Controls.Add(serverList[i].ServerStatus);

                hubPanel.Controls.Add(serverList[i].UIBackground);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool startDrag = false;
        Point dragpos = Point.Empty;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!startDrag)
            {
                dragpos = new Point(e.X, e.Y);
                startDrag = !startDrag;
            }
        }


        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (startDrag)
            {
                startDrag = !startDrag;
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (startDrag)
            {
                Form f = this;
                f.Location = new Point(f.Location.X + (e.X - dragpos.X), f.Location.Y + (e.Y - dragpos.Y));
            }
        }
        private void Server1_MouseClick(object sender, EventArgs e)
        {
            var obj = sender as Panel;
            if (obj != null)
            {   
                try
                {
                    int port = int.Parse(serverList[int.Parse(obj.Name)].Port); //<--- This is your value
                    Debug.WriteLine(port);

                    selectServer(int.Parse(obj.Name));
                }
                catch
                {

                }
                return;
            }
            var objtext = sender as Label;
            if (objtext != null)
            {
                try
                {
                    int port = int.Parse(serverList[int.Parse(objtext.Name)].Port); //<--- This is your value
                    Debug.WriteLine(port);

                    selectServer(int.Parse(objtext.Name));
                }
                catch
                {
                    
                }
                return;
            }
        }
        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch (SocketException ex)
            {
                //MessageBox.Show("Error pinging host:'" + hostUri + ":" + portNumber.ToString() + "'");
                return false;
            }
        }
        public async Task<string> PingServer(string ip, int portNumber)
        {
            TcpClient tcpClient = new TcpClient();
            var tasks = tcpClient.ConnectAsync(ip, portNumber);
            await Task.WhenAll(tasks);

            return tasks.ToString();
        }
        string applicationData;
        private void Form1_Shown(object sender, EventArgs e)
        {
            applicationData = "Version-" + version + "~downloadURL-Download~ServersURL-https://www.dropbox.com/s/1sywitjwlq35gcf/minecraftServerHubDownloads.txt?dl=1";
            try
            {
                using (var wc = new WebClient())
                {
                    applicationData = wc.DownloadString("https://www.dropbox.com/s/7ezey8omqoabu6z/minecraftServerHubData.txt?dl=1");
                }
                if (version != applicationData.Split('~')[0].Split('-')[1])
                {
                    if (MessageBox.Show("A new version is avalible", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Process.Start(applicationData.Split('~')[1].Split('-')[1]);
                    }
                }
            }
            catch
            {

            }
            process();
            fullyloaded = true;
            string contents;
            using (var wc = new WebClient())
            {
                Debug.WriteLine(applicationData.Split('~')[2].Split('-')[1]);
                contents = wc.DownloadString(applicationData.Split('~')[2].Split('-')[1]);
            }
            downloadsList = new ServerDownload[contents.Split(',').Length];
            Debug.WriteLine(contents);
            for(int i = 0; i < contents.Split(',').Length; i++)
            {
                downloadsList[i] = new ServerDownload();
                downloadsList[i].name = contents.Split(',')[i].Split('=')[0];
                downloadsList[i].url = contents.Split(',')[i].Split('=')[1];
                newServerDownloadSelect.Items.Add(downloadsList[i].name);
                if (i == 0)
                {
                    newServerDownloadSelect.Text = downloadsList[i].name;
                }
            }
            loadingPanel.Hide();
        }
        public void process()
        {
            serversPath = Application.StartupPath + "/Servers";
            Console.WriteLine("loaded   - " + serversPath);

            Directory.CreateDirectory(serversPath);
            var directories = Directory.GetDirectories(serversPath);
            serverList = new Server[directories.Length];
            for (int i = 0; i < directories.Length; i++)
            {
                serverList[i] = new Server();
                serverList[i].Path = directories[i];
                serverList[i].Name = new DirectoryInfo(directories[i]).Name;
            }

            for (int i = 0; i < serverList.Length; i++)
            {
                Console.WriteLine("--------");
                Console.WriteLine(serverList[i].Name);
                Console.WriteLine(serverList[i].Path);
                Console.WriteLine("--------");
            }
            for (int i = 0; i < serverList.Length; i++)
            {
                if (File.Exists(serverList[i].Path + "/server.properties"))
                {
                    string[] lines = System.IO.File.ReadAllLines(serverList[i].Path + "/server.properties");
                    foreach (string line in lines)
                    {
                        //Debug.WriteLine(line);
                        if (line.Split('=')[0] == "server-port")
                        {
                            serverList[i].Port = line.Split('=')[1];
                        }
                        if (line.Split('=')[0] == "motd")
                        {
                            serverList[i].Moto = line.Split('=')[1];
                        }
                    }
                    int temp = int.Parse(serverList[i].Port);
                    int temp2 = i;
                    PingLoop(temp2, "localhost", temp);
                }
                else
                {
                    serverList[i].Port = "Failed";
                }
            }
            Render();
        }
        public async void PingLoop(int id, string ip, int port)
        {
            Task<string> ping = PingServer(ip, port);
            string result;
            try {
                result = await ping;
                serverList[id].Status = "Active";
                serverList[id].ServerStatus.Text = "Active";
                //MessageBox.Show("Found Server");
            }
            catch
            {
                //MessageBox.Show("Not Open");
            }

            //eventually want to loop here but for now just want to understand how this works
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (fullyloaded)
            {
                if (selectedServer != -1)
                {
                    try
                    {
                        PingSelectedServer(selectedServer, "localhost", int.Parse(serverList[selectedServer].Port));
                    }
                    catch
                    {

                    }
                }
                process(); 
            }
        }
        public void selectServer(int id)
        {
            selectedServer = id;
            selectedServerName.Text = serverList[selectedServer].Name;
            PingSelectedServer(selectedServer, "localhost", int.Parse(serverList[selectedServer].Port));
            //server
        }
        public async void PingSelectedServer(int id, string ip, int port)
        {
            Task<string> ping = PingServer(ip, port);
            string result;
            try
            {
                result = await ping;
                serverList[id].Status = "Active";
                serverList[id].ServerStatus.Text = "Active";
                selectedServerStatus.Text = "Port " + port + " is Active";
                //MessageBox.Show("Found Server");
            }
            catch
            {
                try
                {
                    serverList[id].Status = "Offline";
                    serverList[id].ServerStatus.Text = "Offline";
                }
                catch
                {

                }
                selectedServerStatus.Text = "Server Offline";
                //MessageBox.Show("Not Open");
            }

            //eventually want to loop here but for now just want to understand how this works
        }

        private void startserver_Click(object sender, MouseEventArgs e)
        {
            selectedServerStatus.Text = "Starting";

        }
        private void startserver_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(1000);
            if (PingHost("localhost", int.Parse(serverList[selectedServer].Port)))
            {
                //MessageBox.Show("Server port is taken.");
            }
            else
            {
                Directory.SetCurrentDirectory(serverList[selectedServer].Path);
                if (File.Exists(serverList[selectedServer].Path + "/server.jar"))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("CMD.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    startInfo.Arguments = "/C title " + serverList[selectedServer].Name + "&java -Xmx4G -Xms4G -jar \"" + serverList[selectedServer].Path + "/server.jar" + "\" nogui";
                    Process.Start(startInfo);
                }
                else
                {
                    if (File.Exists(serverList[selectedServer].Path + "/" + serverList[selectedServer].Name + ".lnk"))
                    {
                        Process.Start(serverList[selectedServer].Path + "/" + serverList[selectedServer].Name + ".lnk");
                    }
                    else
                    {
                        if (File.Exists(serverList[selectedServer].Path + "/" + serverList[selectedServer].Name + ".bat"))
                        {
                            Process.Start(serverList[selectedServer].Path + "/" + serverList[selectedServer].Name + ".bat");
                        }
                        else
                        {
                            if (File.Exists(serverList[selectedServer].Path + "/start - restart.bat"))
                            {
                                Process.Start(serverList[selectedServer].Path + "/start - restart.bat");
                            }
                            else
                            {
                                if (File.Exists(serverList[selectedServer].Path + "/start.bat"))
                                {
                                    Process.Start(serverList[selectedServer].Path + "/start.bat");
                                }
                                else
                                {
                                    selectedServerStatus.Text = "Failed";
                                    MessageBox.Show("Could not start server.");
                                }
                            }
                        }
                    }
                }
            }

            string path = serverList[selectedServer].Path;
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            Process[] localAll = Process.GetProcessesByName("cmd");
            foreach (Process pro in localAll)
            {
                if (pro.MainWindowTitle == serverList[selectedServer].Name)
                {
                    Debug.WriteLine("Close");
                    pro.CloseMainWindow();
                    try
                    {
                        pro.Close();
                    }
                    catch
                    {

                    }
                    try
                    {
                        pro.Kill();
                    }
                    catch
                    {

                    }
                }
            }
        }
        public string serverJarURL;
        private void newServer_Click(object sender, EventArgs e)
        {
            loadingPanelText.Text = "Creating Server";
            Size = new Size(645, 630);
            if (newServerName.Text == "")
            {
                loadingPanel.Hide();
                return;
            }
            string serverName = newServerName.Text;
            serversPath = Application.StartupPath + "/Servers/"+newServerName.Text;
            newServerName.Text = "";
            Directory.CreateDirectory(serversPath);
            Directory.GetDirectories(serversPath);
            Thread.Sleep(1000);
            if (File.Exists(serversPath + "/server.jar"))
            {
                MessageBox.Show("Sorry this server is already created.  You must delete it before you may continue.");
                loadingPanel.Hide();
                return;
            }
            Debug.WriteLine(newServerDownloadSelect.Text);
            for (int i = 0; i < downloadsList.Length; i++)
            {
                if (downloadsList[i].name == newServerDownloadSelect.Text)
                {
                    serverJarURL = downloadsList[i].url;
                    Debug.WriteLine(serverJarURL);
                }
            }
            loadingPanelText.Text = "Downloading Server Jar";
            using (var client = new WebClient())
            {
                client.DownloadFile(serverJarURL, serversPath+"/server.jar");
            }
            Directory.CreateDirectory(serversPath);

            Directory.SetCurrentDirectory(serversPath);

            loadingPanelText.Text = "Setting up Server";

            Process test;
            ProcessStartInfo startInfo = new ProcessStartInfo("CMD.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = "/C  java -Xmx4G -Xms4G -jar \""+ serversPath + "/server.jar" + "\" nogui & pause";
            test = Process.Start(startInfo);
            bool allowPass = false;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            while (allowPass == false) {
                if (File.Exists(serversPath + "/eula.txt"))
                {
                    allowPass = true;
                }
                if (sw.ElapsedMilliseconds > 12000)
                {
                    allowPass = true;
                }
                Thread.Sleep(10);
            }
            allowPass = false;
            sw.Restart();
            while (allowPass == false)
            {
                if (File.Exists(serversPath + "/server.properties"))
                {
                    allowPass = true;
                }
                if (sw.ElapsedMilliseconds > 12000)
                {
                    allowPass = true;
                }
                Thread.Sleep(10);
            }
            sw.Stop();
            test.Kill();

            string text;
            
            if (File.Exists(serversPath + "/eula.txt"))
            {
                text = File.ReadAllText(serversPath + "/eula.txt");
                text = text.Replace("false", "true");
                File.WriteAllText(serversPath + "/eula.txt", text);
            }

            text = File.ReadAllText(serversPath + "/server.properties");
            text = text.Replace("motd=A Minecraft Server", "motd=" + newServerMotd.Text);
            text = text.Replace("server-port=25565", "server-port=" + newServerPort.Text);
            text = text.Replace("enable-command-block=false", "enable-command-block=true");
            File.WriteAllText(serversPath + "/server.properties", text);

            loadingPanelText.Text = "Starting Server on port " + newServerPort.Text;

            startInfo = new ProcessStartInfo("CMD.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = "/C title "+serverName+" & java -Xmx4G -Xms4G -jar \"" + serversPath + "/server.jar" + "\" nogui";
            test = Process.Start(startInfo);

            loadingPanelText.Text = "Server Open";
            Thread.Sleep(1000);
            loadingPanel.Hide();
        }

        private void openServerCreation_Click(object sender, EventArgs e)
        {
            if (Size.Height > 630)
            {
                Size = new Size(645, 630);
                openServerCreation.Text = "Open Server Creation";
            }
            else
            {
                Size = new Size(645, 800);
                openServerCreation.Text = "Close Server Creation";
            }
        }

        private void deleteServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yes or no", "The Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Directory.Delete(serverList[selectedServer].Path, true);
                    process();
                }
            }
            catch
            {

            }
        }

        private void serverDownloadSelect_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Arizotaz\n\nVersion: " + version, "About", MessageBoxButtons.OK,MessageBoxIcon.None);
        }
    }
}
