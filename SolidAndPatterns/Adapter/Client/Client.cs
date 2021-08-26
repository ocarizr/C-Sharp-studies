using System.Net;

namespace Adapter
{
    class Client
    {
        private ITarget<int> _target;
        private Random _random;

        public Client(ITarget<int> target)
        {
            _target = target;
            _random = new Random(DateTime.Now.Millisecond);
        }

        public void pump()
        {
            IPAddress target = null;
            if (IPResolver.ResolveIP("www.google.com", ref target))
            {
                _target.Send(target, _random.Next());
            }
        }
    }
}