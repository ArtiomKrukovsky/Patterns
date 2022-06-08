using System;
using Proxy.Dtos;
using Proxy.Interfaces;

namespace Proxy.Server
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data.
    public class RealServer : IServer
    {
        public UserDto GetUser(Guid id)
        {
            return new UserDto
            {
                Id = Guid.NewGuid(),
                Name = "System",
                Role = "Admin"
            };
        }
    }
}