namespace Decorator
{
    abstract class Addon : Beverage
    {
        private readonly decimal _cost;
        private readonly string _name;
        private readonly Beverage _beverage;

        public Addon(Beverage beverage, string name, decimal cost)
        {
            _cost = cost;
            _name = name;
            _beverage = beverage;
        }

        public override string Description() => $"{_beverage!.Description()} + {_name!}";
        public override decimal Cost() => _cost + _beverage!.Cost();
    }
}
