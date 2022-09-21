using Strategy.Interfaces;
using System;

namespace Strategy.Strategies
{
    internal class FootStrategy : IRouteStrategy
    {
        private const decimal Spead = 5.0m;

        public void GetRoute(decimal distance)
        {
            var duration = distance / Spead;
            Console.WriteLine($"Time to the destination on foot: {duration}h");
        }
    }
}
