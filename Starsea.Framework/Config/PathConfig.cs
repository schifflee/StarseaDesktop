using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Framework.Config
{
   public class PathConfig
    {    

        public static string DBConnectionConfigPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Config\\DBConnection.xml"; }
        }


        public static string RibbonConfigPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Config\\Menus.xml"; }
        }

        public static string DockWindowConfigPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Config\\Docks.xml"; }
        }

        public static string SystemConfigPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Config\\System.xml"; }
        }

        public static string UserMenusConfigPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Config\\UserMenus.xml"; }
        }



        public static string ImageFolderPath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + "\\Resource\\Images\\"; }
        }
    }
}
