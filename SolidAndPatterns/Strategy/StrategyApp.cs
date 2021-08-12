namespace Strategy
{
    public class StrategyApp
    {
        public void Run()
        {
            var walk = new MoveBehaviour();
            var eat = new EatBehaviour();
            var sleep = new SleepBehaviour();
            var fly = new FlyBehaviour();

            IWalkingAnimal slowDog = new Dog(walk, sleep, eat);
            slowDog.Walk.Execute();
            slowDog.Eat.Execute();
            slowDog.Sleep.Execute();

            IFlyingAnimal duck = new FlyingDuck(fly, sleep, eat);
            duck.Fly.Execute();
            duck.Eat.Execute();
            duck.Sleep.Execute();
        }
    }
}
