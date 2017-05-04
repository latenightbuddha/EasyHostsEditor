using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace EASYHOSTSEDITOR
{
    public partial class Basic : Form
    {
        public class tables
        {
            //set 1
            public string IP_1;
            public string DOMAIN_1;
            public bool USE_1;

            public string IP_2;
            public string DOMAIN_2;
            public bool USE_2;

            public string IP_3;
            public string DOMAIN_3;
            public bool USE_3;

            public string IP_4;
            public string DOMAIN_4;
            public bool USE_4;

            public string IP_5;
            public string DOMAIN_5;
            public bool USE_5;

            public string IP_6;
            public string DOMAIN_6;
            public bool USE_6;

            public string IP_7;
            public string DOMAIN_7;
            public bool USE_7;

            public string IP_8;
            public string DOMAIN_8;
            public bool USE_8;

            public string IP_9;
            public string DOMAIN_9;
            public bool USE_9;

            public string IP_10;
            public string DOMAIN_10;
            public bool USE_10;

            public string IP_11;
            public string DOMAIN_11;
            public bool USE_11;

            public string IP_12;
            public string DOMAIN_12;
            public bool USE_12;

            public string IP_13;
            public string DOMAIN_13;
            public bool USE_13;

            public string IP_14;
            public string DOMAIN_14;
            public bool USE_14;

            public string IP_15;
            public string DOMAIN_15;
            public bool USE_15;

            public string IP_16;
            public string DOMAIN_16;
            public bool USE_16;

            public string IP_17;
            public string DOMAIN_17;
            public bool USE_17;

            public string IP_18;
            public string DOMAIN_18;
            public bool USE_18;

            public string IP_19;
            public string DOMAIN_19;
            public bool USE_19;

            public string IP_20;
            public string DOMAIN_20;
            public bool USE_20;

            public string IP_21;
            public string DOMAIN_21;
            public bool USE_21;

            public string IP_22;
            public string DOMAIN_22;
            public bool USE_22;

            public string IP_23;
            public string DOMAIN_23;
            public bool USE_23;

            public string IP_24;
            public string DOMAIN_24;
            public bool USE_24;

            public string IP_25;
            public string DOMAIN_25;
            public bool USE_25;

            //set 2
            public string IP_101;
            public string DOMAIN_101;
            public bool USE_101;

            public string IP_102;
            public string DOMAIN_102;
            public bool USE_102;

            public string IP_103;
            public string DOMAIN_103;
            public bool USE_103;

            public string IP_104;
            public string DOMAIN_104;
            public bool USE_104;

            public string IP_105;
            public string DOMAIN_105;
            public bool USE_105;

            public string IP_106;
            public string DOMAIN_106;
            public bool USE_106;

            public string IP_107;
            public string DOMAIN_107;
            public bool USE_107;

            public string IP_108;
            public string DOMAIN_108;
            public bool USE_108;

            public string IP_109;
            public string DOMAIN_109;
            public bool USE_109;

            public string IP_110;
            public string DOMAIN_110;
            public bool USE_110;

            public string IP_111;
            public string DOMAIN_111;
            public bool USE_111;

            public string IP_112;
            public string DOMAIN_112;
            public bool USE_112;

            public string IP_113;
            public string DOMAIN_113;
            public bool USE_113;

            public string IP_114;
            public string DOMAIN_114;
            public bool USE_114;

            public string IP_115;
            public string DOMAIN_115;
            public bool USE_115;

            public string IP_116;
            public string DOMAIN_116;
            public bool USE_116;

            public string IP_117;
            public string DOMAIN_117;
            public bool USE_117;

            public string IP_118;
            public string DOMAIN_118;
            public bool USE_118;

            public string IP_119;
            public string DOMAIN_119;
            public bool USE_119;

            public string IP_120;
            public string DOMAIN_120;
            public bool USE_120;

            public string IP_121;
            public string DOMAIN_121;
            public bool USE_121;

            public string IP_122;
            public string DOMAIN_122;
            public bool USE_122;

            public string IP_123;
            public string DOMAIN_123;
            public bool USE_123;

            public string IP_124;
            public string DOMAIN_124;
            public bool USE_124;

            public string IP_125;
            public string DOMAIN_125;
            public bool USE_125;


        }
        public Basic()
        {
            InitializeComponent();
        }

        private void Basic_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Windows.menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windows.advanced.Show();
        }

        private void m_write_Click(object sender, EventArgs e)
        {
            writetables();
        }

        private void m_read_Click(object sender, EventArgs e)
        {
            loadtables();
        }

        private void m_new_Click(object sender, EventArgs e)
        {     
            if (File.Exists(filename.Text + ".xml"))
            {
                File.Delete(filename.Text + ".xml");
            }
            StreamWriter file = new StreamWriter(filename.Text + ".xml");
            var newtable = "<?xml version='1.0'?>"+ System.Environment.NewLine + "<tables xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>" + System.Environment.NewLine + "</tables>";
            file.Write(newtable);
            file.Close();
            loadtables();
        }
        private void writetables()
        {
            tables table = new tables();
            //set 1
            table.IP_1 = ip_1.Text;
            table.DOMAIN_1 = domain_1.Text;
            table.USE_1 = use_1.Checked;

            table.IP_2 = ip_2.Text;
            table.DOMAIN_2 = domain_2.Text;
            table.USE_2 = use_2.Checked;

            table.IP_3 = ip_3.Text;
            table.DOMAIN_3 = domain_3.Text;
            table.USE_3 = use_3.Checked;

            table.IP_4 = ip_4.Text;
            table.DOMAIN_4 = domain_4.Text;
            table.USE_4 = use_4.Checked;

            table.IP_5 = ip_5.Text;
            table.DOMAIN_5 = domain_5.Text;
            table.USE_5 = use_5.Checked;

            table.IP_6 = ip_6.Text;
            table.DOMAIN_6 = domain_6.Text;
            table.USE_6 = use_6.Checked;

            table.IP_7 = ip_7.Text;
            table.DOMAIN_7 = domain_7.Text;
            table.USE_7 = use_7.Checked;

            table.IP_8 = ip_8.Text;
            table.DOMAIN_8 = domain_8.Text;
            table.USE_8 = use_8.Checked;

            table.IP_9 = ip_9.Text;
            table.DOMAIN_9 = domain_9.Text;
            table.USE_9 = use_9.Checked;

            table.IP_10 = ip_10.Text;
            table.DOMAIN_10 = domain_10.Text;
            table.USE_10 = use_10.Checked;

            table.IP_11 = ip_11.Text;
            table.DOMAIN_11 = domain_11.Text;
            table.USE_11 = use_11.Checked;

            table.IP_12 = ip_12.Text;
            table.DOMAIN_12 = domain_12.Text;
            table.USE_12 = use_12.Checked;

            table.IP_13 = ip_13.Text;
            table.DOMAIN_13 = domain_13.Text;
            table.USE_13 = use_13.Checked;

            table.IP_14 = ip_14.Text;
            table.DOMAIN_14 = domain_14.Text;
            table.USE_14 = use_14.Checked;

            table.IP_15 = ip_15.Text;
            table.DOMAIN_15 = domain_15.Text;
            table.USE_15 = use_15.Checked;

            table.IP_16 = ip_16.Text;
            table.DOMAIN_16 = domain_16.Text;
            table.USE_16 = use_16.Checked;

            table.IP_17 = ip_17.Text;
            table.DOMAIN_17 = domain_17.Text;
            table.USE_17 = use_17.Checked;

            table.IP_18 = ip_18.Text;
            table.DOMAIN_18 = domain_18.Text;
            table.USE_18 = use_18.Checked;

            table.IP_19 = ip_19.Text;
            table.DOMAIN_19 = domain_19.Text;
            table.USE_19 = use_19.Checked;

            table.IP_20 = ip_20.Text;
            table.DOMAIN_20 = domain_20.Text;
            table.USE_20 = use_20.Checked;

            table.IP_21 = ip_21.Text;
            table.DOMAIN_21 = domain_21.Text;
            table.USE_21 = use_21.Checked;

            table.IP_22 = ip_22.Text;
            table.DOMAIN_22 = domain_22.Text;
            table.USE_22 = use_22.Checked;

            table.IP_23 = ip_23.Text;
            table.DOMAIN_23 = domain_23.Text;
            table.USE_23 = use_23.Checked;

            table.IP_24 = ip_24.Text;
            table.DOMAIN_24 = domain_24.Text;
            table.USE_24 = use_24.Checked;

            table.IP_25 = ip_25.Text;
            table.DOMAIN_25 = domain_25.Text;
            table.USE_25 = use_25.Checked;

            //set 2
            table.IP_101 = ip_101.Text;
            table.DOMAIN_101 = domain_101.Text;
            table.USE_101 = use_101.Checked;

            table.IP_102 = ip_102.Text;
            table.DOMAIN_102 = domain_102.Text;
            table.USE_102 = use_102.Checked;

            table.IP_103 = ip_103.Text;
            table.DOMAIN_103 = domain_103.Text;
            table.USE_103 = use_103.Checked;

            table.IP_104 = ip_104.Text;
            table.DOMAIN_104 = domain_104.Text;
            table.USE_104 = use_104.Checked;

            table.IP_105 = ip_105.Text;
            table.DOMAIN_105 = domain_105.Text;
            table.USE_105 = use_105.Checked;

            table.IP_106 = ip_106.Text;
            table.DOMAIN_106 = domain_106.Text;
            table.USE_106 = use_106.Checked;

            table.IP_107 = ip_107.Text;
            table.DOMAIN_107 = domain_107.Text;
            table.USE_107 = use_107.Checked;

            table.IP_108 = ip_108.Text;
            table.DOMAIN_108 = domain_108.Text;
            table.USE_108 = use_108.Checked;

            table.IP_109 = ip_109.Text;
            table.DOMAIN_109 = domain_109.Text;
            table.USE_109 = use_109.Checked;

            table.IP_110 = ip_110.Text;
            table.DOMAIN_110 = domain_110.Text;
            table.USE_110 = use_110.Checked;

            table.IP_111 = ip_111.Text;
            table.DOMAIN_111 = domain_111.Text;
            table.USE_111 = use_111.Checked;

            table.IP_112 = ip_112.Text;
            table.DOMAIN_112 = domain_112.Text;
            table.USE_112 = use_112.Checked;

            table.IP_113 = ip_113.Text;
            table.DOMAIN_113 = domain_113.Text;
            table.USE_113 = use_113.Checked;

            table.IP_114 = ip_114.Text;
            table.DOMAIN_114 = domain_114.Text;
            table.USE_114 = use_114.Checked;

            table.IP_115 = ip_115.Text;
            table.DOMAIN_115 = domain_115.Text;
            table.USE_115 = use_115.Checked;

            table.IP_116 = ip_116.Text;
            table.DOMAIN_116 = domain_116.Text;
            table.USE_116 = use_116.Checked;

            table.IP_117 = ip_117.Text;
            table.DOMAIN_117 = domain_117.Text;
            table.USE_117 = use_117.Checked;

            table.IP_118 = ip_118.Text;
            table.DOMAIN_118 = domain_118.Text;
            table.USE_118 = use_118.Checked;

            table.IP_119 = ip_119.Text;
            table.DOMAIN_119 = domain_119.Text;
            table.USE_119 = use_119.Checked;

            table.IP_120 = ip_120.Text;
            table.DOMAIN_120 = domain_120.Text;
            table.USE_120 = use_120.Checked;

            table.IP_121 = ip_121.Text;
            table.DOMAIN_121 = domain_121.Text;
            table.USE_121 = use_121.Checked;

            table.IP_122 = ip_122.Text;
            table.DOMAIN_122 = domain_122.Text;
            table.USE_122 = use_122.Checked;

            table.IP_123 = ip_123.Text;
            table.DOMAIN_123 = domain_123.Text;
            table.USE_123 = use_123.Checked;

            table.IP_124 = ip_124.Text;
            table.DOMAIN_124 = domain_124.Text;
            table.USE_124 = use_124.Checked;

            table.IP_125 = ip_125.Text;
            table.DOMAIN_125 = domain_125.Text;
            table.USE_125 = use_125.Checked;


            XmlSerializer xs = new XmlSerializer(typeof(tables));
            using (FileStream fs = new FileStream(filename.Text + ".xml", FileMode.Create))
            {
                xs.Serialize(fs, table);
            }
            MessageBox.Show("Tables have been saved to local directory", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadtables()
        {
            if (File.Exists(filename.Text + ".xml"))
            {
                tables table;
                XmlSerializer xs = new XmlSerializer(typeof(tables));
                using (FileStream fs = new FileStream(filename.Text + ".xml", FileMode.Open))
                {
                    table = xs.Deserialize(fs) as tables;
                }

                if (table != null)
                {
                    //set 1
                    ip_1.Text = table.IP_1;
                    domain_1.Text = table.DOMAIN_1;
                    use_1.Checked = table.USE_1;

                    ip_2.Text = table.IP_2;
                    domain_2.Text = table.DOMAIN_2;
                    use_2.Checked = table.USE_2;

                    ip_3.Text = table.IP_3;
                    domain_3.Text = table.DOMAIN_3;
                    use_3.Checked = table.USE_3;

                    ip_4.Text = table.IP_4;
                    domain_4.Text = table.DOMAIN_4;
                    use_4.Checked = table.USE_4;

                    ip_5.Text = table.IP_5;
                    domain_5.Text = table.DOMAIN_5;
                    use_5.Checked = table.USE_5;

                    ip_6.Text = table.IP_6;
                    domain_6.Text = table.DOMAIN_6;
                    use_6.Checked = table.USE_6;

                    ip_7.Text = table.IP_7;
                    domain_7.Text = table.DOMAIN_7;
                    use_7.Checked = table.USE_7;

                    ip_8.Text = table.IP_8;
                    domain_8.Text = table.DOMAIN_8;
                    use_8.Checked = table.USE_8;

                    ip_9.Text = table.IP_9;
                    domain_9.Text = table.DOMAIN_9;
                    use_9.Checked = table.USE_9;

                    ip_10.Text = table.IP_10;
                    domain_10.Text = table.DOMAIN_10;
                    use_10.Checked = table.USE_10;

                    ip_11.Text = table.IP_11;
                    domain_11.Text = table.DOMAIN_11;
                    use_11.Checked = table.USE_11;

                    ip_12.Text = table.IP_12;
                    domain_12.Text = table.DOMAIN_12;
                    use_12.Checked = table.USE_12;

                    ip_13.Text = table.IP_13;
                    domain_13.Text = table.DOMAIN_13;
                    use_13.Checked = table.USE_13;

                    ip_14.Text = table.IP_14;
                    domain_14.Text = table.DOMAIN_14;
                    use_14.Checked = table.USE_14;

                    ip_15.Text = table.IP_15;
                    domain_15.Text = table.DOMAIN_15;
                    use_15.Checked = table.USE_15;

                    ip_16.Text = table.IP_16;
                    domain_16.Text = table.DOMAIN_16;
                    use_16.Checked = table.USE_16;

                    ip_17.Text = table.IP_17;
                    domain_17.Text = table.DOMAIN_17;
                    use_17.Checked = table.USE_17;

                    ip_18.Text = table.IP_18;
                    domain_18.Text = table.DOMAIN_18;
                    use_18.Checked = table.USE_18;

                    ip_19.Text = table.IP_19;
                    domain_19.Text = table.DOMAIN_19;
                    use_19.Checked = table.USE_19;

                    ip_20.Text = table.IP_20;
                    domain_20.Text = table.DOMAIN_20;
                    use_20.Checked = table.USE_20;

                    ip_21.Text = table.IP_21;
                    domain_21.Text = table.DOMAIN_21;
                    use_21.Checked = table.USE_21;

                    ip_22.Text = table.IP_22;
                    domain_22.Text = table.DOMAIN_22;
                    use_22.Checked = table.USE_22;

                    ip_23.Text = table.IP_23;
                    domain_23.Text = table.DOMAIN_23;
                    use_23.Checked = table.USE_23;

                    ip_24.Text = table.IP_24;
                    domain_24.Text = table.DOMAIN_24;
                    use_24.Checked = table.USE_24;

                    ip_25.Text = table.IP_25;
                    domain_25.Text = table.DOMAIN_25;
                    use_25.Checked = table.USE_25;

                    //set 2
                    ip_101.Text = table.IP_101;
                    domain_101.Text = table.DOMAIN_101;
                    use_101.Checked = table.USE_101;

                    ip_102.Text = table.IP_102;
                    domain_102.Text = table.DOMAIN_102;
                    use_102.Checked = table.USE_102;

                    ip_103.Text = table.IP_103;
                    domain_103.Text = table.DOMAIN_103;
                    use_103.Checked = table.USE_103;

                    ip_104.Text = table.IP_104;
                    domain_104.Text = table.DOMAIN_104;
                    use_104.Checked = table.USE_104;

                    ip_105.Text = table.IP_105;
                    domain_105.Text = table.DOMAIN_105;
                    use_105.Checked = table.USE_105;

                    ip_106.Text = table.IP_106;
                    domain_106.Text = table.DOMAIN_106;
                    use_106.Checked = table.USE_106;

                    ip_107.Text = table.IP_107;
                    domain_107.Text = table.DOMAIN_107;
                    use_107.Checked = table.USE_107;

                    ip_108.Text = table.IP_108;
                    domain_108.Text = table.DOMAIN_108;
                    use_108.Checked = table.USE_108;

                    ip_109.Text = table.IP_109;
                    domain_109.Text = table.DOMAIN_109;
                    use_109.Checked = table.USE_109;

                    ip_110.Text = table.IP_110;
                    domain_110.Text = table.DOMAIN_110;
                    use_110.Checked = table.USE_110;

                    ip_111.Text = table.IP_111;
                    domain_111.Text = table.DOMAIN_111;
                    use_111.Checked = table.USE_111;

                    ip_112.Text = table.IP_112;
                    domain_112.Text = table.DOMAIN_112;
                    use_112.Checked = table.USE_112;

                    ip_113.Text = table.IP_113;
                    domain_113.Text = table.DOMAIN_113;
                    use_113.Checked = table.USE_113;

                    ip_114.Text = table.IP_114;
                    domain_114.Text = table.DOMAIN_114;
                    use_114.Checked = table.USE_114;

                    ip_115.Text = table.IP_115;
                    domain_115.Text = table.DOMAIN_115;
                    use_115.Checked = table.USE_115;

                    ip_116.Text = table.IP_116;
                    domain_116.Text = table.DOMAIN_116;
                    use_116.Checked = table.USE_116;

                    ip_117.Text = table.IP_117;
                    domain_117.Text = table.DOMAIN_117;
                    use_117.Checked = table.USE_117;

                    ip_118.Text = table.IP_118;
                    domain_118.Text = table.DOMAIN_118;
                    use_118.Checked = table.USE_118;

                    ip_119.Text = table.IP_119;
                    domain_119.Text = table.DOMAIN_119;
                    use_119.Checked = table.USE_119;

                    ip_120.Text = table.IP_120;
                    domain_120.Text = table.DOMAIN_120;
                    use_120.Checked = table.USE_120;

                    ip_121.Text = table.IP_121;
                    domain_121.Text = table.DOMAIN_121;
                    use_121.Checked = table.USE_121;

                    ip_122.Text = table.IP_122;
                    domain_122.Text = table.DOMAIN_122;
                    use_122.Checked = table.USE_122;

                    ip_123.Text = table.IP_123;
                    domain_123.Text = table.DOMAIN_123;
                    use_123.Checked = table.USE_123;

                    ip_124.Text = table.IP_124;
                    domain_124.Text = table.DOMAIN_124;
                    use_124.Checked = table.USE_124;

                    ip_125.Text = table.IP_125;
                    domain_125.Text = table.DOMAIN_125;
                    use_125.Checked = table.USE_125;

                }
            }
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {
           var file = filename.Text + ".xml";
           dynamiclabel.Text = "Clear and Remove: " + System.Environment.NewLine + file;
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
                        File.Replace(@"hosts.bak", "hosts", "hosts");

                        Program.MessageCenter("The hosts file has been returned\nThe hosts file should be read by the system automatically.");
                       // MessageBox.Show("The hosts file has been returned\nThe hosts file should be read by the system automatically.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Program.MessageCenter("The hosts file does not exist\n\nYou should check a box and fill in either local or public ip and the dns domain name above then press the orange button after that try this action again.");
                //MessageBox.Show("The hosts file does not exist\n\nYou should check a box and fill in either local or public ip and the dns domain name above then press the orange button after that try this action again.", "System.IO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void release()
        {
            if (File.Exists(@"hosts.bak"))
            {
                File.Delete("hosts.bak");
            }
        }

        private void m_commit_Click(object sender, EventArgs e)
        {
            var newvalue = "# Copyright (c) 1993-2009 Microsoft Corp.\n#\n# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\n#\n# This file contains the mappings of IP addresses to host names. Each\n# entry should be kept on an individual line. The IP address should\n# be placed in the first column followed by the corresponding host name.\n# The IP address and the host name should be separated by at least one\n# space.\n#\n# Additionally, comments (such as these) may be inserted on individual\n# lines or following the machine name denoted by a '#' symbol.\n#\n# For example:\n#\n#      102.54.94.97     rhino.acme.com          # source server\n#       38.25.63.10     x.acme.com              # x client host\n\n# localhost name resolution is handled within DNS itself.\n#	127.0.0.1       localhost\n#	::1             localhost\n\n127.0.0.1       localhost\n";
            newvalue = newvalue.Replace("\n", System.Environment.NewLine);

            var end = System.Environment.NewLine;

            string ez = "#Do Not Remove This Line", d_001 = "#", d_002 = "#", d_003 = "#", d_004 = "#", d_005 = "#", d_006 = "#", d_007 = "#", d_008 = "#", d_009 = "#", d_010 = "#", d_011 = "#", d_012 = "#", d_013 = "#", d_014 = "#", d_015 = "#", d_016 = "#", d_017 = "#", d_018 = "#", d_019 = "#", d_020 = "#", d_021 = "#", d_022 = "#", d_023 = "#", d_024 = "#", d_025 = "#", d_101 = "#", d_102 = "#", d_103 = "#", d_104 = "#", d_105 = "#", d_106 = "#", d_107 = "#", d_108 = "#", d_109 = "#", d_110 = "#", d_111 = "#", d_112 = "#", d_113 = "#", d_114 = "#", d_115 = "#", d_116 = "#", d_117 = "#", d_118 = "#", d_119 = "#", d_120 = "#", d_121 = "#", d_122 = "#", d_123 = "#", d_124 = "#", d_125 = "#";

            //set 01
            if (use_1.Checked == true)
            {
                if(ip_1.Text == "" || domain_1.Text == "")
                {
                    d_001 = "#"+end;
                }
                else
                {
                    d_001 = ip_1.Text + "  " + domain_1.Text + end;
                }
            }
            else
            {
                d_001 = "#" + end;
            }
                
            if (use_2.Checked == true)
            {
                if (ip_2.Text == "" || domain_2.Text == "")
                {
                    d_002 = "#" + end;
                }
                else
                {
                    d_002 = ip_2.Text + "  " + domain_2.Text + end;
                }
            }
            else
            {
                d_002 = "#" + end;
            }


            if (use_3.Checked == true)
            {
                if (ip_3.Text == "" || domain_3.Text == "")
                {
                    d_003 = "#" + end;
                }
                else
                {
                    d_003 = ip_3.Text + "  " + domain_3.Text + end;
                }
            }
            else
            {
                d_003 = "#" + end;
            }

            if (use_4.Checked == true)
            {
                if (ip_4.Text == "" || domain_4.Text == "")
                {
                    d_004 = "#" + end;
                }
                else
                {
                    d_004 = ip_4.Text + "  " + domain_4.Text + end;
                }
            }
            else
            {
                d_004 = "#" + end;
            }

            if (use_5.Checked == true)
            {
                if (ip_5.Text == "" || domain_5.Text == "")
                {
                    d_005 = "#" + end;
                }
                else
                {
                    d_005 = ip_5.Text + "  " + domain_5.Text + end;
                }
            }
            else
            {
                d_005 = "#" + end;
            }

            if (use_6.Checked == true)
            {
                if (ip_6.Text == "" || domain_6.Text == "")
                {
                    d_006 = "#" + end;
                }
                else
                {
                    d_006 = ip_6.Text + "  " + domain_6.Text + end;
                }
            }
            else
            {
                d_006 = "#" + end;
            }

            if (use_7.Checked == true)
            {
                if (ip_7.Text == "" || domain_7.Text == "")
                {
                    d_007 = "#" + end;
                }
                else
                {
                    d_007 = ip_7.Text + "  " + domain_7.Text + end;
                }
            }
            else
            {
                d_007 = "#" + end;
            }

            if (use_8.Checked == true)
            {
                if (ip_8.Text == "" || domain_8.Text == "")
                {
                    d_008 = "#" + end;
                }
                else
                {
                    d_008 = ip_8.Text + "  " + domain_8.Text + end;
                }
            }
            else
            {
                d_008 = "#" + end;
            }

            if (use_9.Checked == true)
            {
                if (ip_9.Text == "" || domain_9.Text == "")
                {
                    d_009 = "#" + end;
                }
                else
                {
                    d_009 = ip_9.Text + "  " + domain_9.Text + end;
                }
            }
            else
            {
                d_009 = "#" + end;
            }

            if (use_10.Checked == true)
            {
                if (ip_10.Text == "" || domain_10.Text == "")
                {
                    d_010 = "#" + end;
                }
                else
                {
                    d_010 = ip_10.Text + "  " + domain_10.Text + end;
                }
            }
            else
            {
                d_010 = "#" + end;
            }

            if (use_11.Checked == true)
            {
                if (ip_11.Text == "" || domain_11.Text == "")
                {
                    d_011 = "#" + end;
                }
                else
                {
                    d_011 = ip_11.Text + "  " + domain_11.Text + end;
                }
            }
            else
            {
                d_011 = "#" + end;
            }

            if (use_12.Checked == true)
            {
                if (ip_12.Text == "" || domain_12.Text == "")
                {
                    d_012 = "#" + end;
                }
                else
                {
                    d_012 = ip_12.Text + "  " + domain_12.Text + end;
                }
            }
            else
            {
                d_012 = "#" + end;
            }


            if (use_13.Checked == true)
            {
                if (ip_13.Text == "" || domain_13.Text == "")
                {
                    d_013 = "#" + end;
                }
                else
                {
                    d_013 = ip_13.Text + "  " + domain_13.Text + end;
                }
            }
            else
            {
                d_013 = "#" + end;
            }

            if (use_14.Checked == true)
            {
                if (ip_14.Text == "" || domain_14.Text == "")
                {
                    d_014 = "#" + end;
                }
                else
                {
                    d_014 = ip_14.Text + "  " + domain_14.Text + end;
                }
            }
            else
            {
                d_014 = "#" + end;
            }

            if (use_15.Checked == true)
            {
                if (ip_15.Text == "" || domain_15.Text == "")
                {
                    d_015 = "#" + end;
                }
                else
                {
                    d_015 = ip_15.Text + "  " + domain_15.Text + end;
                }
            }
            else
            {
                d_015 = "#" + end;
            }

            if (use_16.Checked == true)
            {
                if (ip_16.Text == "" || domain_16.Text == "")
                {
                    d_016 = "#" + end;
                }
                else
                {
                    d_016 = ip_16.Text + "  " + domain_16.Text + end;
                }
            }
            else
            {
                d_016 = "#" + end;
            }

            if (use_17.Checked == true)
            {
                if (ip_17.Text == "" || domain_17.Text == "")
                {
                    d_017 = "#" + end;
                }
                else
                {
                    d_017 = ip_17.Text + "  " + domain_17.Text + end;
                }
            }
            else
            {
                d_017 = "#" + end;
            }

            if (use_18.Checked == true)
            {
                if (ip_18.Text == "" || domain_18.Text == "")
                {
                    d_018 = "#" + end;
                }
                else
                {
                    d_018 = ip_18.Text + "  " + domain_18.Text + end;
                }
            }
            else
            {
                d_018 = "#" + end;
            }

            if (use_19.Checked == true)
            {
                if (ip_19.Text == "" || domain_19.Text == "")
                {
                    d_019 = "#" + end;
                }
                else
                {
                    d_019 = ip_19.Text + "  " + domain_19.Text + end;
                }
            }
            else
            {
                d_019 = "#" + end;
            }

            if (use_20.Checked == true)
            {
                if (ip_20.Text == "" || domain_20.Text == "")
                {
                    d_020 = "#" + end;
                }
                else
                {
                    d_020 = ip_20.Text + "  " + domain_20.Text + end;
                }
            }
            else
            {
                d_020 = "#" + end;
            }



            if (use_21.Checked == true)
            {
                if (ip_21.Text == "" || domain_21.Text == "")
                {
                    d_021 = "#" + end;
                }
                else
                {
                    d_021 = ip_21.Text + "  " + domain_21.Text + end;
                }
            }
            else
            {
                d_021 = "#" + end;
            }

            if (use_22.Checked == true)
            {
                if (ip_22.Text == "" || domain_22.Text == "")
                {
                    d_022 = "#" + end;
                }
                else
                {
                    d_022 = ip_22.Text + "  " + domain_22.Text + end;
                }
            }
            else
            {
                d_022 = "#" + end;
            }


            if (use_23.Checked == true)
            {
                if (ip_23.Text == "" || domain_23.Text == "")
                {
                    d_023 = "#" + end;
                }
                else
                {
                    d_023 = ip_23.Text + "  " + domain_23.Text + end;
                }
            }
            else
            {
                d_023 = "#" + end;
            }

            if (use_24.Checked == true)
            {
                if (ip_24.Text == "" || domain_24.Text == "")
                {
                    d_024 = "#" + end;
                }
                else
                {
                    d_024 = ip_24.Text + "  " + domain_24.Text + end;
                }
            }
            else
            {
                d_024 = "#" + end;
            }

            if (use_25.Checked == true)
            {
                if (ip_25.Text == "" || domain_25.Text == "")
                {
                    d_025 = "#" + end;
                }
                else
                {
                    d_025 = ip_25.Text + "  " + domain_25.Text + end;
                }
            }
            else
            {
                d_025 = "#" + end;
            }



            //set 01
            if (use_101.Checked == true)
            {
                if (ip_101.Text == "" || domain_101.Text == "")
                {
                    d_101 = "#" + end;
                }
                else
                {
                    d_101 = ip_101.Text + "  " + domain_101.Text + end;
                }
            }
            else
            {
                d_101 = "#" + end;
            }

            if (use_102.Checked == true)
            {
                if (ip_102.Text == "" || domain_102.Text == "")
                {
                    d_102 = "#" + end;
                }
                else
                {
                    d_102 = ip_102.Text + "  " + domain_102.Text + end;
                }
            }
            else
            {
                d_102 = "#" + end;
            }


            if (use_103.Checked == true)
            {
                if (ip_103.Text == "" || domain_103.Text == "")
                {
                    d_103 = "#" + end;
                }
                else
                {
                    d_103 = ip_103.Text + "  " + domain_103.Text + end;
                }
            }
            else
            {
                d_103 = "#" + end;
            }

            if (use_104.Checked == true)
            {
                if (ip_104.Text == "" || domain_104.Text == "")
                {
                    d_104 = "#" + end;
                }
                else
                {
                    d_104 = ip_104.Text + "  " + domain_104.Text + end;
                }
            }
            else
            {
                d_104 = "#" + end;
            }

            if (use_105.Checked == true)
            {
                if (ip_105.Text == "" || domain_105.Text == "")
                {
                    d_105 = "#" + end;
                }
                else
                {
                    d_105 = ip_105.Text + "  " + domain_105.Text + end;
                }
            }
            else
            {
                d_105 = "#" + end;
            }

            if (use_106.Checked == true)
            {
                if (ip_106.Text == "" || domain_106.Text == "")
                {
                    d_106 = "#" + end;
                }
                else
                {
                    d_106 = ip_106.Text + "  " + domain_106.Text + end;
                }
            }
            else
            {
                d_106 = "#" + end;
            }

            if (use_107.Checked == true)
            {
                if (ip_107.Text == "" || domain_107.Text == "")
                {
                    d_107 = "#" + end;
                }
                else
                {
                    d_107 = ip_107.Text + "  " + domain_107.Text + end;
                }
            }
            else
            {
                d_107 = "#" + end;
            }

            if (use_108.Checked == true)
            {
                if (ip_108.Text == "" || domain_108.Text == "")
                {
                    d_108 = "#" + end;
                }
                else
                {
                    d_108 = ip_108.Text + "  " + domain_108.Text + end;
                }
            }
            else
            {
                d_108 = "#" + end;
            }

            if (use_109.Checked == true)
            {
                if (ip_109.Text == "" || domain_109.Text == "")
                {
                    d_109 = "#" + end;
                }
                else
                {
                    d_109 = ip_109.Text + "  " + domain_109.Text + end;
                }
            }
            else
            {
                d_109 = "#" + end;
            }

            if (use_110.Checked == true)
            {
                if (ip_110.Text == "" || domain_110.Text == "")
                {
                    d_110 = "#" + end;
                }
                else
                {
                    d_110 = ip_110.Text + "  " + domain_110.Text + end;
                }
            }
            else
            {
                d_110 = "#" + end;
            }

            if (use_111.Checked == true)
            {
                if (ip_111.Text == "" || domain_111.Text == "")
                {
                    d_111 = "#" + end;
                }
                else
                {
                    d_111 = ip_111.Text + "  " + domain_111.Text + end;
                }
            }
            else
            {
                d_111 = "#" + end;
            }

            if (use_112.Checked == true)
            {
                if (ip_112.Text == "" || domain_112.Text == "")
                {
                    d_112 = "#" + end;
                }
                else
                {
                    d_112 = ip_112.Text + "  " + domain_112.Text + end;
                }
            }
            else
            {
                d_112 = "#" + end;
            }


            if (use_113.Checked == true)
            {
                if (ip_113.Text == "" || domain_113.Text == "")
                {
                    d_113 = "#" + end;
                }
                else
                {
                    d_113 = ip_113.Text + "  " + domain_113.Text + end;
                }
            }
            else
            {
                d_113 = "#" + end;
            }

            if (use_114.Checked == true)
            {
                if (ip_114.Text == "" || domain_114.Text == "")
                {
                    d_114 = "#" + end;
                }
                else
                {
                    d_114 = ip_114.Text + "  " + domain_114.Text + end;
                }
            }
            else
            {
                d_114 = "#" + end;
            }

            if (use_115.Checked == true)
            {
                if (ip_115.Text == "" || domain_115.Text == "")
                {
                    d_115 = "#" + end;
                }
                else
                {
                    d_115 = ip_115.Text + "  " + domain_115.Text + end;
                }
            }
            else
            {
                d_115 = "#" + end;
            }

            if (use_116.Checked == true)
            {
                if (ip_116.Text == "" || domain_116.Text == "")
                {
                    d_116 = "#" + end;
                }
                else
                {
                    d_116 = ip_116.Text + "  " + domain_116.Text + end;
                }
            }
            else
            {
                d_116 = "#" + end;
            }

            if (use_117.Checked == true)
            {
                if (ip_117.Text == "" || domain_117.Text == "")
                {
                    d_117 = "#" + end;
                }
                else
                {
                    d_117 = ip_117.Text + "  " + domain_117.Text + end;
                }
            }
            else
            {
                d_117 = "#" + end;
            }

            if (use_118.Checked == true)
            {
                if (ip_118.Text == "" || domain_118.Text == "")
                {
                    d_118 = "#" + end;
                }
                else
                {
                    d_118 = ip_118.Text + "  " + domain_118.Text + end;
                }
            }
            else
            {
                d_118 = "#" + end;
            }

            if (use_119.Checked == true)
            {
                if (ip_119.Text == "" || domain_119.Text == "")
                {
                    d_119 = "#" + end;
                }
                else
                {
                    d_119 = ip_119.Text + "  " + domain_119.Text + end;
                }
            }
            else
            {
                d_119 = "#" + end;
            }

            if (use_120.Checked == true)
            {
                if (ip_120.Text == "" || domain_120.Text == "")
                {
                    d_120 = "#" + end;
                }
                else
                {
                    d_120 = ip_120.Text + "  " + domain_120.Text + end;
                }
            }
            else
            {
                d_120 = "#" + end;
            }



            if (use_121.Checked == true)
            {
                if (ip_121.Text == "" || domain_121.Text == "")
                {
                    d_121 = "#" + end;
                }
                else
                {
                    d_121 = ip_121.Text + "  " + domain_121.Text + end;
                }
            }
            else
            {
                d_121 = "#" + end;
            }

            if (use_122.Checked == true)
            {
                if (ip_122.Text == "" || domain_122.Text == "")
                {
                    d_122 = "#" + end;
                }
                else
                {
                    d_122 = ip_122.Text + "  " + domain_122.Text + end;
                }
            }
            else
            {
                d_122 = "#" + end;
            }


            if (use_123.Checked == true)
            {
                if (ip_123.Text == "" || domain_123.Text == "")
                {
                    d_123 = "#" + end;
                }
                else
                {
                    d_123 = ip_123.Text + "  " + domain_123.Text + end;
                }
            }
            else
            {
                d_123 = "#" + end;
            }

            if (use_124.Checked == true)
            {
                if (ip_124.Text == "" || domain_124.Text == "")
                {
                    d_124 = "#" + end;
                }
                else
                {
                    d_124 = ip_124.Text + "  " + domain_124.Text + end;
                }
            }
            else
            {
                d_124 = "#" + end;
            }

            if (use_125.Checked == true)
            {
                if (ip_125.Text == "" || domain_125.Text == "")
                {
                    d_125 = "#" + end;
                }
                else
                {
                    d_125 = ip_125.Text + "  " + domain_125.Text + end;
                }
            }
            else
            {
                d_125 = "#" + end;
            }

                StreamWriter file = new StreamWriter("hosts");
                var line = ez + end + newvalue + d_001 + d_002 + d_003 + d_004 + d_005 + d_006 + d_007 + d_008 + d_009 + d_010 + d_011 + d_012 + d_013 + d_014 + d_015 + d_016 + d_017 + d_018 + d_019 + d_020 + d_021 + d_022 + d_023 + d_024 + d_025 + d_101 + d_102 + d_103 + d_104 + d_105 + d_106 + d_107 + d_108 + d_109 + d_110 + d_111 + d_112 + d_113 + d_114 + d_115 + d_116 + d_117 + d_118 + d_119 + d_120 + d_121 + d_122 + d_123 + d_124 + d_125;
                file.Write(line);
                file.Close();

                Program.MessageCenter("The hosts file has been saved to the program directory\nYou should press the green folder to return the hosts file back to its normal directory so your system can read it.");
                //MessageBox.Show("The hosts file has been saved to the program directory\nYou should press the green folder to return the hosts file back to its normal directory so your system can read it.", "Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Windows.lookup.Show();
        }

    }
}
