namespace AbstractFactory
{
    interface IPlatformTextField
    {
        string? Name { get; set; }
        event Action? OnUpdate;
    }
}