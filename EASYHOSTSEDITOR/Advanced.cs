using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Diagnostics;

namespace EASYHOSTSEDITOR
{
    public partial class Advanced : Form
    {

        public Advanced()
        {
            InitializeComponent();
        }

        private void m_new_Click(object sender, EventArgs e)
        {
            var newvalue = "# Copyright (c) 1993-2009 Microsoft Corp.\n#\n# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\n#\n# This file contains the mappings of IP addresses to host names. Each\n# entry should be kept on an individual line. The IP address should\n# be placed in the first column followed by the corresponding host name.\n# The IP address and the host name should be separated by at least one\n# space.\n#\n# Additionally, comments (such as these) may be inserted on individual\n# lines or following the machine name denoted by a '#' symbol.\n#\n# For example:\n#\n#      102.54.94.97     rhino.acme.com          # source server\n#       38.25.63.10     x.acme.com              # x client host\n\n# localhost name resolution is handled within DNS itself.\n#	127.0.0.1       localhost\n#	::1             localhost\n\n127.0.0.1       localhost\n";
            newvalue = newvalue.Replace("\n", System.Environment.NewLine);
            string newfile = newvalue;
            advanced_editor.Text = newfile;
        }

        private void m_write_Click(object sender, EventArgs e)
        {
            if (advanced_editor.Text != "")
            {
                StreamWriter file = new StreamWriter("hosts");
                var line = advanced_editor.Text;
                file.Write(line);
                file.Close();
                Program.MessageCenter("The hosts file has been saved to the program directory\nYou should press the red folder to return the hosts file back to its normal directory so your system can read it.");
                //MessageBox.Show("The hosts file has been saved to the program directory\nYou should press the red folder to return the hosts file back to its normal directory so your system can read it.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Saving the hosts file as empty is not possible\nIf you want you can create a new hosts file then press the green folder and try this action again.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void m_read_Click(object sender, EventArgs e)
        {
            if (File.Exists("hosts"))
            {
                StreamReader bfile = new StreamReader("hosts");
                var bline = bfile.ReadLine();
                Console.WriteLine(bline);
                
                if (bline == "#Do Not Remove This Line")
                {
                    DialogResult dialogResult = MessageBox.Show("Warning this file was created using the basic editor please switch modes to basic\nIf you want to ignore this message and continue loading the file press yes otherwise you will be unable to load this file in the basic editor if you save it.", "System.IO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        readHostsFile();
                    }
                    //MessageBox.Show("Warning this file was created using the basic editor please switch modes to basic\nIf you want you can create a new hosts file then press the green folder and try this action again.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    readHostsFile();
                }
                bfile.Close();
            }
            else
            {
                Program.MessageCenter("The hosts file does not exist\n\nYou should press the 'Get Hosts File' button before using this action\nor you can press the 'New Hosts File' button then press the 'Write Hosts File' button and try this action again.");
                //MessageBox.Show("The hosts file does not exist\n\nYou should press the 'Get Hosts File' button before using this action\nor you can press the 'New Hosts File' button then press the 'Write Hosts File' button and try this action again.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void readHostsFile()
        {
            StreamReader file = new StreamReader("hosts");
            var line = file.ReadToEnd();
            advanced_editor.Text = line;
            file.Close();
        }

        private void m_get_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"C:\Windows\System32\drivers\etc\hosts"))
            {
                try
                {
                    File.Copy("C:/Windows/System32/drivers/etc/hosts", @"hosts", true);
                    if (File.Exists(@"hosts"))
                    {
                        Program.MessageCenter("The hosts file is ready for reading\nClick the yellow folder to read the hosts file.");
                        //MessageBox.Show("The hosts file is ready for reading\nClick the yellow folder to read the hosts file.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.IO.IOException)
                {
                    Program.MessageCenter("The hosts file does not exist in its proper directory\n\nYou should press the 'New Hosts File' button then press the 'Write Hosts File' button and then press 'Return Hosts File' button after that you should be able to get the hosts file from there by this action.");
                    //MessageBox.Show("The hosts file does not exist in its proper directory\n\nYou should press the 'New Hosts File' button then press the 'Write Hosts File' button and then press 'Return Hosts File' button after that you should be able to get the hosts file from there by this action.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void m_return_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"hosts"))
            {
                try
                {
                    File.Copy("hosts", @"C:\Windows\System32\drivers\etc\hosts", true);
                    Program.MessageCenter("The hosts file has been returned\nThe hosts file should be read by the system automatically.");
                    //MessageBox.Show("The hosts file has been returned\nThe hosts file should be read by the system automatically.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    try
                    {
                        File.Copy("hosts", @"hosts.bak");
                        File.Move("hosts", @"C:\Windows\System32\drivers\etc\");
                        File.Replace(@"hosts.bak", "hosts","hosts");
                        Program.MessageCenter("The hosts file has been returned\nThe hosts file should be read by the system automatically.");
                        //MessageBox.Show("The hosts file has been returned\nThe hosts file should be read by the system automatically.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        release();
                    }
                    catch
                    {
                        release();
                        Program.MessageCenter("Access Denied\nTry running this program as Administrator.");
                        //MessageBox.Show("Access Denied\nTry running this program as Administrator.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Program.MessageCenter("The hosts file does not exist\n\nYou should press the 'Get Hosts File' button before using this action\nor you can press the 'New Hosts File' button then press the 'Write Hosts File' button and try this action again.");
                //MessageBox.Show("The hosts file does not exist\n\nYou should press the 'Get Hosts File' button before using this action\nor you can press the 'New Hosts File' button then press the 'Write Hosts File' button and try this action again.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void release()
        {
            if (File.Exists(@"hosts.bak"))
            {
                File.Delete("hosts.bak");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Windows.basic.Show();
            this.Hide();
        }

        private void Advanced_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Windows.menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lookup form = new Lookup();
            form.Show();
        }

    }
}
