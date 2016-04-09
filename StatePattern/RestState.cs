using System;

namespace StatePattern
{
    internal class RestState : State
    {
        public override void WritteProgram(Work w)
        {
            Console.WriteLine($"当前时间{w.Hour}下班");
        }
    }
}