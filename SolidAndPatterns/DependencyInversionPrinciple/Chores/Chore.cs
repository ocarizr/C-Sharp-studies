namespace DependencyInversionPrinciple
{
    class Chore : IChore
    {
#pragma warning disable CS8618 // Non-nullable property 'ChoreName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Owner' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public Chore(ILogger logger, IMessageSender messageSender)
#pragma warning restore CS8618 // Non-nullable property 'Owner' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning restore CS8618 // Non-nullable property 'ChoreName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        private ILogger _logger;
        private IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; } = 0;
        public bool IsComplete { get; private set; } = false;

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"{ChoreName} chore is completed");
            _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is complete");
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }
    }
}