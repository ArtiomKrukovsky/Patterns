using System;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class Notifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send via email: {message}");
        }
    }
}