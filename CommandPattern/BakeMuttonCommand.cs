namespace CommandPattern
{
    public class BakeMuttonCommand:Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            Receiver.BakeMutton();
        }
    }
}