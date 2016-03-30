using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d=new Director();
            Builder b1=new ConcreteBuilder1();
            Builder b2=new ConcreteBuilder2();

            d.Construct(b1);
            Product p1 = b1.GetProduct();
            p1.Show();

            d.Construct(b2);
            Product p2 = b2.GetProduct();
            p2.Show();

            Console.ReadKey();
        }
    }
}
