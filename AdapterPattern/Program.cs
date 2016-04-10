using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Target target=new Target();
            //target.Request();
            //Console.ReadKey();
            
            //Adaptee adaptee=new Adaptee();
            //Adapter adapter=new Adapter(adaptee);
            //adapter.Request();
            //Console.ReadKey();


            Target target=new Adapter(new Adaptee());
            target.Request();
            Console.ReadKey();
        }
    }
}
