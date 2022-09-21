using Strategy.Context;
using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var distance = 25.5m;

            var navigator = new Navigator(new BicycleStrategy(), distance);
            navigator.GetRoute();

            navigator.SetStrategy(new CarStrategy());
            navigator.GetRoute();

            navigator.SetStrategy(new FootStrategy());
            navigator.GetRoute();
        }
    }
}
