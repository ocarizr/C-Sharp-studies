using System.Globalization;

namespace CursoCSharp_P1
{
    class ConstructorExercise
    {
        public string Name;
        public int Age;
        public float Height;
        public char Gender;

        // Standard Constructor
        public ConstructorExercise() { }

        // First Constructor
        public ConstructorExercise(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        // Second Constructor
        public ConstructorExercise(string name, int age, float height, char gender) : this(name, age, gender)
        {
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name} is a {(Gender == 'F' ? "female" : "male")}" +
                $", {(Gender == 'F' ? "she" : "he")} is {Age} years old" +
                $"{(Height == 0 ? "." : $" and has {Height.ToString("F2", CultureInfo.InvariantCulture)} meters of height.")}";
        }
    }
}
