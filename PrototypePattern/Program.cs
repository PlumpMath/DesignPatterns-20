using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r=new Resume("name");
            r.SetPersonalInfo("男","age");
            r.SetWorkExperience(DateTime.Now.ToString(),"company");

            Resume re = (Resume) r.Clone();
            re.SetPersonalInfo("女", "18");
            re.SetWorkExperience(DateTime.Now.ToString(), "company");


            Resume res = (Resume) re.Clone();
            res.SetPersonalInfo("不知道", "100");
            res.SetWorkExperience(DateTime.Now.AddYears(10).ToString(), "company");

            r.Display();
            re.Display();
            res.Display();

            Console.ReadKey();
        }
    }
}
