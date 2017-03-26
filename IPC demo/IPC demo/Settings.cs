using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPC_demo
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void IP_address_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PeerIP = IP_address.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CommsEnabled = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            IP_address.Text = Properties.Settings.Default.PeerIP;
            checkBox1.Checked = Properties.Settings.Default.CommsEnabled;
        }
    }
}
