using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl schoolGirl=new SchoolGirl();
            schoolGirl.Name = "girl";
            Proxy proxy=new Proxy(schoolGirl);
            proxy.GiveChocolate();
            proxy.GiveDolles();
            proxy.GiveFlowers();
            Console.ReadKey();
        }
    }
}
