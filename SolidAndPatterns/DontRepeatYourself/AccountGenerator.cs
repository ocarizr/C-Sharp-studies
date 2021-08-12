namespace DontRepeatYourself
{
    class AccountGenerator : AGenerator<string, IPerson>
    {
        private readonly DateTime startPoint = DateTime.Parse("01/01/2020");

        public override string Generate(IPerson user)
        {
            var firstSection = GetPartOfString(user.FirstName, 4).ToLower();
            var secondSection = GetPartOfString(user.LastName, 4).ToLower();
            var userUniqueID = CalculateUniqueId();
            return $"{firstSection}{secondSection}#{userUniqueID}";
        }

        private string GetPartOfString(string str, int amountOfCharacters)
        {
            if(str.Length > amountOfCharacters)
            {
                return str.Substring(0, amountOfCharacters);
            }

            return str;
        }

        private long CalculateUniqueId()
        {
            var baseValue = (DateTime.UtcNow - startPoint).TotalDays;
            var increment = (DateTime.UtcNow - DateTime.Today).TotalMilliseconds;
            return (long)(baseValue + increment);
        }
    }
}