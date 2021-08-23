namespace AbstractFactory
{
    interface IAbstractFactory
    {
        IPlatformButton GetButton();
        IPlatformTextField GetTextField();
    }
}