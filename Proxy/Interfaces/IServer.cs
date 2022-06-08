using System;
using Proxy.Dtos;

namespace Proxy.Interfaces
{
    /// <summary>
    /// The Subject interface which both the RealSubject and proxy will need to implement
    /// </summary>
    public interface IServer
    {
        UserDto GetUser(Guid id);
    }
}