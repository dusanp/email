using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email
{
    public class Message
    {
        public string subject, body, recipient, sender, timestamp;
        public Encoding encoding;
        public Message(string s, string b, string r, string f, string t)
        {
            subject = s;
            body = b;
            recipient = r;
            sender = f;
            timestamp = t;
            encoding = Encoding.UTF8;
        }
        //public void unDotStuff()
        //{
        //    this.body = Parser.unDotstuff(this.body);
        //}
    }
}
