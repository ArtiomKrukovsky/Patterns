using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public abstract class RequestHandlerBase : IRequestHandler
    {
        private IRequestHandler? _nextHandler;

        public void SetNextHandler(IRequestHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Request request)
        {
            ProcessRequest(request);

            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }

        protected abstract void ProcessRequest(Request request);
    }
}
