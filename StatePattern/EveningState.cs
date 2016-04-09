using System;

namespace StatePattern
{
    internal class EveningState : State
    {
        public override void WritteProgram(Work w)
        {
            if (w.Finish)
            {
                w.SetState(new RestState());
                w.WritteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine($"当前时间{w.Hour}加班好累");
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WritteProgram();
                }
            }
        }
    }
}