using AbstractFactory;
using AppBase;
using Command;
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
            Singleton,
            Command
        }

        public void Run()
        {
            GetApp(DPTypes.Command).Run();
        }

        IApp GetApp(DPTypes app) => app switch
        {
            DPTypes.Strategy => new StrategyApp(),
            DPTypes.Observer => new ObserverApp(),
            DPTypes.Decorator => new DecoratorApp(),
            DPTypes.FactoryMethod => new FactoryMethodApp(),
            DPTypes.AbstractFactory => new AbstractFactoryApp(),
            DPTypes.Singleton => new SingletonApp(),
            DPTypes.Command => new CommandApp(),
            _ => throw new Exception("Invalid Design Pattern App")
        };
    }
}
