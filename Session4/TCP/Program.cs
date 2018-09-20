using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TCP
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress(adr);
            TcpListener newsock = new TcpListener( ipAdr, 12345 );
            newsock.Start();
            Console.WriteLine("Waiting for a client...");
            
            while (true)
            {
                TcpClient client = newsock.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                
                void ProcessTaskThread()
                {
                    RunClient(ns);
                }
                new Thread(ProcessTaskThread).Start();
            }
            
        }
        
        public static void RunClient(NetworkStream client){
            Console.WriteLine($"Connected with client");
            while (true)
            {
                string msg = Console.ReadLine();
                var data = Encoding.ASCII.GetBytes(msg);
                client.Write(data, 0, data.Length);

                byte[] bytes = new byte[1024];  
                int bytesRead = client.Read(bytes, 0, bytes.Length);  

                Console.WriteLine(Encoding.ASCII.GetString(bytes,0,bytesRead));
            }
        }
    }
    
    
    
    
}