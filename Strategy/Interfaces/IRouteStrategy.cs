namespace Strategy.Interfaces
{
    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    public interface IRouteStrategy
    {
        void GetRoute(decimal distance);
    }
}
