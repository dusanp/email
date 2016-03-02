using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace email
{
    class Parser
    {
        private delegate void Del(string s, Message m);
        private delegate string Del2(string s, Message m);
        private static bool mimeHandled;
        public static Message Parse(string s)
        {
            Del subjectHandler = assignSubject;
            Del senderHandler = assignSender;
            Del recipientHandler = assignRecipent;
            Del dateHandler = assignDate;
            Del mimeHandler = assignMime;
            Del encodingHandler = assignEncoding;

            Dictionary<string, Delegate> d = new Dictionary<string, Delegate>();
            d.Add("Date: ", dateHandler);
            d.Add("Mime-Version: ", mimeHandler);//most parsing occurs therein
            d.Add("Subject: ", subjectHandler);
            d.Add("From: ", senderHandler);
            d.Add("To: ", recipientHandler);
            d.Add("charset=", encodingHandler);

            mimeHandled = false;
            Message m = new Message("", s, "", "", "");
            
            foreach (string headerCheck in splitToLines(returnHeader(s)))
            {
                //Console.WriteLine(headerCheck);
                foreach (KeyValuePair<string, Delegate> k in d)
                {
                    if (headerCheck.StartsWith(k.Key))
                    {
                        k.Value.DynamicInvoke(headerCheck.Substring(k.Key.Length), m);
                    }
                }
            }
            if (!mimeHandled) { ParsePlainText(m.body, m); } else { m.body = removeHeader(m.body); }
                Console.WriteLine("returning m");
            return m;
        }

        public static string DecodeQuotedPrintable(string input, Message message)
        {
            Console.WriteLine("decoding QP");
            string originalS = input;
            var occurences = new Regex(@"(=[0-9A-Z][0-9A-Z])+", RegexOptions.Multiline);
            var matches = occurences.Matches(input);
            foreach (Match m in matches)
            {
                byte[] bytes = new byte[m.Value.Length / 3];
                for (int i = 0; i < bytes.Length; i++)
                {
                    string hex = m.Value.Substring(i * 3 + 1, 2);
                    int iHex = Convert.ToInt32(hex, 16);
                    bytes[i] = Convert.ToByte(iHex);
                }
                input = input.Replace(m.Value, message.encoding.GetString(bytes));
            }
            input = input.Replace("=\r\n", "\r\n");
            input = input.Replace("=\n", "\n");
            input = input.Replace("=\r", "\r");
            return input;

            

        }
        public static string decodeBase64(string input, Message message)
        {
            try {
                Console.WriteLine("decoding B64");
                string originalS = input;
                input = message.encoding.GetString(Convert.FromBase64String(input));
                Console.WriteLine("finished decoding B64");
                return input;
            }
            catch { System.Windows.Forms.MessageBox.Show("problem decoding B64");return input; }
            
        }
        public static void ParsePlainText(string s, Message m)
        {
            
            string originalS = s;
            s = decodeTransferEncoding(s, m);
            Console.WriteLine("parsing plaintext");
            s = removeHeader(s);
            s = s.Replace(Environment.NewLine, "<br>");
            s = s.Replace("\r\n", "<br>");
            s = s.Replace("\r", "<br>");
            s = s.Replace("\n", "<br>");
            m.body = m.body.Replace(originalS, s);
        }
        public static void ParseHtmlText(string s, Message m)
        {
            
            string originalS = s;
            s = decodeTransferEncoding(s, m);

            Console.WriteLine("parsing HTML");
            s = removeHeader(s);
            m.body = m.body.Replace(originalS, s);
        }
        static string decodeTransferEncoding(string s, Message m)
        {
            Dictionary<string, Delegate> d = new Dictionary<string, Delegate>();
            Del2 quotedPrintableHandler = DecodeQuotedPrintable;
            Del2 base64Handler = decodeBase64;
            d.Add("base64", base64Handler);
            d.Add("quoted-printable", quotedPrintableHandler);

            string[] keywords = new string[] { "Content-Type: ", "\tcharset=", "Content-Transfer-Encoding: " };

            foreach (string headerCheck in splitToLines(returnHeader(s)))
            {
                foreach (string keyword in keywords)
                {
                    if (headerCheck.StartsWith(keyword))
                    {
                        Console.WriteLine(keyword + " noted in " + headerCheck);
                        foreach (KeyValuePair<string, Delegate> k in d)
                        {
                            if (headerCheck.Substring(keyword.Length) == k.Key)
                            {

                                return (string)k.Value.DynamicInvoke(s, m);
                            }
                            
                        }
                    }
                }
            }
            return s;
        }
        static void parseMultiMix(string s, Message m)
        {
            string[] postParse = null;
            string boundary=null;
            foreach (string headerCheck in splitToLines(returnHeader(s)))
            {
                if (headerCheck.StartsWith("\tboundary=\""))
                {
                    boundary = "--" + headerCheck.Substring("boundary=".Length + 2, headerCheck.Length - "boundary=\"".Length - 2);
                    postParse = s.Split(new[] { boundary },StringSplitOptions.None) ;
                    Console.WriteLine();
                }
            }
            try
            {
                m.body = m.body.Replace(boundary, "");
                for (int x = 1; x < postParse.Length; x++)
                {
                    //Console.WriteLine(postParse[x]);

                    assignMime("", m, postParse[x]);
                }
            }
            catch { }
        }
        private static string returnHeader(string s)
        {
            string[] preParse = s.Split(new[] { "\r\n\r\n", "\r\r", "\n\n" }, StringSplitOptions.None);
            return preParse[0];
        }
        private static string removeHeader(string s)
        {
            string[] preParse = s.Split(new[] { "\r\n\r\n", "\r\r", "\n\n", Environment.NewLine+Environment.NewLine }, StringSplitOptions.None);

            string returnString ="";
            for (int x=1; x<preParse.Length; x++)
            {
                returnString = returnString + preParse[x];
            }
            return returnString;
        }
        public static string[] splitToLines(string s)
        {
            return s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        }

        private static void assignMime(string s, Message m, string optionalMimeSubPart)//not using newer optional param support because delegates
        {
            mimeHandled = true;
            Dictionary<string, Delegate> d = new Dictionary<string, Delegate>();

            Del plainTextHandler = ParsePlainText;
            Del htmlHandler = ParseHtmlText;
            Del multiAltHandler = parseMultiMix;
            Del multiMixHandler = parseMultiMix;

            d.Add("multipart/alternative;", multiAltHandler);
            d.Add("multipart/mixed;", multiMixHandler);
            d.Add("text/plain;", plainTextHandler);
            d.Add("text/html;", htmlHandler);

          
            string[] keywords = new string[] { "Content-Type: ", "\tcharset=" };
            foreach (string headerCheck in splitToLines(returnHeader(optionalMimeSubPart)))
            {
                foreach (string keyword in keywords)
                {
                    if (headerCheck.StartsWith(keyword))
                    {
                        Console.WriteLine(keyword + " noted in " + headerCheck);
                        foreach (KeyValuePair<string, Delegate> k in d)
                        {
                            if (headerCheck.Substring(keyword.Length) == k.Key)
                            {
                                k.Value.DynamicInvoke(optionalMimeSubPart,m);
                            }
                        }
                    }
                }
            }

        }
        private static void assignSubject(string s, Message m)
        {
            m.subject = s;
        }
        private static void assignSender(string s, Message m)
        {
            m.sender = s;
        }
        private static void assignRecipent(string s, Message m)
        {
            m.recipient = s;
        }
        private static void assignMime(string s, Message m)
        {
            assignMime(s, m, m.body);
        }
        private static void assignDate(string s, Message m)
        {
            m.timestamp = s;
        }
        private static void assignEncoding(string s, Message m)
        {
            try
            {
                m.encoding = Encoding.GetEncoding(s);
            }
            catch { System.Windows.Forms.MessageBox.Show("problem getting encoding"); }
        }
        public static Message dotstuff(Message m)
        {
            return m;
        }
        public static Message unDotstuff(Message m)
        {
            return m;
        }

    }
}
