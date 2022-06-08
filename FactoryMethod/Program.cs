using System;
using FactoryMethod.Enums;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const decimal balance = 10000.0m;
            const decimal operationAmount = 500.0m;

            var factory = new OperationFactory();
            var @operator = factory.GetOperator(OperationType.Income);

            var calculation = @operator.Calculate(balance, operationAmount);
            Console.WriteLine(calculation);
        }
    }
}
