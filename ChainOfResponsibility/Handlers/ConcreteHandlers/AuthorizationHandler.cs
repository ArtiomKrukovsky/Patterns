using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.ConcreteHandlers
{
    internal class AuthorizationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authorization handler processing");
        }
    }
}
