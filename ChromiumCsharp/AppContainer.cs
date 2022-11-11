using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ChromiumCsharp
{
   public partial class AppContainer: TitleBarTabs
   {
      public AppContainer()
      {
         InitializeComponent();
         AeroPeekEnabled = true;
         TabRenderer = new ChromeTabRenderer(this);
         Icon = Properties.Resources.chrome;
      }

      public override TitleBarTab CreateTab()
      {
         return new TitleBarTab(this)
         {
            Content = new Form1 { Text = "New Tab" }
         };
      }
   }
}
