using EasySave.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RemoteEasySave
{
    public class Client
    {
        public event EventHandler<List<BackupEnvironment.BackupEnvironmentState>> OnStateChange;
        private Socket socket;
        private EndPoint remoteEndPoint;
        private byte[] buffer = new byte[1024];
        private String bufferStr = String.Empty;
        public Client()
        {
            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress iPAddress = host.AddressList[0];
            remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        internal void Start()
        {
            socket.Connect(remoteEndPoint);
            socket.BeginReceive(buffer, 0, buffer.Length,0, Receive, new Object());
        }

        private void Receive(IAsyncResult ar)
        {
            int byteRead = socket.EndReceive(ar);
            bufferStr += Encoding.UTF8.GetString(buffer, 0, byteRead);

            String[] messages = bufferStr.Split("\n");
            bufferStr = messages[messages.Length - 1];
            System.Diagnostics.Debug.WriteLine(bufferStr);
            for (int i = 0; i < messages.Length - 1; i++)
                OnMessage(messages[i]);
            socket.BeginReceive(buffer, 0, buffer.Length, 0, Receive, new Object());
        }

        private void OnMessage(string msg)
        {
            OnStateChange(this,JsonConvert.DeserializeObject<List<BackupEnvironment.BackupEnvironmentState>>(msg));
        }

        public void PauseBackup(String Name)
        {
            socket.Send(Encoding.ASCII.GetBytes("{\"Type\":\"PAUSE_BACKUP\",\"BackupEnvName\":\"" + Name+"\"}" + "\n"));
        }

        public void ResumeBackup(String Name)
        {
            socket.Send(Encoding.ASCII.GetBytes("{\"Type\":\"RESUME_BACKUP\",\"BackupEnvName\":\"" + Name + "\"}" + "\n"));
        }

        public void CancelBackup(String Name)
        {
            socket.Send(Encoding.ASCII.GetBytes("{\"Type\":\"CANCEL_BACKUP\",\"BackupEnvName\":\"" + Name + "\"}" + "\n"));
        }

        public void RunFullBackup(String Name)
        {
            socket.Send(Encoding.ASCII.GetBytes("{\"Type\":\"RUN_FULL_BACKUP\",\"BackupEnvName\":\"" + Name + "\"}" + "\n"));
        }

        public void RunDiffBackup(String Name)
        {
            socket.Send(Encoding.ASCII.GetBytes("{\"Type\":\"RUN_DIFFERENTIAL_BACKUP\",\"BackupEnvName\":\"" + Name + "\"}" + "\n"));
        }
    }
}
