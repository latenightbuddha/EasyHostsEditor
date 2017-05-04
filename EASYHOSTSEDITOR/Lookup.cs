using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace EASYHOSTSEDITOR
{
    public partial class Lookup : Form
    {
        public Lookup()
        {
            InitializeComponent();
            //try{Process.GetCurrentProcess().Kill();}catch (SystemException){} //close application on load     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{IPHostEntry host;host = Dns.GetHostEntry(textBox1.Text);foreach (IPAddress ip in host.AddressList){textBox2.Text = ip.ToString();}}catch (Exception) { textBox2.Text = "Invalid or Unknown Hostname"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://" + textBox2.Text);
            }
            catch //(Exception)
            {
                //textBox2.Text = textBox2.Text + System.Environment.NewLine + "Error cant open webpage as is try clicking IPV6";
                Program.MessageCenter("Error cant open webpage as is try clicking IPV6");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://[" + textBox2.Text + "]");
            }
            catch //(Exception)
            {
                //textBox2.Text = textBox2.Text + System.Environment.NewLine + "Error cant open webpage as is try clicking IPV4";
                Program.MessageCenter("Error cant open webpage as is try clicking IPV4");
            }
        }

        private void Lookup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            if(Program.commandPassed)
            {
                Process.GetCurrentProcess().Kill();
            }
            //Windows.menu.Show();
        }
    }
}
