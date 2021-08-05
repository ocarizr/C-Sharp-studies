using System;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    public class ISPApp
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
