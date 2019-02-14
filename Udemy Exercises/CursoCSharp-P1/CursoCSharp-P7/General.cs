using System;

namespace CursoCSharp_P7
{
    class General
    {
        public void a()
        {
            Console.WriteLine("A");
        }

        public virtual void b()
        {
            Console.WriteLine("B");
        }

        public void Unique()
        {
            Console.WriteLine("This is Unique for the generalization.");
        }
    }
}
