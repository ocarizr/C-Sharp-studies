using System.Net;

namespace Adapter
{
    struct IPResolver
    {
        public static bool ResolveIP(string ip, ref IPAddress address)
        {
            try
            {
                var heserver = Dns.GetHostEntry(ip);
                if (heserver is { } && heserver.AddressList.Length > 0)
                {
                    address = heserver.AddressList[0];
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[IPResolve] Exception: {e}");
            }

            return false;
        }
    }
}
