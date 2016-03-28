using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class AbstractClass
    {
        public abstract void Operation_ONE();
        public abstract void Operation_TWO();

        public void TemplateMethod()
        {
            Operation_ONE();
            Operation_TWO();
            Console.WriteLine("Done");
        }
    }
}
