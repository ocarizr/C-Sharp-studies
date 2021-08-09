namespace DependencyInversionPrinciple
{
    static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
