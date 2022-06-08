using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class LossOperation : IOperation
    {
        public decimal Calculate(decimal balance, decimal income)
        {
            return balance - income;
        }
    }
}