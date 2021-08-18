namespace DependencyInversionPrinciple
{
    class Texter : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"Texting {owner.FirstName} to notify: {message}.");
        }
    }
}
