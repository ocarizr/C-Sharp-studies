namespace InterfaceSegregationPrinciple
{
    class AudioBook : Borrowable, IBorrowableAudioBook
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PlayTimeInMinutes { get; set; }
    }
}
