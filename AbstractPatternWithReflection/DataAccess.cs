using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPatternWithReflection
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractPatternWithReflection";
        //private static readonly string db = "Sqlserver";
        private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            string classname = AssemblyName + "." + db + "User";
            return (IUser) Assembly.Load(AssemblyName).CreateInstance(classname);
        }
        
    }
}
