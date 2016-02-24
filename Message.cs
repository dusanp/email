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
        public Message(string s, string b, string r, string f, string t)
        {
            subject = s;
            body = b;
            recipient = r;
            sender = f;
            timestamp = t;
        }
    }
}
