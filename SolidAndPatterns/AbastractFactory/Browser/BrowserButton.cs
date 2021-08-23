namespace AbstractFactory
{
    class BrowserButton : IPlatformButton, IBrowserProperties
    {
        public string? Tag { get; set; }
        public string? Text { get; set; }

        public string? Name { get; set; }
        public bool Active { get; set; }

#pragma warning disable CS0067 // The event 'BrowserButton.onClick' is never used
        public event Action? onClick;
#pragma warning restore CS0067 // The event 'BrowserButton.onClick' is never used
    }
}