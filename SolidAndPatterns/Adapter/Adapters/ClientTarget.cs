using System.Net;

namespace Adapter
{
    class ClientTarget : ITarget<int>
    {
        private Server _server;

        public ClientTarget(Server server)
        {
            _server = server;
        }

        public bool Send(IPAddress destination, int data)
        {
            using (MemoryStream byteStream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(byteStream))
                {
                    writer.Write(data);
                }

                return _server.Send(destination, byteStream.ToArray());
            }
        }
    }
}