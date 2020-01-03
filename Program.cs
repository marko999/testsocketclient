using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace testsocketclient
{
    class Program
    {
        private const string IpString = "127.000.000.001";
        private const int Port = 8888;

        static void Main(string[] args)
        {
            Console.Title = "Socket Client";
            Console.Write("Enter the IP of the server: ");
        
            IPAddress clientIP = IPAddress.Parse(IpString);
            String message = String.Empty;

            while (true)
            {
                message = "alo pozega";

                IPEndPoint clientEP = new IPEndPoint(clientIP, Port);

                // Setup the socket
                Socket clientSock = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);

                // Attempt to establish a connection to the server
                Console.Write("Establishing connection to the server... ");
                try
                {
                    clientSock.Connect(clientEP);

                    // Send the message
                    clientSock.Send(Encoding.UTF8.GetBytes(message));
                    clientSock.Shutdown(SocketShutdown.Both);
                    clientSock.Close();
                    Console.Write("Message sent successfully.\n\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
