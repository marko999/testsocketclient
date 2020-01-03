using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace testsocketclient
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            do{
                Console.Write("Enter command, type 'q' to quit: ");
                input = Console.ReadLine();
                SynchronousSocketClient.StartClient(input);  
                
            }while(input != "q");
        }

       
    }
}
