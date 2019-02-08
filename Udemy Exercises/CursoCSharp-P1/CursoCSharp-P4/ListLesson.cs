using System;
using System.Collections.Generic;

namespace CursoCSharp_P4
{
    class ListLesson
    {
        public ListLesson()
        {
            ListExercise();
        }

        void ListExercise()
        {
            List<string> names = new List<string>();

            names.Add("Maria");
            names.Add("Alex");
            names.Add("Bob");
            names.Add("Ana");

            PrintListElements(names);

            names.Insert(2, "Marco");

            Console.WriteLine();
            PrintListElements(names);

            Console.WriteLine();
            Console.WriteLine("List size is " + names.Count);

            Console.WriteLine();
            FindInList(names, 'A');

            Console.WriteLine();
            FindIndex(names, 'A');

            Console.WriteLine();
            FilterList(names, 5);

            RemoveElements(names);

            names.Add("Maria");
            names.Add("Alex");
            names.Add("Bob");
            names.Add("Ana");

            names.RemoveRange(0, 2);
            Console.WriteLine();
            PrintListElements(names);

            names.Clear();
            if (names.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Empty List.");
            }
        }

        void PrintListElements(List<string> list)
        {
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }

        void FindInList(List<string> list, char firstChar)
        {
            Console.WriteLine($"First element of the list who begins with {firstChar}: {list.Find(x => x[0] == firstChar)}.");
            Console.WriteLine($"Last element of the list who begins with {firstChar}: {list.FindLast(x => x[0] == firstChar)}.");
        }

        void FindIndex(List<string> list, char firstChar)
        {
            Console.WriteLine($"The Index of the first element of the list who begins with {firstChar} is {list.FindIndex(x => x[0] == firstChar)}.");
            Console.WriteLine($"The Index of the last element of the list who begins with {firstChar} is {list.FindLastIndex(x => x[0] == firstChar)}.");
        }

        void FilterList(List<string> list, int stringSize)
        {
            List<string> filter = list.FindAll(x => x.Length == stringSize);

            PrintListElements(filter);
        }

        void RemoveElements(List<string> list)
        {
            list.Remove("Maria");
            Console.WriteLine();
            PrintListElements(list);

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine();
            PrintListElements(list);

            list.RemoveAt(0);
            Console.WriteLine();
            PrintListElements(list);
        }
    }
}
