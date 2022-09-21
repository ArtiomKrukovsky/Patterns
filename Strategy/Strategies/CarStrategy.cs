using Strategy.Interfaces;
using System;

namespace Strategy.Strategies
{
    public class CarStrategy : IRouteStrategy
    {
        private const decimal Spead = 45.0m;

        public void GetRoute(decimal distance)
        {
            var duration = distance / Spead;
            Console.WriteLine($"Time to the destination by car: {duration}h");
        }
    }
}
