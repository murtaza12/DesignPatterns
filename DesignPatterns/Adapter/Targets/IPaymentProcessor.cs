namespace Adapter;

internal interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount);
}
