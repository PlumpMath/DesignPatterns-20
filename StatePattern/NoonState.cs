using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NoonState : State
    {
        public override void WritteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine($"当前时间{w.Hour}中午犯困");
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WritteProgram();
            }
        }
    }
}
