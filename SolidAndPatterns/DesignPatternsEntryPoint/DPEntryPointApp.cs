using AppBase;
using AbstractFactory;
using Decorator;
using FactoryMethod;
using Observer;
using Strategy;

namespace DesignPatternsEntryPoint
{
    public class DPEntryPointApp : IApp
    {
        enum DPTypes
        {
            Strategy,
            Observer,
            Decorator,
            FactoryMethod,
            AbstractFactory
        }

        public void Run()
        {
            GetApp(DPTypes.AbstractFactory).Run();
        }

        IApp GetApp(DPTypes app) => app switch
        {
            DPTypes.Strategy => new StrategyApp(),
            DPTypes.Observer => new ObserverApp(),
            DPTypes.Decorator => new DecoratorApp(),
            DPTypes.FactoryMethod => new FactoryMethodApp(),
            DPTypes.AbstractFactory => new AbstractFactoryApp(),
            _ => throw new Exception("Invalid Design Pattern App")
        };
    }
}
