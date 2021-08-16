namespace Decorator
{
    class Espresso : Beverage
    {
        public override decimal Cost() => 2.5M;
        public override string Description() => "Espresso";
    }
}