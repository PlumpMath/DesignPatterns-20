using System;

namespace InterpreterPattern
{
    public class TerminalExpression:AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}