using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYHOSTSEDITOR
{
    public static class Program
    {
        public static Boolean commandPassed = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            { 
                if (args[1] == "-a" || args[1] == "-b" || args[1] == "-l" || args[1] == "-c")
                {
                    string basic = "-b", advanced = "-a", lookup = "-l", lookup_extended = "-c";

                    if (Array.IndexOf(args, basic) != -1)
                    {
                        Windows.basic.Show();
                    }
                    if (Array.IndexOf(args, advanced) != -1)
                    {
                        Windows.advanced.Show();
                    }
                    if (Array.IndexOf(args, lookup) != -1 || Array.IndexOf(args, lookup_extended) != -1)
                    {
                        commandPassed = true;
                        Windows.lookup.Show();
                    }

                }
                else
                {
                    //Process.GetCurrentProcess().Kill();
                    Windows.menu.Show();
                }
            }
            else
            {
                Windows.menu.Show(); //load Menu by default
            }

            Application.Run();
        }

  
        public static void MessageCenter(String Message)
        { 
            if (!RobertMisiak.NotifyWindow.IsBusy)
            {
                RobertMisiak.NotifyWindow Notify = new RobertMisiak.NotifyWindow();
                RobertMisiak.NotifyWindow.IsBusy = true;
                Notify.Text = Message;
                Notify.ActualWidth = 300;
                Notify.ActualHeight = 100;
                Notify.GradientColor = System.Drawing.Color.White;
                Notify.WaitTime = 3000;
                Notify.Notify();
            }     
        }
    }

    public static class Windows
    {
        public static Menu menu = new Menu();
        public static Lookup lookup = new Lookup();
        public static Basic basic = new Basic();
        public static Advanced advanced = new Advanced();
    }


}
