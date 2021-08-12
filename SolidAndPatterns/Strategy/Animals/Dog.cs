namespace Strategy
{
    class Dog : IWalkingAnimal
    {
        private IBehaviour _walk;
        private IBehaviour _sleep;
        private IBehaviour _eat;

        public Dog(
            IBehaviour walk, 
            IBehaviour sleep, 
            IBehaviour eat)
        {
            _walk = walk;
            _sleep = sleep;
            _eat = eat;
            Legs = 4;
        }

        public int Legs { get; }
        public IBehaviour Walk => _walk;
        public IBehaviour Sleep => _sleep;
        public IBehaviour Eat => _eat;
    }
}
