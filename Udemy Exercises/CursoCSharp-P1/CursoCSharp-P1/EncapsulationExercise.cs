using System;
using System.Globalization;

namespace CursoCSharp_P1
{
    class EncapsulationExercise
    {
        private string _name;
        private int _age;
        private double _budget;

        public EncapsulationExercise() { }

        public EncapsulationExercise(string name, int age, double budget)
        {
            _name = name;
            _age = age;
            _budget = budget;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (_name == null && name.Length > 2)
            {
                _name = name;
                return;
            }

            Console.WriteLine("The Input name is too short or the object already has a name.");
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public double GetBudget()
        {
            return _budget;
        }

        public void SetBudget(double budget)
        {
            if (_budget == 0)
            {
                _budget = budget;
                return;
            }

            Console.WriteLine("The budget already has some money, to add or reduce use the proper methods.");
        }

        public void AddBudget(double addValue)
        {
            _budget += addValue;
        }

        public void ReduceBudget(double reduceValue)
        {
            _budget -= reduceValue;
        }

        public override string ToString()
        {
            return $"{GetName()}, {GetAge()} and R${GetBudget().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
