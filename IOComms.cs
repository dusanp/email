using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email
{
    class IOComms
    {
        public static void readSettings()
        {

        }
        public static void writeSettings(string SMTPhost, string POPhost, string SMTPname, string POPname, string SMTPpass, string POPpass, int SMTPport, int POPport)
        {

        }
        public static Message readMail()
        {
            return new Message("", "", "", "", "");
        }
        public static void writeMail(Message m)
        {

        }
    }
}
