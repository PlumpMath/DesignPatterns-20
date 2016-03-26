using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiFengFactoryPattern
{
   public  class VolunteerFactory:IFactory
    {
       public LeiFeng CreateLeiFeng()
       {
           return new Volunteer();
       }
    }
}
