namespace SingleResponsibilityPrinciple
{
    ref struct StandardMessages
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to my Application");
        }

        public void Goodbye()
        {
            Console.WriteLine("Goodbye and See you!");
            Console.ReadLine();
        }

        public void InvalidInput(string inputName)
        {
            Console.WriteLine($"Invalid {inputName}.");
        }
    }
}
