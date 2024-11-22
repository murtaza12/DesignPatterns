namespace Adapter.ObjectAdapter;

public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount);
}
