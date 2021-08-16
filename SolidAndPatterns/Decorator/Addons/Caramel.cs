namespace Decorator
{
    class Caramel : Addon
    {
        public Caramel(Beverage beverage)
            : base(beverage, "Caramel", 1M)
        { }
    }
}
