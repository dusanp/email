using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    public partial class SettingsForm : Form
    {
        private static int SMTPPort, POPPort;
        private static string SMTPHost, POPHost, SMTPName, POPName, SMTPPass, POPPass;
        #region GETSETTERS
        public static int sMTPPort
        {
            get
            {

                    if (SMTPPort != 0)
                    {
                        return SMTPPort;
                    }
                    else
                    {
                        MessageBox.Show("SMTP port value not valid");
                        return 25;
                    }

            }

            set { if (value != 0) { SMTPPort = value; } else { SMTPPort = 25; } }
        }
        public static int pOPPort
        {
            get
            {
                if (POPPort != 0)
                {
                    return POPPort;
                }
                else
                {
                    MessageBox.Show("POP port value not valid");
                    return 110;
                }
            }
            set { if (value != 0) { POPPort = value; } else { POPPort = 110; } }
        }
        public static string sMTPHost
        {
            get
            {
                if (SMTPHost != null && SMTPHost != "")
                {
                    return SMTPHost;
                }
                else
                {
                    MessageBox.Show("SMTP server address not set");
                    throw new Exception();
                }
            }
            set { SMTPHost = value; }
        }
        public static string pOPHost
        {
            get
            {
                if (POPHost != null && POPHost != "")
                {
                    return POPHost;
                }
                else
                {
                    MessageBox.Show("POP server address not set");
                    throw new Exception();
                }
            }
            set { POPHost = value; }
        }
        public static string sMTPName
        {
            get
            {
                if (SMTPName != null && SMTPName != "")
                {
                    return SMTPName;
                }
                else
                {
                    MessageBox.Show("SMTP username not set");
                    throw new Exception();
                }
            }
            set { SMTPName = value; }
        }
        public static string pOPName
        {
            get
            {
                if (POPName != null && POPName != "")
                {
                    return POPName;
                }
                else
                {
                    MessageBox.Show("POP username not set");
                    throw new Exception();
                }
            }
            set { POPName = value; }
        }
        public static string sMTPPass
        {
            get
            {
                if (SMTPPass != null)
                {
                    return SMTPPass;
                }
                else
                {
                    MessageBox.Show("SMTP password not set");
                    return "";
                }
            }
            set { SMTPPass = value; }
        }
        public static string pOPPass
        {
            get
            {
                if (POPPass != null)
                {
                    return POPPass;
                }
                else
                {
                    MessageBox.Show("POP password not set");
                    return "";
                }
            }
            set { POPPass = value; }
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveSettings()
        {
            SMTPHost = SMTPHostBox.Text;
            SMTPName = SMTPNameBox.Text;
            SMTPPass = SMTPPassBox.Text;
            POPHost = POPHostBox.Text;
            POPName = POPNameBox.Text;
            POPPass = POPPassBox.Text;

            try
            {
                SMTPPort = Int32.Parse(SMTPPortBox.Text);
                POPPort = Int32.Parse(POPPortBox.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Wrong Port Format");
            }

            IOComms.writeSettings();
        }
        private void RetrieveSettings()
        {
            try
            {
                //readfromfile
            }
            catch
            {

                SMTPHost = "";
                SMTPName = "";
                SMTPPass = "";
                POPHost = "";
                POPName = "";
                POPPass = "";
                SMTPPort = 25;
                POPPort = 110;
            }

            SMTPHostBox.Text = SMTPHost;
            SMTPNameBox.Text = SMTPName;
            SMTPPassBox.Text = SMTPPass;
            SMTPPortBox.Text = SMTPPort + "";
            POPHostBox.Text = POPHost;
            POPNameBox.Text = POPName;
            POPPassBox.Text = POPPass;
            POPPortBox.Text = POPPort + "";
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        public SettingsForm()
        {
            InitializeComponent();
            RetrieveSettings();

        }

    }
}
