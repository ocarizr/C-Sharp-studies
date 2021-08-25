using AppBase;

namespace Command
{
    public class CommandApp : IApp
    {
        public void Run()
        {
            var light = new Light
            {
                Intensity = 10,
                Type = LightType.Point,
                Range = 10
            };

            var controller = new LightController
            (
                new TurnLightOffCommand(light),
                new ReduceLightIntensityCommand(light),
                new IncreaseLightIntensityCommand(light)
            );

            controller.TurnOff();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
            controller.TurnOn();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
            controller.ReduceIntensity();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
            controller.TurnOff();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
            controller.TurnOn();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
            controller.IncreaseIntensity();
            Console.WriteLine($"Light Intensity: {light.Intensity}");
        }
    }
}
