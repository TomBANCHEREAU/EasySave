using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RemoteEasySave
{
    class Client
    {
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress iPAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(iPAddress, 11000);

                Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}"), sender.RemoteEndPoint.ToString());

                    byte[] msg = Encoding.ASCII.GetBytes("this is a Test <EOF>");

                    int bytesSent = sender.Send(msg);

                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}"), Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
               
            }
        }
    }
}
