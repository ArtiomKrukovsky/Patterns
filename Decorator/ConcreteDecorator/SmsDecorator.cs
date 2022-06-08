using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    public class SmsDecorator : NotifierDecorator
    {
        public SmsDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Send via sms: {message}");
        }
    }
}