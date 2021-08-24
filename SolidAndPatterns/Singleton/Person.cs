namespace Singleton
{
    class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{FirstName} {LastName}, of age {Age}";
    }
}