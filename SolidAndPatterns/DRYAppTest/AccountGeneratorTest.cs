using DontRepeatYourself;
using Xunit;

namespace DRYAppTest;
public class AccountGeneratorTest
{
    [Theory]
    [InlineData("Rafael", "Ocariz", "rafaocar")]
    [InlineData("Tim", "Burton", "timburt")]
    [InlineData("Jo", "Soarez", "josoar")]
    [InlineData("Chi", "Tzu", "chitzu")]
    [InlineData("Nana", "", "nana")]
    [InlineData("", "nana", "nana")]
    [InlineData("", "", "")]
    public void GenerateAccountTest(string firstName, string lastName, string expectedAccountPrefix)
    {
        var generator = new AccountGenerator();

        var obtained = generator.Generate(new Person { FirstName = firstName, LastName = lastName });
        var sections = obtained.Split("#");
        Assert.Equal(0, string.Compare(sections[0], expectedAccountPrefix));
    }
}