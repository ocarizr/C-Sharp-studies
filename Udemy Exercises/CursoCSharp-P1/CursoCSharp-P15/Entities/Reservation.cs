using System;
using CursoCSharp_P15.Entities.Exceptions;

namespace CursoCSharp_P15.Entities
{
    class Reservation
    {
        public string Name { get; }
        public int Room { get; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(string name, int room, DateTime checkIn, DateTime checkOut)
        {
            if (CheckForExceptions(checkIn, checkOut) != null)
                throw CheckForExceptions(checkIn, checkOut);

            Name = name;
            Room = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (CheckForExceptions(checkIn, checkOut) != null)
                throw CheckForExceptions(checkIn, checkOut);

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        private DomainException CheckForExceptions(DateTime checkIn, DateTime checkOut)
        {
            DateTime today = DateTime.Today;
            if (checkIn < today || checkOut < today) return new DomainException("Reservation dates MUST be on the future.");
            if (checkOut <= checkIn) return new DomainException("Check-out MUST be in a day after Check-in");
            return null;
        }

        public override string ToString()
        {
            return $"Reservation for {Name}, room no. {Room}, starts at {CheckIn.Date} and ends on {CheckOut.Date}, totalizing {Duration()} days.";
        }
    }
}
