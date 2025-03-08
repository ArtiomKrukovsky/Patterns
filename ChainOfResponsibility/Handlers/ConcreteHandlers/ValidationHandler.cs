using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.ConcreteHandlers
{
    internal class ValidationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Validation handler processing");
        }
    }
}
