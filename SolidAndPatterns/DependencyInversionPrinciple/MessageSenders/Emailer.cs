using System;

namespace DependencyInversionPrinciple
{
    class Emailer : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"Send email to: {owner.Email}. Information: {message}.");
        }
    }
}