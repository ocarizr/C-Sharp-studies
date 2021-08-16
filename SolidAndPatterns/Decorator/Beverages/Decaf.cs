namespace Decorator
{
    class Decaf : Beverage
    {
        public override decimal Cost() => 3M;
        public override string Description() => "Decaf";
    }
}