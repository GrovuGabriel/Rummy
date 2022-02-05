using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace Rummy
{
    public class Retea
    {
        Conectare_Retea formRetea;
        bool sunthost;
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint EndPoint;
        Socket socket;
        //StreamWriter sw;
        //public string toatedatele;
        //string path;

        public Retea(bool h, Conectare_Retea r)
        {
            formRetea = r;
            sunthost = h;
            //toatedatele = "";
            //if (sunthost)
            //    path=@"C:\Users\Gabi\Desktop\HostLog.txt";
            //else
            //    path=@"C:\Users\Gabi\Desktop\ClientLog.txt";
        }

        public void conectare()
        {
            try
            {
                host = Dns.GetHostEntry("localhost");
                ipAddress = host.AddressList[0];
                EndPoint = new IPEndPoint(ipAddress, 11000);
                socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                if (sunthost)
                {
                    socket.Bind(EndPoint);
                    socket.Listen(1);
                    socket = socket.Accept();
                    formRetea.labelMesaje.Text = "Celalalt jucator s-a conectat, apasati pe butonul de mai jos pentru a incepe jocul";
                }
                else
                {
                    formRetea.labelMesaje.Text = "V-ati conectat la retea, asteptati ca Host-ul sa inceapa jocul";
                    socket.Connect(EndPoint);
                  

                }
            }
            catch (Exception e)
            {
                formRetea.labelMesaje.Text = e.ToString();
            }

        }
        public void inchideReteaua()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
        public void trimite(string s)
        {
            byte[] bytes = new byte[1024];
            byte[] msg = Encoding.ASCII.GetBytes(s);
            int bytesSent = socket.Send(msg);
            //string currentMethod = new StackFrame(1, true).GetMethod().Name;

            //toatedatele += "\n"+currentMethod + "\n";
        }

        public  string primeste()
        {
            byte[] bytes = new byte[1024];
            string data;
            bytes = new byte[1024];
            int bytesRec = socket.Receive(bytes);
            data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            //toatedatele += data + "\n";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine(toatedatele);
                
            //}
            

            return data;
        }


    }
}
