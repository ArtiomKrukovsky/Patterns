using System.Collections.Generic;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    public class OperationFactory
    {
        private readonly Dictionary<OperationType, IOperation> _operations;

        public OperationFactory()
        {
            _operations = new Dictionary<OperationType, IOperation>
            {
                { OperationType.Income, new IncomeOperation() },
                { OperationType.Loss, new LossOperation() }
            };
        }

        public IOperation GetOperator(OperationType type)
        {
            return _operations[type];
        }
    }
}