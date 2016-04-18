namespace MediatorPattern
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}