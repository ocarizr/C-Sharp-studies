using System;

namespace CursoCSharp_P3
{
    class ArrayExerciseClass
    {
        public Rooms[] Room = new Rooms[10];
        
        public ArrayExerciseClass()
        {
            FillRooms();
        }

        private void FillRooms()
        {
            int ammountStudents = 0;
            while (ammountStudents < 1 || ammountStudents > 10)
            {
                Console.Write("How many students will rent the rooms? ");
                ammountStudents = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < ammountStudents; i++)
            {
                Console.Write("Name of Student: ");
                string name = Console.ReadLine();
                Console.Write("Email of student: ");
                string email = Console.ReadLine();
                bool empty = false;
                int selectedRoom = 0;

                while (!empty)
                {
                    Console.Write("Room Selected: ");
                    selectedRoom = int.Parse(Console.ReadLine()) - 1;
                    if (selectedRoom > 0 || selectedRoom < 11)
                    {
                        if (Room[selectedRoom] == null)
                        {
                            empty = true;
                        }
                        else
                        {
                            Console.WriteLine("The room already has someone.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This room doesn't exist.");
                    }

                }
                Room[selectedRoom] = new Rooms(name, email);
                Console.WriteLine();
            }

            ammountStudents = 0;
            for (int i = 0; i < Room.Length; i++)
            {
                if (Room[i] != null)
                {
                    Console.WriteLine("Rent #" + (ammountStudents + 1));
                    Console.WriteLine("Name: " + Room[i].Name);
                    Console.WriteLine("E-mail: " + Room[i].Email);
                    Console.WriteLine("Room: " + (i + 1));
                    Console.WriteLine();
                    ammountStudents++;
                }
            }

            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < Room.Length; i++)
            {
                if (Room[i] != null)
                {
                    Console.WriteLine((i+1) + ": " + Room[i].Name + ", " + Room[i].Email);
                }
            }
        }
    }
}
