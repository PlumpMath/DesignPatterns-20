using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPatternWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            User u=new User();
            //IFactory factory=new SqlServerFactory();
            IUser iu = DataAccess.CreateUser();

            iu.GetUser(1);
            iu.Insert(new User());

            Console.ReadKey();
        }
    }
}
