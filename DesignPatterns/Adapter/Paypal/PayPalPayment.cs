namespace Adapter.Paypal;

internal class PayPalPayment
{
    public string MakePayment(decimal amount)
    {
        return $"PayPal processed payment of ${amount}";
    }
}
