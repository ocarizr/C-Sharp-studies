using AppBase;

namespace Singleton
{
    public class SingletonApp : IApp
    {
        public void Run()
        {
            var personA = new Person
            {
                FirstName = "Giovanna",
                LastName = "Barbero",
                Age = 22
            };

            var personB = new Person
            {
                FirstName = "Rafael",
                LastName = "Ocariz",
                Age = 31
            };

            var @event = new MarriageEvent();
            @event.Accept(personA, personB);

            ChatSingleton.Instance.Print("The End!");
        }
    }
}
