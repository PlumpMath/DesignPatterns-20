using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root=new Composite("ROOT");
            root.Add(new Leaf("leaf1"));
            root.Add(new Leaf("leaf2"));

            Composite composite=new Composite("Composite1");
            composite.Add(new Leaf("leaf 1-1"));
            composite.Add(new Leaf("leaf 1-2"));


            root.Add(composite);

            Composite composite2 =new Composite("composite");
            composite2.Add(new Leaf("leaf 2-1"));
            composite2.Add(new Leaf("leaf 2-2"));

            composite.Add(composite2);


            root.Add(new Leaf("LEAF ONE"));
            root.Add(new Leaf("LEAF TWO"));

            root.Display(1);

            Console.Read();

        }
    }
}
