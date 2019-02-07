namespace CursoCSharp_P3
{
    class Rooms
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Rooms(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
