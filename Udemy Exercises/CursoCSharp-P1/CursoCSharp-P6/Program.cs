using System;
using System.Globalization;

namespace CursoCSharp_P6
{
    class Program
    {
        static void Main(string[] args)
        {/*
            VarLesson();

            SwitchLesson();

            Console.WriteLine("----------------------------------------");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            TernaryConditional(a, b);

            Console.WriteLine("----------------------------------------");

            StringOp();

            Console.WriteLine("----------------------------------------");
            
            DateTimeLesson();

            Console.WriteLine("----------------------------------------");
            
            TimeSpanLesson();

            Console.WriteLine("----------------------------------------");
            */
            DateTimePropertiesLesson();
        }

        public static void VarLesson()
        {
            // avoid using var for this situations
            var x = 10;
            var y = 20.0;
            var z = "Hello String";
            var a = 'M';
            var b = false;
            var c = 10.0f;

            // It creates the variables with the correct types as below but it opens space for error the compiler will not accuse
            int _x = x;
            double _y = y;
            string _z = z;
            char _a = a;
            bool _b = b;
            float _c = c;

            // If want to use var then use it for this kind of situations only
            var p = new Program();
        }

        public static void SwitchLesson()
        {
            int day = int.Parse(Console.ReadLine());
            string message;
            switch(day)
            {
                case 0:
                    message = "Sunday";
                    break;
                case 1:
                    message = "Monday";
                    break;
                case 2:
                    message = "Tuesday";
                    break;
                case 3:
                    message = "Wednesday";
                    break;
                case 4:
                    message = "Thursday";
                    break;
                case 5:
                    message = "Friday";
                    break;
                case 6:
                    message = "Saturday";
                    break;
                default:
                    message = "Invalid value.";
                    break;
            }
            Console.WriteLine(message);
        }

        public static void TernaryConditional(int a, int b)
        {
            int score = (a >= b) ? 100 : 0;
            string name = (a < b) ? "John" : "Maria";

            Console.WriteLine(score);
            Console.WriteLine(name);
        }

        public static void StringOp()
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); // Convert every char to Uppercase
            string s2 = original.ToLower(); // Convert every char to lowercase
            string s3 = original.Trim(); // Remove blank spaces before and after any character

            int n1 = original.IndexOf("bc"); // Return the index of the first char of the selected string
            int n2 = original.LastIndexOf("bc"); // Return the index of the first char of the selected string on it's last show on the text

            string s4 = original.Substring(6);
            string s5 = original.Substring(16, 3);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xyz");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("-" + original + "- -> -" + s1 + "-");
            Console.WriteLine("-" + original + "- -> -" + s2 + "-");
            Console.WriteLine("-" + original + "- -> -" + s3 + "-");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }

        public static void DateTimeLesson()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2019, 2, 11);
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.UtcNow;

            DateTime d5 = DateTime.Parse("10/02/2019");
            DateTime d6 = DateTime.Parse("12-02-2019");
            DateTime d7 = DateTime.Parse("13-fev-19");
            DateTime d8 = DateTime.Parse("14/may/19 14:35");

            DateTime d9 = DateTime.ParseExact("05-2000-12", "dd-yyyy-MM", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.ToString("dd/MM/y"));
            Console.WriteLine(d1.ToString("dd/MMM/y"));
            Console.WriteLine(d1.ToString("dd/MMMM/yyyy"));
            Console.WriteLine(d1.Date);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
        }

        public static void TimeSpanLesson()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(120000000L);
            TimeSpan t4 = new TimeSpan(1, 12, 0, 55);
            TimeSpan t5 = new TimeSpan(1, 10, 2, 11, 500);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(0.45);
            TimeSpan t8 = TimeSpan.FromSeconds(55.7);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
        }

        public static void DateTimePropertiesLesson()
        {
            DateTime d1 = DateTime.Now;

            int day = d1.Day;
            int month = d1.Month;
            int year = d1.Year;
            DayOfWeek dayOfWeek = d1.DayOfWeek;
            int hour = d1.Hour;

            Console.WriteLine(d1);
            Console.WriteLine(day);
            Console.WriteLine(month);
            Console.WriteLine(year);
            Console.WriteLine(dayOfWeek);
            Console.WriteLine(hour);
            Console.WriteLine(d1.Date);
            Console.WriteLine(d1.DayOfYear);
            Console.WriteLine(d1.AddDays(1));
            Console.WriteLine(d1.TimeOfDay);
            Console.WriteLine(d1.ToLongDateString());
        }
    }
}
