using EasySave.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EasySave.Controllers
{
    class Server
    {
        public static readonly EndPoint endPoint = new IPEndPoint(IPAddress.Parse("0.0.0.0"),11000);
        public readonly IController Controller;
        public readonly IReadOnlyModel Model;
        private List<ClientStatus> clients = new List<ClientStatus>();
        public Server(IController controller,IReadOnlyModel model)
        {
            Controller = controller;
            Model = model;
        }
        public void Start()
        {
            server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            server.Bind(endPoint);
            server.Listen(10);
            server.BeginAccept(Accept, server);
            Model.OnEnvironmentStateChange += Model_OnEnvironmentStateChange;
        }

        private void Model_OnEnvironmentStateChange(object sender, IReadOnlyList<BackupEnvironment.BackupEnvironmentState> e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(e) + "\n");
            foreach (ClientStatus client in clients)
            {
                try
                {
                    client.Client.BeginSend(buffer, 0, buffer.Length, 0, (IAsyncResult ar) => {
                        client.Client.EndSend(ar);
                    }, new Object());
                }
                catch{}

            }
        }

        private Socket server;
        private void Accept(IAsyncResult ar)
        {
            ClientStatus status = new ClientStatus(server.EndAccept(ar));
            status.Client.BeginReceive(status.Buffer, 0,status.Buffer.Length,0, Receive, status);
            clients.Add(status);
            server.BeginAccept(Accept, server);
        }

        private void Receive(IAsyncResult ar)
        {
            ClientStatus status = (ClientStatus)ar.AsyncState;
            try
            {

                int readLength = status.Client.EndReceive(ar);

                status.StrBuffer += Encoding.UTF8.GetString(status.Buffer, 0, readLength);
                String[] messages = status.StrBuffer.Split("\n");
                foreach (String message in messages)
                    if (messages[messages.Length - 1] != message)
                        ProcessMessage(status, message);
                status.StrBuffer = messages[messages.Length - 1];
                status.Client.BeginReceive(status.Buffer, 0, status.Buffer.Length, 0, Receive, status);
            }
            catch
            {
                clients.Remove(status);
            }
        }

        private void ProcessMessage(ClientStatus status, String message)
        {
            Command command = Newtonsoft.Json.JsonConvert.DeserializeObject<Command>(message);
            foreach (BackupEnvironment backupEnvironment in Model.GetBackupEnvironments())
            {
                if (backupEnvironment.Name == command.BackupEnvName)
                {
                    switch (command.Type)
                    {
                        case CommandType.PAUSE_BACKUP:
                            Controller.PauseBackup(backupEnvironment.runningBackup); 
                            break;
                        case CommandType.RESUME_BACKUP:
                            Controller.ResumeBackup(backupEnvironment.runningBackup);
                            break;
                        case CommandType.CANCEL_BACKUP:
                            //Controller.ResumeBackup(backupEnvironment.runningBackup);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private class ClientStatus
        {
            internal readonly Socket Client;
            internal byte[] Buffer = new byte[1024];
            internal String StrBuffer = String.Empty;
            internal ClientStatus(Socket client)
            {
                this.Client = client;
            }
        }
        public enum CommandType
        {
            PAUSE_BACKUP,
            RESUME_BACKUP,
            CANCEL_BACKUP
        }
        public class Command
        {
            public readonly CommandType Type;
            public String BackupEnvName;
        }
    }
}
