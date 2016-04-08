using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    public class DataAccess
    {
        public static readonly string db = "SqlServer";

        public static IUser CreateUser()
        {
            IUser result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlserverUser();
                    break;
                case "Access":
                    result =new AccessUser();
                    break;
            }
            return result;
        }
        
    }
}
