using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m=new ConcreteMediator();

            ConcreteColleageue1 c1=new ConcreteColleageue1(m);
            ConcreteColleageue2 c2=new ConcreteColleageue2(m);

            m.Colleageue1 = c1;
            m.Colleageue2 = c2;

            c1.Send("hello");
            c2.Send("矮油，不错呦");

            Console.ReadKey();
        }
    }
}
