namespace AbstractFactory
{
    class BrowserTextField : IPlatformTextField, IBrowserProperties
    {
        public string? Tag { get; set; }
        public string? Text { get; set; }
        public string? Name { get; set; }

#pragma warning disable CS0067 // The event 'BrowserTextField.OnUpdate' is never used
        public event Action? OnUpdate;
#pragma warning restore CS0067 // The event 'BrowserTextField.OnUpdate' is never used
    }
}