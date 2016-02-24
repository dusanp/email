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
        public static string SMTPhost, POPhost, SMTPname, POPname, SMTPpass, POPpass;
        public static int SMTPport, POPport; 
        public SettingsForm()
        {
            InitializeComponent();
        }
    }
}
