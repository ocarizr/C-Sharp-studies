using System;

namespace CursoCSharp_P11.Entities
{
    class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime birthDate { get; private set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} ({birthDate.ToShortDateString()}) - {Email}";
        }
    }
}
