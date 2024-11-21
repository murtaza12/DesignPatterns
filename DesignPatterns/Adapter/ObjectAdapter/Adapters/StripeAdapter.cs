using Adapter.ObjectAdapter.Stripe;

namespace Adapter.ObjectAdapter.Adapters;

public class StripeAdapter : IPaymentProcessor
{
    private readonly StripePayment _stripePayment;

    public StripeAdapter(StripePayment stripePayment)
    {
        _stripePayment = stripePayment;
    }

    public bool ProcessPayment(decimal amount)
    {
        return _stripePayment.Charge(amount);
    }
}
