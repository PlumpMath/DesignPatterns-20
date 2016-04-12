using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public  class Composite:Component
   {

       private List<Component> Children = new List<Component>();
       public Composite(string name) : base(name)
       {
       }

       public override void Add(Component c)
       {
           Children.Add(c);
       }

       public override void Remove(Component c)
       {
           Children.Remove(c);
       }

       public override void Display(int depth)
       {
           Console.WriteLine(new string('-',depth)+Name);
           foreach (var itme in Children)
           {
                itme.Display(depth+2);
           }
       }
    }
}
