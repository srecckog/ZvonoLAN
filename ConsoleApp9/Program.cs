
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write("Missing parameters :  <IP adresa> <command text> " );
                return;
            }
            
            Console.Write("IP adresa: " + args[0].ToString());
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
            ProtocolType.Udp);
            int hh = DateTime.Now.Hour;
            string text = "Open";
            IPAddress serverAddr = IPAddress.Parse(args[0]);
            if (args.Length==1)
            {
                text = "Open";
            }
            else
            {
                text = args[1].ToString();
            }
                        
            IPEndPoint endPoint = new IPEndPoint(serverAddr, 10111);
            //string text = "Open";
                        
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            Console.Write("Text:" + text);

            sock.SendTo(send_buffer, endPoint);
        }
                   
    }
}

