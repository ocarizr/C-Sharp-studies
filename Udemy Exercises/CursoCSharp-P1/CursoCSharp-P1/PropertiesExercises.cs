using System.Globalization;

namespace CursoCSharp_P1
{
    class PropertiesExercises
    {
        private string _name;

        public PropertiesExercises(string name, int ammount, double price)
        {
            _name = name;
            Ammount = ammount;
            Price = price;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 2 && _name != null)
                {
                    _name = value;
                }
            }
        }
        public int Ammount { get; private set; }
        public double Price { get; private set; }

        public void AddAmmount(int addValue)
        {
            Ammount += addValue;
        }

        public void ReduceAmmount(int reduceValue)
        {
            Ammount -= reduceValue;
        }

        public override string ToString()
        {
            return $"{_name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", {Ammount}, value in stock is {(Price * Ammount).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
