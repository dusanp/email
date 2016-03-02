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
    public partial class ReadForm : Form
    {
        bool allowNav=false;
        public ReadForm(Message m)
        {
            
            InitializeComponent();
            allowNav = true;
            webBrowser1.DocumentText = m.body;
            allowNav = false;
            webBrowser1.Document.Encoding = "UTF-8";
            infoBox.Text = m.sender+": "+m.subject;
            //Console.WriteLine(m.body);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (!allowNav)
            {
                //TODO:sec vulnerability
                System.Diagnostics.Process.Start(SanitiseUri(e.Url.AbsoluteUri));
                e.Cancel = true;
            }
        }
        private static string SanitiseUri(string s)
        {
            //todo
            return s;
        }
    }
}
