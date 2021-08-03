namespace SingleResponsibilityPrinciple
{
    class PersonValidator
    {
        public static bool IsValid(Person person)
        {
            var standardMessages = new StandardMessages();
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                standardMessages.InvalidInput("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                standardMessages.InvalidInput("last name");
                return false;
            }

            return true;
        }
    }
}
