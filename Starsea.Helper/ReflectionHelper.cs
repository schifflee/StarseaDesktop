using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.Helper
{
   public class ReflectionHelper
    {

        public static Assembly getAssembly(string dllPath) {

            Assembly accembly = null;
            try
            {
                accembly = Assembly.LoadFrom(dllPath);
            }
            catch (FileLoadException ex1)
            {
                throw ex1;
            }
            catch (Exception ex2)
            {
                throw new Exception(string.Format("加载程序集{0}出错", dllPath), ex2);
            }
            return accembly;


        }

        public static Object CreateInstance(Assembly ass,string className) {
            object obj = ass.CreateInstance(className);
            return obj;
        }

        public static MethodInfo GetMethod(Object obj,string methodName, BindingFlags myBindingFlags) {
            Type type = obj.GetType();
            MethodInfo MethodInfo = type.GetMethod(methodName, myBindingFlags);
            return MethodInfo;
        }

      
    }
}
