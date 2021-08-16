namespace Decorator
{
    class ExtraEspresso : Addon
    {
        public ExtraEspresso(Beverage beverage)
            : base(beverage, "Extra Espresso", 0.5M)
        { }
    }
}
