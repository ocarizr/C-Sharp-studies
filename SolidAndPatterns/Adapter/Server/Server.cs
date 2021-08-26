using System.Net;

namespace Adapter
{
    class Server
    {
        private IPAddress _ip;
        private string _name;

        public bool IsInitialized { get; set; }

        public bool Init(string name, string ipAddress)
        {
            _name = name;
            IsInitialized = IPResolver.ResolveIP(ipAddress, ref _ip);
            return IsInitialized;
        }

        public bool Send(IPAddress destination, byte[] data)
        {
            Console.WriteLine($"[{_name}] Send {data.Length} bytes of data to {destination}");
            return true;
        }
    }
}