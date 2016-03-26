using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiFengFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory=new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();
            Console.ReadKey();


            IFactory _factory=new VolunteerFactory();
            LeiFeng leifengVolunteer = _factory.CreateLeiFeng();
            leifengVolunteer.BuyRice();
            leifengVolunteer.Sweep();
            leifengVolunteer.Wash();
            Console.ReadKey();
        }
    }
}
