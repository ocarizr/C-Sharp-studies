using AppBase;

namespace Decorator
{
    public class DecoratorApp : IApp
    {
        public void Run()
        {
            var decaf = new Decaf();
            Console.WriteLine($"{decaf.Description()} cost is ${decaf.Cost()}");

            var decafWithCaramel = new Caramel(decaf);
            Console.WriteLine($"{decafWithCaramel.Description()} cost is ${decafWithCaramel.Cost()}");

            var decafWithCaramelPlusSoyMilk = new SoyMilk(decafWithCaramel);
            Console.WriteLine($"{decafWithCaramelPlusSoyMilk.Description()} cost is ${decafWithCaramelPlusSoyMilk.Cost()}");

            var decafWithSoy = new SoyMilk(decaf);
            Console.WriteLine($"{decafWithSoy.Description()} cost is ${decafWithSoy.Cost()}");

            var espresso = new Espresso();
            Console.WriteLine($"{espresso.Description()} cost is ${espresso.Cost()}");

            var doubleEspresso = new ExtraEspresso(espresso);
            Console.WriteLine($"{doubleEspresso.Description()} cost is ${doubleEspresso.Cost()}");
        }
    }
}
