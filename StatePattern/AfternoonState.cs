using System;

namespace StatePattern
{
    public class AfternoonState : State
    {
        public override void WritteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine($"当前时间{w.Hour}下午更困");
            }
            else
            {
                w.SetState(new EveningState());
                w.WritteProgram();
            }
        }
        
    }
}