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
        public static Message parse(string s)
        {
            //temp
            return new Message("", DecodeQuotedPrintable(s), "", "", "");
        }
        public static string[] splitToLines(string s)
        {
            return s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
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
            input = input.Replace("=\n", "\n");
            input = input.Replace("=\r", "\r");
            input = input.Replace("=\r\n", "\r\n");
            return input;
        }  
    }
}
