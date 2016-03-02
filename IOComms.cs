using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    class IOComms
    {
        public static void readSettings()
        {
            try
            {
                string[] s = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\settings.ini");
                SettingsForm.sMTPHost = s[0];
                SettingsForm.sMTPName = s[1];
                SettingsForm.sMTPPass = s[2];
                SettingsForm.sMTPPort = Int32.Parse(s[3]);
                SettingsForm.pOPHost = s[4];
                SettingsForm.pOPName = s[5];
                SettingsForm.pOPPass = s[6];
                SettingsForm.pOPPort = Int32.Parse(s[7]);
            }
            catch
            {
                MessageBox.Show("Couldn't load settings");
            }
        }
        public static void writeSettings()
        {
            try {
                //Console.WriteLine(Directory.GetCurrentDirectory()+@"\settings.ini");
                writeToFile(Directory.GetCurrentDirectory() + @"\settings.ini", String.Format(
@"{0}
{1}
{2}
{3}
{4}
{5}
{6}
{7}"
                , SettingsForm.sMTPHost, SettingsForm.sMTPName, SettingsForm.sMTPPass/*TODO: FIX PLAINTEXT PASS*/, SettingsForm.sMTPPort, SettingsForm.pOPHost, SettingsForm.pOPName, SettingsForm.pOPPass, SettingsForm.pOPPort));
                
            }
            
            catch { }
            }
        public static Message readMail()
        {
            return null;
        }
        public static void writeMail(Message m)
        {

        }
        private static void writeToFile(string path, string s)
        {
            try {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                File.WriteAllText(path, s);
            }
            catch
            {
                MessageBox.Show("Couldn't save settings");
            }
        }
    }
}
