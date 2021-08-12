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

        public void Eat() => _eat.Execute();
        public void Fly() => _fly.Execute();
        public void Sleep() => _sleep.Execute();
    }
}
