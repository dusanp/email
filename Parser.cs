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
        public static Message dotstuff(Message m)
        {
            return m;
        }
        public static Message unDotstuff(Message m)
        {
            return m;
        }
        public delegate void Del(string s, Message m);
        public static Message Parse(string s)
        {
            Del subjectHandler = assignSubject;
            Del senderHandler = assignSender;
            Del recipientHandler = assignRecipent;
            Del dateHandler = assignDate;
            Del contentTypeHandler = assignContentType;

            Dictionary<string, Delegate> d = new Dictionary<string, Delegate>();
            d.Add("Date:", dateHandler);
            //d.Add("Content-Transfer-Encoding:", cteHandler);
            d.Add("Subject:", subjectHandler);
            d.Add("From:", senderHandler);
            d.Add("To:", recipientHandler);
            d.Add("Content-Type:", contentTypeHandler);
            string[] preParse = s.Split(new[] { "\r\n\r\n", "\r\r", "\n\n" }, StringSplitOptions.None);
            Message m = new Message("", DecodeQuotedPrintable(s), "", "", "");
            foreach (string headerCheck in splitToLines(preParse[0]))
            {
                Console.WriteLine(headerCheck);
                foreach (KeyValuePair<string, Delegate> k in d)
                {
                    if (headerCheck.StartsWith(k.Key))
                    {
                        k.Value.DynamicInvoke(headerCheck.Substring(k.Key.Length), m);
                    }
                }
            }
            return m;
        }

        public static string DecodeQuotedPrintable(string input/*, encoding*/)
        {
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
                input = input.Replace(m.Value, Encoding.UTF8.GetString(bytes));
            }
            input = input.Replace("=\r\n", "\r\n");
            input = input.Replace("=\n", "\n");
            input = input.Replace("=\r", "\r");
  
            return input;
        }
        public static string ParsePlainText(string s)
        {
            s = s.Replace("\r\n", "<br>");
            s = s.Replace("\r", "<br>");
            s = s.Replace("\n", "<br>");
            return s;
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
            //todo
        }
        private static void assignDate(string s, Message m)
        {
            m.timestamp = s;
        }
        private static void assignCte(string s, Message m)
        {
            m.timestamp = s;
        }
        private static void assignContentType(string s, Message m)
        {
            m.timestamp = s;
        }
        public static string[] splitToLines(string s)
        {
            return s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        }
    }
}
