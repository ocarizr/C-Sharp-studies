using System.Net;

namespace Adapter
{
    interface ITarget<T>
    {
        bool Send(IPAddress destination, T data);
    }
}
