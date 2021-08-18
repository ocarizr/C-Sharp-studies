using FactoryMethod;
using Xunit;

namespace FactoryMethodTest;
public class BalancedFactoryTest
{
    [Theory]
    [InlineData(99)]
    [InlineData(210)]
    [InlineData(300)]
    [InlineData(333)]
    [InlineData(600)]
    [InlineData(666)]
    [InlineData(999)]
    public void CreateBalancedAmount(int amount)
    {
        List<IAnimal> animals = new List<IAnimal>();
        var factory = new BalancedFactory(animals);
        for (int i = 0; i < amount; i++)
        {
            animals.Add(factory.CreateAnimal());
        }

        var dogs = animals.FindAll(a => a is Dog).Count;
        var cats = animals.FindAll(a => a is Cat).Count;
        var ducks = animals.FindAll(a => a is Duck).Count;

        Assert.Equal(dogs, cats);
        Assert.Equal(cats, ducks);
    }
}