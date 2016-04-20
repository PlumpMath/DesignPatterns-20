namespace InterpreterPattern
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}