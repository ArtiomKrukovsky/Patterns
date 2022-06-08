using Decorator.Component;

namespace Decorator.Decorator
{
    public class NotifierDecorator : INotifier
    {
        private readonly INotifier _notifier;

        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}