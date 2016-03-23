using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Trouser : Finery
    {

        public override void Show()
        {
            Console.WriteLine("Trouser");
            base.Show();
        }
    }
}
