using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Framework.Config
{
   public class PathConfig
    {
        static string AppFolder = AppDomain.CurrentDomain.BaseDirectory;

        public static string DBConnectionConfigPath
        {
            get { return AppFolder + "\\Config\\DBConnection.xml"; }
        }


        public static string RibbonConfigPath
        {
            get { return AppFolder + "\\Config\\Menus.xml"; }
        }

        public static string DockWindowConfigPath
        {
            get { return AppFolder + "\\Config\\Docks.xml"; }
        }

        public static string SystemConfigPath
        {
            get { return AppFolder + "\\Config\\System.xml"; }
        }

        public static string UserMenusConfigPath
        {
            get { return AppFolder + "\\Config\\UserMenus.xml"; }
        }



        public static string ImageFolderPath
        {
            get { return AppFolder + "\\Resource\\Images\\"; }
        }


        public static string PluginFolderPath
        {
            get { return AppFolder + "\\Plugins\\"; }
        }
    }
}
