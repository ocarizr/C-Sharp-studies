namespace DependencyInversionPrinciple
{
    interface IMessageSender
    {
        void SendMessage(IPerson owner, string message);
    }
}