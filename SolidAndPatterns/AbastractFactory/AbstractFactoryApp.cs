using AppBase;

namespace AbstractFactory
{
    public class AbstractFactoryApp : IApp
    {
        public void Run()
        {
            var factory = new BrowserFactory();
            var button = factory.GetButton();
            var textfield = factory.GetTextField();

            button.onClick += () => Console.WriteLine((textfield as IBrowserProperties)!.Text);
        }
    }
}
