using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.ConcreteHandlers
{
    internal class AuthenticationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authentication handler processing");
        }
    }
}
