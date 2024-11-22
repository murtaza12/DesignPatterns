namespace Adapter.ObjectAdapter.Stripe;

public class StripePayment
{
    public bool Charge(decimal amount)
    {
        Console.WriteLine($"Stripe charged ${amount}");
        return true;
    }
}
