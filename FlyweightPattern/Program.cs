using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsincstate = 22;
            FlyweightFactory f=new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(extrinsincstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(extrinsincstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(extrinsincstate);

            Flyweight uf=new UnsharedConcreteFlyweight();
            uf.Operation(extrinsincstate);

            Console.ReadKey();
        }
    }
}
