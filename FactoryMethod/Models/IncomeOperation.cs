using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class IncomeOperation : IOperation
    {
        public decimal Calculate(decimal balance, decimal income)
        {
            return balance + income;
        }
    }
}