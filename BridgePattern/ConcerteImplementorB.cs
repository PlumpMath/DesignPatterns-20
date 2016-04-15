using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcerteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现类B的方法");
        }
    }
}
