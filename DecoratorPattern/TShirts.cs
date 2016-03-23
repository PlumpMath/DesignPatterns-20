using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("TShirt");
            base.Show();
        }
    }
}
