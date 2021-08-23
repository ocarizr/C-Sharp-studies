namespace AbstractFactory
{
    interface IPlatformButton
    {
        event Action? onClick;
        bool Active { get; set; }
        string? Name { get; set; }
    }
}