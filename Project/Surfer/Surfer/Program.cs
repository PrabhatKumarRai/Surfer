using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;

namespace Surfer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            AppContainer container = new AppContainer();

            //Add Initial Tab
            container.Tabs.Add(
                    new TitleBarTab(container)
                    {
                        Content = new Form1
                        {
                            Text = "Surfer"
                        }
                    }
                );

            //Set Initial Tab for the first one
            container.SelectedTabIndex = 0;

            //Create Tabs and Start Application
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
