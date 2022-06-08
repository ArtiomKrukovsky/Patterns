namespace FactoryMethod.Interfaces
{
    // the interface for a product
    public interface IOperation
    {
        decimal Calculate(decimal balance, decimal income);
    }
}