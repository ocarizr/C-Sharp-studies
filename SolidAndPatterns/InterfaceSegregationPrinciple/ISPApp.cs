using AppBase;

namespace InterfaceSegregationPrinciple
{
    public class ISPApp : IApp
    {
        public void Run()
        {
            var books = new List<IBook>
            {
                new FantasyBook(),
                new AudioBook(),
                new ReferenceBook()
            };

            foreach (var book in books)
            {
                if (book is IBorrowable borrowed)
                {
                    borrowed.CheckOut("Rafael");
                }
            }

            Console.ReadLine();
        }
    }
}
