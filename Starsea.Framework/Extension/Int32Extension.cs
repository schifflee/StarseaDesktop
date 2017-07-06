using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Framework.Extension
{
   public static class Int32Extension
    {
        public static string FormatForMoney(this int Value) {
            return Value.ToString("￥####,####,####");
        }
    }
}
