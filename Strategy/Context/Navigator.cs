using Strategy.Interfaces;

namespace Strategy.Context
{
    public class Navigator
    {
        private IRouteStrategy _strategy;

        private decimal _distance;

        private Navigator() { }

        public Navigator(IRouteStrategy strategy, decimal distance)
        {
            SetDistance(distance);
            SetStrategy(strategy);
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetDistance(decimal distance)
        {
            _distance = distance;
        }

        public void GetRoute()
        {
            _strategy.GetRoute(_distance);
        }
    }
}
