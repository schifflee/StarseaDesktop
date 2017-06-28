using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Helper
{
   public class CloneHelper
    {
        public static void CopyValue(object origin, object target)
        {
            try {
                System.Reflection.PropertyInfo[] tar_properties = (target.GetType()).GetProperties();

                System.Reflection.PropertyInfo[] ori_properties = (origin.GetType()).GetProperties();

                if (origin.GetType().FullName == target.GetType().FullName && origin != null && target != null) {
                    for (int i = 0; i < origin.GetType().GetProperties().Length; i++) {
                        (target.GetType()).GetProperties()[i].SetValue(target, ori_properties[i].GetValue(origin, null));
                    }
                }

            }
            catch (Exception eg) {               
                throw eg;                
            }


        }

    }
}
