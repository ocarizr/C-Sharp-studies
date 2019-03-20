namespace CursoCSharp_P13.Entities
{
    class Employee
    {
        public string Name { get;}
        public int Hours { get;}
        public double ValuePerHour { get;}

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"{Name} - ${Payment():F2}";
        }
    }
}
