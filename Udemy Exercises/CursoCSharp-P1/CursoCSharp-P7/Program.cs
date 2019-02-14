namespace CursoCSharp_P7
{
    class Program
    {
        static void Main(string[] args)
        {
            General g = new General();
            Exp e = new Exp(); // Can use all General, override and Exp specific methods
            General e2 = new Exp2(); // Can use override methods and General Methods but can't use Exp2 specific methods

            g.a();
            g.b();
            e.a();
            e.b();
            e.d(); // Exp specific method
            e2.a(); // When has no override execute the General Method
            e2.b(); // Another override with different function
            g.Unique(); // Can execute General Specific methods
            e.Unique();
            e2.Unique();
        }
    }
}
