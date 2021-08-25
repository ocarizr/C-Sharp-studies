namespace Command
{
    class LightModifier
    {
        protected Light _light;
        protected int _lastIntensity;
        protected LightModifier(Light light)
        {
            _light = light;
            _lastIntensity = _light.Intensity;
        }
    }
}