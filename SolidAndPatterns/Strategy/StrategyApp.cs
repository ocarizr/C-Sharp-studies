using AppBase;

namespace Strategy
{
    public class StrategyApp : IApp
    {
        public void Run()
        {
            var walk = new MoveBehaviour();
            var eat = new EatBehaviour();
            var sleep = new SleepBehaviour();
            var fly = new FlyBehaviour();

            IWalkingAnimal slowDog = new Dog(walk, sleep, eat);
            slowDog.Walk();
            slowDog.Eat();
            slowDog.Sleep();

            IFlyingAnimal duck = new FlyingDuck(fly, sleep, eat);
            duck.Fly();
            duck.Eat();
            duck.Sleep();
        }
    }
}
