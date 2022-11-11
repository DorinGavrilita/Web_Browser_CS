using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;

namespace ChromiumBrowser
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

         container.Tabs.Add(
            new TitleBarTab(container)
            {
               Content = new FrmMain
               {
                  Text = "New Tab"
               }

            }
         );

         container.SelectedTabIndex = 0;

         TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
         applicationContext.Start(container);
         Application.Run(applicationContext);


         Application.Run(new FrmMain());
      }
   }
}
