using System;

namespace FlyweightPattern
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"不共享的Flyweight:{extrinsicstate}");
        }
    }
}