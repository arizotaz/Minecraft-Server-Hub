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

        string serversPath = "";

        private static Server[] serverList;

        Point mouseDownPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine(serverList[0].Name);
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
                int port = int.Parse(serverList[int.Parse(obj.Name)].Port); //<--- This is your value
                Debug.WriteLine(port);

                selectServer(int.Parse(obj.Name));
                return;
            }
            var objtext = sender as Label;
            if (objtext != null)
            {
                int port = int.Parse(serverList[int.Parse(objtext.Name)].Port); //<--- This is your value
                Debug.WriteLine(port);

                selectServer(int.Parse(objtext.Name));
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
        private void Form1_Shown(object sender, EventArgs e)
        {
            process();
            fullyloaded = true;
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
                    PingSelectedServer(selectedServer, "localhost", int.Parse(serverList[selectedServer].Port));
                    process();
                }
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
                serverList[id].Status = "Offline";
                serverList[id].ServerStatus.Text = "Offline";
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

        private void newServer_Click(object sender, EventArgs e)
        {
            if (newServerName.Text == "")
            {
                return;
            }
            serversPath = Application.StartupPath + "/Servers/"+newServerName.Text;
            newServerName.Text = "";
            Directory.CreateDirectory(serversPath);
            Directory.GetDirectories(serversPath);
            Thread.Sleep(1000);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://launcher.mojang.com/v1/objects/35139deedbd5182953cf1caa23835da59ca3d7cd/server.jar", serversPath+"/server.jar");
            }
            Directory.CreateDirectory(serversPath);

            Directory.SetCurrentDirectory(serversPath);

            string strCmdText = "/C  java -Xmx4G -Xms4G -jar \""+ serversPath + "/server.jar" + "\" nogui & pause";
            Process.Start("CMD.exe", strCmdText);

            while(!File.Exists(serversPath + "/eula.txt")) {
                Thread.Sleep(100);
            }

            string text = File.ReadAllText(serversPath+"/eula.txt");
            text = text.Replace("false", "true");
            File.WriteAllText(serversPath + "/eula.txt", text);
        }
    }
}
