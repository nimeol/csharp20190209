using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

class clientHadler
{
    Socket socket = null;
    NetworkStream stream = null;
    StreamReader reader = null;
    StreamWriter writer = null;

    public clientHadler(Socket socket)
    {
        this.socket = socket;
    }
    public void chat()
    {
        stream = new NetworkStream(socket);
        Encoding encode = Encoding.GetEncoding("utf-8");

        reader = new StreamReader(stream, encode);
        writer = new StreamWriter(stream, encode) { AutoFlush = true };

        while(true)
        {
            string str = reader.ReadLine();
            Console.WriteLine(str);

            writer.WriteLine(str);
        }
    }
}

class Server
{
    public static void Main()
    {
        TcpListener tcpListener = null;
        Socket clientsocket = null;

        try
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(ipAd, 5001);
            tcpListener.Start();
            while(true)
            {
                clientsocket = tcpListener.AcceptSocket();
                clientHadler CHandler = new clientHadler(clientsocket);
                Thread t = new Thread(new ThreadStart(CHandler.chat));
                t.Start();
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            clientsocket.Close();
        }
    }
}




/* 단일 socket
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");//자기 컴퓨터
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();
                clientsocket = tcpListener.AcceptSocket(); //클라이언트가 올때까지 기다림
                stream = new NetworkStream(clientsocket);

                Encoding encode = Encoding.GetEncoding("utf-8");
                reader = new StreamReader(stream, encode);//라인으로 처리
                writer = new StreamWriter(stream, encode) { AutoFlush = true };
                while(true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);
                    writer.WriteLine(str);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
*/