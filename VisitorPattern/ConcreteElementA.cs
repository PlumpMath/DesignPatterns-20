namespace VisitorPattern
{
    public class ConcreteElementA:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void Operation() { }
    }
}