using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class ConcreteClass_TWO:AbstractClass
    {
        public override void Operation_ONE()
        {
            Console.WriteLine("实现了Operation_ONE");
        }

        public override void Operation_TWO()
        {
            Console.WriteLine("实现了Operation_TWO");
        }
    }
}
