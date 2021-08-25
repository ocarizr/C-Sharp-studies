namespace Command
{
    internal class LightController
    {
        private ICommand _turnOff;
        private ICommand _reduceIntensity;
        private ICommand _increaseIntensity;

        public LightController(
            ICommand turnOff,
            ICommand reduceIntensity,
            ICommand increaseIntensity)
        {
            _turnOff = turnOff;
            _reduceIntensity = reduceIntensity;
            _increaseIntensity = increaseIntensity;
        }

        public void TurnOn() => _turnOff.Unexecute();
        public void TurnOff() => _turnOff.Execute();
        public void ReduceIntensity() => _reduceIntensity.Execute();
        public void IncreaseIntensity() => _increaseIntensity.Execute();
    }
}