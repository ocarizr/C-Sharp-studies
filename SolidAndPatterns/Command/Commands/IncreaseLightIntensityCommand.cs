namespace Command
{
    class IncreaseLightIntensityCommand : LightModifier, ICommand
    {
        public IncreaseLightIntensityCommand(Light light) : base(light) { }

        public void Execute()
        {
            _lastIntensity = _light.Intensity;
            _light.Intensity++;
        }

        public void Unexecute() => _light.Intensity = _lastIntensity;
    }
}