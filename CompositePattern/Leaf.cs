using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public Leaf(string name):base(name)
        {
            
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Leaf 不可添加");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+Name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Leaf 不可移除");
        }
    }
}
