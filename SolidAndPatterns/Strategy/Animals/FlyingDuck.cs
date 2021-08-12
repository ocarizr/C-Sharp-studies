namespace Strategy
{
    class FlyingDuck : IFlyingAnimal
    {
        private IBehaviour _fly;
        private IBehaviour _sleep;
        private IBehaviour _eat;

        public FlyingDuck(
            IBehaviour fly, 
            IBehaviour sleep, 
            IBehaviour eat)
        {
            _fly = fly;
            _sleep = sleep;
            _eat = eat;
        }

        public IBehaviour Fly => _fly;
        public IBehaviour Sleep => _sleep;
        public IBehaviour Eat => _eat;
    }
}
