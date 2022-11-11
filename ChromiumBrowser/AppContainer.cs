using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromiumBrowser
{
   public partial class AppContainer : TitleBarTabs
   {
      public AppContainer()
      {
         InitializeComponent();

         AeroPeekEnabled = true;
         TabRenderer = new ChromeTabRenderer(this);
      }

      public override TitleBarTab CreateTab()
      {
         return new TitleBarTab(this)
         {
            Content = new FrmMain
            {
               Text = "New Tab"
            }
         };
      }
   }
}
