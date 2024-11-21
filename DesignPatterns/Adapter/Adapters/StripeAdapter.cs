using Adapter.Stripe;

namespace Adapter.Adapters;

internal class StripeAdapter
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
