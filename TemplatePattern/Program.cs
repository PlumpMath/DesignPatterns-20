using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a=new ConcreteClass_ONE();
            a.TemplateMethod();
            Console.ReadKey();

            AbstractClass ab=new ConcreteClass_ONE();
            ab.TemplateMethod();
            Console.ReadKey();
        }
    }
}
