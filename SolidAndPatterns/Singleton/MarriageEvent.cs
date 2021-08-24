namespace Singleton
{
    class MarriageEvent
    {
        public void Accept(IPerson personA, IPerson personB)
        {
            var chat = ChatSingleton.Instance;
            chat.Print($"{personA} accepts to marry {personB}");
            chat.Print($"{personB} also accepts to marry {personA}");
        }
    }
}