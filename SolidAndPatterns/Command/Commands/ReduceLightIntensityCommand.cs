namespace Command
{
    class ReduceLightIntensityCommand : LightModifier, ICommand
    {
        public ReduceLightIntensityCommand(Light light) : base(light) { }

        public void Execute()
        {
            if (_light.Intensity > 0)
            {
                _lastIntensity = _light.Intensity;
                _light.Intensity--;
            }
        }

        public void Unexecute() => _light.Intensity = _lastIntensity;
    }
}