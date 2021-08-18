namespace SingleResponsibilityPrinciple
{
    class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override string ToString()
        {
            if (FirstName is null || LastName is null)
            {
                return string.Empty;
            }

            return $"{FirstName} {LastName}";
        }
    }
}
