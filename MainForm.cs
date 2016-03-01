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
    public partial class MainForm : Form
    {
        Dictionary<int,Message> d = new Dictionary<int, Message>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            d.Clear();
            listBox1.Items.Clear();
            Message[] incomingMail = NetComms.GetMail();
            Console.WriteLine("mail retrieved");
            if (incomingMail != null&&incomingMail.Length != 0)
            {
                foreach (Message m in incomingMail)
                {
                    d.Add(listBox1.Items.Count, m);
                    //listBox1.Items.Add(m.subject);
                    listBox1.Items.Add(m.body);
                }
            }

        }

        private void listBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Message m;
                d.TryGetValue(listBox1.SelectedIndex, out m);
                ReadForm readForm = new ReadForm(m);
                readForm.Show();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            SendForm sendForm = new SendForm();
            sendForm.Show();
        }
    }
}
