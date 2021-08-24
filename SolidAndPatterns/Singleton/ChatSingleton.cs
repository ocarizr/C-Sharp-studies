namespace Singleton
{
    class ChatSingleton
    {
        private static ChatSingleton _instance;
        public static ChatSingleton Instance => _instance ??= new ChatSingleton();

        private ChatSingleton() { }

        public void Print(string message)
        {
            Console.WriteLine($"Print: {message}");
        }
    }
}
