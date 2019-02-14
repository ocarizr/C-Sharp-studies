using System;

namespace CursoCSharp_P7
{
    class Exp : General
    {
        new public void a()
        {
            Console.WriteLine("C");
        }

        public override void b()
        {
            Console.WriteLine("D");
        }

        private void c()
        {
            Console.WriteLine("E");
        }

        public void d()
        {
            c();
        }
    }
}
