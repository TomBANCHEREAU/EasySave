using EasySave.Models;
using System;
using System.Collections.Generic;
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
        public Server(IController controller,IReadOnlyModel model)
        {
            Controller = controller;
            Model = model;
        }
        public void Start()
        {
            server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            server.Bind(endPoint);
            server.BeginAccept(Accept, server);
        }

        private Socket server;
        private void Accept(IAsyncResult ar)
        {
            ;
            ClientStatus status = new ClientStatus(server.EndAccept(ar));
            status.Client.BeginReceive(status.Buffer, 0,status.Buffer.Length,0, Receive, status);
            server.BeginAccept(Accept, server);
        }

        private void Receive(IAsyncResult ar)
        {
            ClientStatus status = (ClientStatus)ar.AsyncState;
            int readLength = status.Client.EndReceive(ar);

            status.StrBuffer += Encoding.UTF8.GetString(status.Buffer,0,readLength);
            String[] messages = status.StrBuffer.Split("\n");
            foreach (String message in messages)
                if(messages[messages.Length - 1] != message)
                    ProcessMessage(status, message);
            status.StrBuffer = messages[messages.Length - 1];
            status.Client.BeginReceive(status.Buffer, 0, status.Buffer.Length, 0, Receive, status);
        }

        private void ProcessMessage(ClientStatus status, String message)
        {
            Command command = Newtonsoft.Json.JsonConvert.DeserializeObject<Command>(message);
            switch (command.type)
            {
                case CommandType.SUBSCRIBE_BACKUP:
                    break;
                case CommandType.UNSUBSCRIBE_BACKUP:
                    break;
                case CommandType.PAUSE_BACKUP:
                    break;
                case CommandType.RESUME_BACKUP:
                    break;
                case CommandType.GET_BACKUP_ENVIRONMENTS:
                    
                    break;
                default:
                    break;
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
            SUBSCRIBE_BACKUP,
            UNSUBSCRIBE_BACKUP,
            PAUSE_BACKUP,
            RESUME_BACKUP,
            GET_BACKUP_ENVIRONMENTS
        }
        public class Command
        {
            public readonly CommandType type;
            public int ID = 0;
            public String content;
        }
    }
}
