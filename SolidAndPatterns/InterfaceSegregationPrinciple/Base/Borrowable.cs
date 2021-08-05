using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    abstract class Borrowable : IBorrowable
    {
        public string? Borrower { get; set; }
        public DateTime? BorrowDate { get; set; }
        public int CheckOutDurationInDay { get; set; }

        public void CheckIn()
        {
            Borrower = string.Empty;
            BorrowDate = DateTime.MaxValue;
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Today;
        }

        public DateTime GetDueDate()
        {
            if (BorrowDate.HasValue && BorrowDate <= DateTime.Today)
            {
                var dueDate = BorrowDate.Value;
                dueDate.AddDays(CheckOutDurationInDay);
                return dueDate;
            }

            return DateTime.MinValue;
        }
    }
}
