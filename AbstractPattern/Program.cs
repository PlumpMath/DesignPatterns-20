using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User u=new User();
            IFactory factory=new SqlServerFactory();
            IUser iu = factory.CreaUser();
            iu.GetUser(1);
            iu.Insert(new User() );
            Console.ReadKey();
        }
    }
}
