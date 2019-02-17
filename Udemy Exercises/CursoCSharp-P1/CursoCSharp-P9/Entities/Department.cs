namespace CursoCSharp_P9.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
