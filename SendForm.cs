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
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            NetComms.SendMail(new Message(subjectBox.Text, bodyBox.Text, rcptBox.Text, SettingsForm.SMTPname, DateTime.Now.ToString("F")));
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//dotstuffing
}
