namespace DependencyInversionPrinciple
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log data: {message}");
        }
    }
}