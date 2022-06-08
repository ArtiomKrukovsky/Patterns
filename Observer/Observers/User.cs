using System;
using Observer.Interfaces;

namespace Observer.Observers
{
    public class User : IObserver
    {
        public string UserName { get; private set; }

        public User(string userName)
        {
            UserName = userName;
        }

        public void Update()
        {
            Console.WriteLine("Hello " + UserName + ", Product is now available on Amazon");
        }
    }
}