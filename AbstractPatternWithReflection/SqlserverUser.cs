using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPatternWithReflection
{
    public class SqlserverUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在sqlserver中添加了一条数据");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("从sqlserver中获得了一条记录");
            return null;
        }
    }
}
