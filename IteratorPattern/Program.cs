using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateAggregate concreateAggregate=new ConcreateAggregate();
            for (int i = 0; i < 10; i++)
            {
                concreateAggregate[i]=new Random().Next();
            }

            //Iterator iterator=new ConcreateIterator(concreateAggregate);
            Iterator iterator = concreateAggregate.CreateIterator();
            object item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
