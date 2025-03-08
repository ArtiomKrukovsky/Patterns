using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Interfaces
{
    // Handler interface
    public interface IRequestHandler
    {
        void SetNextHandler(IRequestHandler handler);
        void HandleRequest(Request request);
    }
}
