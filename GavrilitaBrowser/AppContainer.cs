using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GavrilitaBrowser
{
   public partial class AppContainer: TitleBarTabs
   {
      public AppContainer()
      {
         InitializeComponent();

         AeroPeekEnabled = true;
         TabRenderer = new ChromeTabRenderer(this);
      }
   }
}
