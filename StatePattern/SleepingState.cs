using System;

namespace StatePattern
{
    internal class SleepingState : State
    {
        public override void WritteProgram(Work w)
        {
            Console.WriteLine($"当前时间{w.Hour}我睡着了");
        }
    }
}