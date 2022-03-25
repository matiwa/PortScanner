using System;
using System.Net.Sockets;

namespace PortScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PortScanner";
            short[] ListaPortow = { 20, 21, 22, 23, 25, 53, 70, 80, 109, 110, 119, 143, 161, 162, 443, 3389 };
            Console.WriteLine("Enter the host:");
            string host = Console.ReadLine();
            Console.WriteLine("\r\nPort scanning for {0}", host);
            Console.WriteLine("This may take a while ...\r\n");
            foreach(short port in ListaPortow)
            {
                try
                {
                    TcpClient klient = new TcpClient(host, port);
                    Console.WriteLine("Port: {0} is opened.",port);
                }
                catch
                {
                    Console.WriteLine("Port: {0} is not opened.", port);
                }
            }
            Console.ReadKey();
        }
    }
}
