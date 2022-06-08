using System;
using Observer.Enums;
using Observer.Observable;
using Observer.Observers;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product("IPhone X", 1000, ProductStatus.OutOfStock);
            var user = new User("Artsiom");

            product.Attach(user);

            product.SetInStockStatus();
        }
    }
}
