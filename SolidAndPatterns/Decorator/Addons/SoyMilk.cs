namespace Decorator
{
    class SoyMilk : Addon
    {
        public SoyMilk(Beverage beverage)
            : base(beverage, "Soy Milk", 1.25M)
        { }
    }
}
