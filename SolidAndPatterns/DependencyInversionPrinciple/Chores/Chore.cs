namespace DependencyInversionPrinciple
{
    class Chore : IChore
    {
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        private ILogger _logger;
        private IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; } = 0;
        public bool IsComplete { get; set; } = false;

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