using System;
using Proxy.Proxy;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxyServer = new ProxyServer();

            var userId = Guid.Parse("d7e5eb04-6207-479b-a64c-646124b177e3");

            var firstUser = proxyServer.GetUser(userId); // the first call to get user
            var secondUser = proxyServer.GetUser(userId); // the second call to get already cached user

            Console.WriteLine($"User: {secondUser.Name}");
        }
    }
}
