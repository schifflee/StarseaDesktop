using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Helper
{
   public  class Base64Helper
    {

        public static string ToBase64(string str) {
            if (str==null) {
                str = "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }

        public static string FromBase64(string base64str) {
            if (base64str == null)
            {
                base64str = "";
            }
            byte[] outbyte = Convert.FromBase64String(base64str);
            return Encoding.UTF8.GetString(outbyte);
        }

        public static T ToBase64<T>(T obj) {



            return obj;

        }


        public static T FromBase64<T>(T obj) {


            return obj;
        }



    }
}
