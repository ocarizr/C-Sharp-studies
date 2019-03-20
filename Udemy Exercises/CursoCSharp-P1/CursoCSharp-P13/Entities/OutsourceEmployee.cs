namespace CursoCSharp_P13.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get;}

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1f;
        }
    }
}
