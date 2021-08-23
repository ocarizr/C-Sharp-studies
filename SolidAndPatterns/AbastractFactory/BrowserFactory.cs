namespace AbstractFactory
{
    struct BrowserFactory : IAbstractFactory
    {
        public IPlatformButton GetButton()
        {
            return new BrowserButton();
        }

        public IPlatformTextField GetTextField()
        {
            return new BrowserTextField();
        }
    }
}
