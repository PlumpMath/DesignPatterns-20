using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one=new SubSystemOne();
            two=new SubSystemTwo();
            three=new SubSystemThree();
            four=new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("MethodA is start");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("MethodB is start");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
        }
    }
}
