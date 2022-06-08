using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class FacebookDecorator : NotifierDecorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Send via facebook: {message}");
        }
    }
}