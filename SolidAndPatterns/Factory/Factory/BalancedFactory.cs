namespace FactoryMethod
{
    struct BalancedFactory : IAnimalFactory
    {
        private List<IAnimal> _animals;

        public BalancedFactory(List<IAnimal> animalMap)
        {
            _animals = animalMap;
        }

        public IAnimal CreateAnimal()
        {
            var dogs = _animals.FindAll(a => a is Dog).Count;
            var cats = _animals.FindAll(a => a is Cat).Count;
            var ducks = _animals.FindAll(a => a is Duck).Count;

            if (dogs > cats)
            {
                return dogs > ducks ? new Duck() : new Cat();
            }

            return new Dog();
        }
    }
}
