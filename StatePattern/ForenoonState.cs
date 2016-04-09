using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class ForenoonState : State
    {
        public override void WritteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine($"当前时间{w.Hour}上午工作，精神百倍");
            }
            else
            {
                w.SetState(new NoonState());
                w.WritteProgram();
            }
        }
    }
}
