using System;
using System.Collections.Generic;
using Observer.Enums;
using Observer.Interfaces;

namespace Observer.Observable
{
    public class Product : IObservable
    {
        private readonly List<IObserver> _observers = new();

        public string ProductName { get; private set; }
        public int ProductPrice { get; private set; }
        public ProductStatus ProductStatus { get; private set; }

        public Product(string productName, int productPrice, ProductStatus productStatus)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductStatus = productStatus;
        }

        public void SetInStockStatus()
        {
            ProductStatus = ProductStatus.InStock;
            Notify();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}