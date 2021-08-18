namespace SingleResponsibilityPrinciple
{
    public class SRPApp
    {
        public void Run()
        {
            var standardMessages = new StandardMessages();
            standardMessages.Welcome();

            var personDataCapture = new PersonDataCapture();
            var user = personDataCapture.Capture();

            if (!PersonValidator.IsValid(user))
            {
                standardMessages.Goodbye();
                return;
            }

            var accountGenerator = new AccountGenerator();
            accountGenerator.GenerateUsername(user);

            standardMessages.Goodbye();
        }
    }
}
