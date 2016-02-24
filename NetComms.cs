using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace email
{
    class NetComms
    {
        static byte[] data;
        static TcpClient tcpClient;
        static NetworkStream stream;
        public static Message[] GetMail()
        {
            Connect("pop3.seznam.cz", 110);
            //Connect("localhost", 110);
            Console.WriteLine(Receive().Substring(0, 3));
            Send("USER tset12@seznam.cz\n");
            Console.WriteLine(Receive().Substring(0, 3));
            Send("PASS tset12tset12\n");
            Console.WriteLine(Receive().Substring(0, 3));
            Send("STAT\n");
            //TODO error handling BAD BAD BAD
            int mLength = Int32.Parse("" + Receive()[4]);
            Message[] m = new Message[mLength];
            for (int x = mLength; x > 0; x--)
            {
                Send("RETR " + x + "\n");
                bool loopTester = true; 
                string receivedMsg="";
                do
                {
                    string currentReception = Receive();
                    receivedMsg = receivedMsg + currentReception;
                    string[] s = Parser.splitToLines(currentReception);
                    foreach (string S in s)
                    {
                        if (S == ".")
                        {
                            loopTester = false;
                        }
                        else
                        {
                            
                        }
                    }
                }
                while (loopTester);
                Console.WriteLine(receivedMsg);
                m[x - 1] = Parser.parse(receivedMsg);
            }
            Send("QUIT\n");
            return m;

        }
        public static void SendMail(Message m)
        {
            Connect("smtp.seznam.cz", 25);
            Console.WriteLine(Receive()[0]);
            Send("HELO seznam.cz");
            Console.WriteLine(Receive()[0]);
            Send("MAIL FROM:tset12@seznam.cz");
            Console.WriteLine(Receive()[0]);
            Send("RCPT TO:tset@seznam.cz");
            Console.WriteLine(Receive()[0]);
            Send("DATA");
            Console.WriteLine(Receive()[0]);//354
            Send(String.Format("From: {0}\nTo: {1}\nDate: {2}\nSubject: {3}\n\n{4}\n.",m.sender,m.recipient,m.timestamp,m.subject,m.body));
            Console.WriteLine(Receive()[0]);
            Send("QUIT");
            Console.WriteLine(Receive()[0]);

        }
        static void Connect(string h,int p)
        {
            try
            {
                tcpClient = new TcpClient(h,p);
                stream = tcpClient.GetStream();
            }
            catch (SocketException)
            {
                MessageBox.Show(String.Format("Couldnt connect to {0} at port {1}.", h,p));
            }
        }
        static string Receive()
        {
            data = new Byte[48];
            String responseData = String.Empty;
            int bytes = 0;
            bytes = stream.Read(data, 0 , data.Length);
            //Console.WriteLine(bytes);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            /*Console.WriteLine("#DUMP");
            foreach (byte b in data)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("#DUMPEND");*/
            return responseData;
        }
        static void Send(string s)
        {
            data = System.Text.Encoding.ASCII.GetBytes(s);
            stream.Write(data, 0, data.Length);
            Console.WriteLine(s);
        }
    }
}
