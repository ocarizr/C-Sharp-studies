using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FactoryMethodTest")]
namespace FactoryMethod
{
    public class FactoryMethodApp
    {
        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();
            var factory = new BalancedFactory(animals);
            for (int i = 0; i < 999; i++)
            {
                animals.Add(factory.CreateAnimal());
            }

            var dogs = animals.FindAll(a => a is Dog).Count;
            var cats = animals.FindAll(a => a is Cat).Count;
            var ducks = animals.FindAll(a => a is Duck).Count;

            Console.WriteLine($"We now have {dogs} dogs, {cats} cats and {ducks} ducks");
        }
    }
}
