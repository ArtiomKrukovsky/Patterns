using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            INotifier notifier = new Notifier();

            notifier = new SmsDecorator(notifier);
            notifier = new FacebookDecorator(notifier);
            notifier = new SlackDecorator(notifier);

            notifier.Send("Alert!");
        }
    }
}
