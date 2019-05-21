using System;
using System.Collections.Generic;
using System.Linq;
using CursoCSharp_P15.Entities;
using CursoCSharp_P15.Entities.Exceptions;

namespace CursoCSharp_P15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reservation> reservations = new List<Reservation>();

            Console.Write("Enter the number of reservations: ");
            int amountOfReservations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amountOfReservations; i++)
            {
                try
                {
                    Console.WriteLine($"Reservation #{i}");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Room: ");
                    int room = int.Parse(Console.ReadLine());
                    Console.Write("Check-in date: ");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("check-out date: ");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());
                    Reservation reservation = new Reservation(name, room, checkIn, checkOut);

                    reservations.Add(reservation);

                    Console.Write("Want to update the reservation dates? (y/n): ");
                    char option = char.Parse(Console.ReadLine());

                    if (option == 'y')
                    {
                        Console.WriteLine("Enter the new dates:");
                        Console.Write("New check-in: ");
                        checkIn = DateTime.Parse(Console.ReadLine());
                        checkOut = DateTime.Parse(Console.ReadLine());

                        reservations.Remove(reservation);

                        reservation.UpdateDates(checkIn, checkOut);

                        reservations.Add(reservation);
                    }
                }
                catch (DomainException e)
                {
                    Console.WriteLine($"Error in reservation: {e.Message}.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Error on Input: {e.Message}.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unexpected error: {e.Message}.");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Reservations:");

            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
