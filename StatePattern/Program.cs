using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++紧急项目+++++++++++++++++++++++++++++++++");
            var emergencyProject = new Work();
            emergencyProject.Hour = 8;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 9;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 10;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 11;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 12;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 13;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 15;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 17;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 19;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 21;
            emergencyProject.WritteProgram();
            emergencyProject.Hour = 23;
            emergencyProject.WritteProgram();


            Console.WriteLine("+++++++++++++++++++++++++++++++++普通项目+++++++++++++++++++++++++++++++++");

            var simpleProject = new Work();
            simpleProject.Hour = 8;
            simpleProject.WritteProgram();
            simpleProject.Hour = 9;
            simpleProject.WritteProgram();
            simpleProject.Hour = 10;
            simpleProject.WritteProgram();
            simpleProject.Hour = 11;
            simpleProject.WritteProgram();
            simpleProject.Hour = 12;
            simpleProject.WritteProgram();
            simpleProject.Hour = 13;
            simpleProject.WritteProgram();
            simpleProject.Hour = 15;
            simpleProject.Finish = true;
            simpleProject.WritteProgram();
            simpleProject.Hour = 17;
            simpleProject.WritteProgram();
            simpleProject.Hour = 19;
            simpleProject.WritteProgram();
            simpleProject.Hour = 21;
            simpleProject.WritteProgram();
            simpleProject.Hour = 23;
            simpleProject.WritteProgram();


            Console.ReadKey();
        }
    }
}
