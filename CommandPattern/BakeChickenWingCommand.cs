namespace CommandPattern
{
    public class BakeChickenWingCommand:Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            Receiver.BakeChickenWing();
        }
    }
}