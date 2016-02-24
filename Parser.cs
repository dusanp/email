using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return new Message("", s, "", "", "");
        }
        public static string[] splitToLines(string s)
        {
            return s.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        }
    }
}
