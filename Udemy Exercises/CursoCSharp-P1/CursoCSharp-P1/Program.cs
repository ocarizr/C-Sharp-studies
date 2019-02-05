using System;
using System.Globalization;

namespace CursoCSharp_P1
{
    class Program
    {
        public void WaitAndClear()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public void WriteLineLesson()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.5;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public void ReadLineLesson()
        {
            Console.WriteLine("Entre com seu nome completo");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] personalData = Console.ReadLine().Split(' ');

            string personalLastName = personalData[0];
            int personalAge = int.Parse(personalData[1]);
            float personalHeight = float.Parse(personalData[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(idade);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(personalLastName);
            Console.WriteLine(personalAge);
            Console.WriteLine(personalHeight.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void FunctionLesson()
        {
            Console.WriteLine("Digite três números:");
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maior = {Maior(a, b, c)}");
        }
        
        public int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static void Main(string[] args)
        {
            var p = new Program();
            var c = new ClassExercise();
            
            p.WriteLineLesson();

            p.WaitAndClear();

            p.ReadLineLesson();

            p.WaitAndClear();
            
            p.FunctionLesson();

            p.WaitAndClear();
            
            c.MinorThanTen(9);
            Console.WriteLine(c);
            c.MinorThanTen(11);
            Console.WriteLine(c);
            c.Greater(1, 2);
            Console.WriteLine(c);
            c.Greater(2, 1);
            Console.WriteLine(c);

            c.ConditionResult = ClassExercise.InvertResult(c.ConditionResult);
            Console.WriteLine(c);

            p.WaitAndClear();
            
            // Test first constructor
            ConstructorExercise ce = new ConstructorExercise("Giovanna", 20, 1.55f, 'F');
            Console.WriteLine(ce);

            // Test Second Constructor
            ConstructorExercise ce2 = new ConstructorExercise("Rafael", 28, 'M');
            Console.WriteLine(ce2);

            // Test Alternative Instantiation method
            ConstructorExercise ce3 = new ConstructorExercise
            {
                Name = "Flávio Jr.",
                Age = 14,
                Gender = 'M',
                Height = 1.7f
            };
            Console.WriteLine(ce3);

            // Test standard constructor with data attribuition
            ConstructorExercise ce4 = new ConstructorExercise();
            ce4.Name = Console.ReadLine();
            ce4.Age = int.Parse(Console.ReadLine());
            ce4.Gender = char.Parse(Console.ReadLine());
            ce4.Height = float.Parse(Console.ReadLine());
            Console.WriteLine(ce4);
        }
    }
}
