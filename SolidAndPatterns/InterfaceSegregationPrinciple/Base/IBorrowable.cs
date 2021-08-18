namespace InterfaceSegregationPrinciple
{
    interface IBorrowable
    {
        string? Borrower { get; set; }
        DateTime? BorrowDate { get; set; }
        int CheckOutDurationInDay { get; set; }
        void CheckOut(string borrower);
        void CheckIn();
        DateTime GetDueDate();
    }
}
