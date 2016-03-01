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
        public ReadForm(Message m)
        {
            InitializeComponent();

            webBrowser1.DocumentText = m.body;
            webBrowser1.Document.Encoding = "UTF-8";
            textBox1.Text = m.subject;
            Console.WriteLine(m.body);
        }
    }
}
