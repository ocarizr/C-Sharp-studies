using AbstractFactory;
using AppBase;
using Decorator;
using FactoryMethod;
using Observer;
using Singleton;
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
            AbstractFactory,
            Singleton
        }

        public void Run()
        {
            GetApp(DPTypes.Singleton).Run();
        }

        IApp GetApp(DPTypes app) => app switch
        {
            DPTypes.Strategy => new StrategyApp(),
            DPTypes.Observer => new ObserverApp(),
            DPTypes.Decorator => new DecoratorApp(),
            DPTypes.FactoryMethod => new FactoryMethodApp(),
            DPTypes.AbstractFactory => new AbstractFactoryApp(),
            DPTypes.Singleton => new SingletonApp(),
            _ => throw new Exception("Invalid Design Pattern App")
        };
    }
}
