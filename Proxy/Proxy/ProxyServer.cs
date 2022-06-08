using System;
using System.Collections.Generic;
using Proxy.Dtos;
using Proxy.Interfaces;
using Proxy.Server;

namespace Proxy.Proxy
{
    public class ProxyServer : IServer
    {
        private readonly Dictionary<Guid, UserDto> _cachedUsers;
        private readonly RealServer _server;

        public ProxyServer()
        {
            _cachedUsers = new Dictionary<Guid, UserDto>();
            _server = new RealServer();
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public UserDto GetUser(Guid id)
        {
            if (_cachedUsers.ContainsKey(id))
            {
                Console.WriteLine($"CacheProxy<GetUser>: [PROXY-FETCH]  Key: {id}, Value: {_cachedUsers[id]}");
                return _cachedUsers[id];
            }

            var user = _server.GetUser(id);

            if (user == null)
            {
                throw new ArgumentNullException($"User doesn't exist, id: '{id}'");
            }

            _cachedUsers.Add(id, user);
            Console.WriteLine($"CacheProxy<GetValue>: [PROXY-UPDATED] Key: {id}, Value: {_cachedUsers[id]}");

            return user;
        }
    }
}