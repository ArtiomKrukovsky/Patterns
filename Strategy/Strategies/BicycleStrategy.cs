using Strategy.Interfaces;
using System;

namespace Strategy.Strategies
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class BicycleStrategy : IRouteStrategy
    {
        private const decimal Spead = 15.0m;

        public void GetRoute(decimal distance)
        {
           var duration = distance / Spead;
           Console.WriteLine($"Time to the destination by bicycle: {duration}h");
        }
    }
}
