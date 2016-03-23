using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xiaohong=new Person("小红");
            TShirts t=new TShirts();
            Trouser tr=new Trouser();
            t.Decorate(xiaohong);
            tr.Decorate(t);
            tr.Show();
            Console.ReadKey();
        }
    }
}
