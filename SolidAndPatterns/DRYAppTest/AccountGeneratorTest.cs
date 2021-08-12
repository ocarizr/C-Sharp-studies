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
    [InlineData("", "Nana", "nana")]
    [InlineData("", "", "")]
    public void GenerateAccountTest(string firstName, string lastName, string expectedAccountPrefix)
    {
        // Orchestrate
        var generator = new AccountGenerator();

        // Act
        var obtained = generator.Generate(new Person { FirstName = firstName, LastName = lastName });
        var sections = obtained.Split("#");

        // Assert
        Assert.Equal(0, string.Compare(sections[0], expectedAccountPrefix));
    }
}