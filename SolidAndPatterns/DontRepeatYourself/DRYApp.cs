using AppBase;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DRYAppTest")]
namespace DontRepeatYourself
{
    public class DRYApp : IApp
    {
        public void Run()
        {
            var user = new Person
            {
                FirstName = "Tim",
                LastName = "Burton"
            };

            var generator = new AccountGenerator();
            string userAccount = generator.Generate(user);

            Console.WriteLine($"User {user} account is {userAccount}.");
        }
    }
}
