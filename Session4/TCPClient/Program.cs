using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TcpClient client = new TcpClient("127.0.0.1", 12345);  
            NetworkStream ns = client.GetStream();
            Console.WriteLine("connected!");
            while (true)
            {
                byte[] bytes = new byte[1024];  
                int bytesRead = ns.Read(bytes, 0, bytes.Length);  

                Console.WriteLine(Encoding.ASCII.GetString(bytes,0,bytesRead));
                
                string msg = Console.ReadLine();
                var data = Encoding.ASCII.GetBytes(msg);
                ns.Write(data, 0, data.Length);
            }
        }
    }
}