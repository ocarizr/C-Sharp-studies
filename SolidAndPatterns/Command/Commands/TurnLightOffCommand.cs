namespace Command
{
    class TurnLightOffCommand : LightModifier, ICommand
    {
        public TurnLightOffCommand(Light light) : base(light) { }

        public void Execute()
        {
            _lastIntensity = _light.Intensity;
            _light.Intensity = 0;
        }

        public void Unexecute() => _light.Intensity = _lastIntensity;
    }
}