using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GavrilitaBrowser
{
   static class Program
   {
      /// <summary>
      /// Главная точка входа для приложения.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         AppContainer container = new AppContainer();

         // Add the initial Tab 
         container.Tabs.Add(
            // Our First tab created by default in the Application will have as content the Form1
            new TitleBarTab(container)
            {
               Content = new frmBrowser
               {
                  Text = "New Tab"
               }
            }
            );

         // Set initial tab the first one
         container.SelectedTabIndex = 0;

         // Create tabs and start application
         TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
         applicationContext.Start(container);
         Application.Run(applicationContext);
      }
   }
}
