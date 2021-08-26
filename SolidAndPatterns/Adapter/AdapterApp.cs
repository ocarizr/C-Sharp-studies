using AppBase;

namespace Adapter
{
    public class AdapterApp : IApp
    {
        public void Run()
        {

            var server = new Server();
            if (server.Init("STUN", "127.0.0.1"))
            {
                var client = new Client(new ClientTarget(server));

                for (int i = 0; i < 5; i++)
                {
                    client.pump();
                }
            }
        }
    }
}
