namespace StatePattern
{
    public class Work
    {
        private State _currentState;
        private double _hour;
        private bool _finish;

        public State State
        {
            get
            {
                return _currentState;
            }

            set
            {
                _currentState = value;
            }
        }

        public double Hour
        {
            get
            {
                return _hour;
            }

            set
            {
                _hour = value;
            }
        }

        public bool Finish
        {
            get
            {
                return _finish;
            }

            set
            {
                _finish = value;
            }
        }

        public Work()
        {
            _currentState = new ForenoonState();
        }

        public void SetState(State s)
        {
            _currentState = s;
        }

        public void WritteProgram()
        {
            _currentState.WritteProgram(this);
        }
    }
}