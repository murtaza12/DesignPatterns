namespace Adapter.ObjectAdapter.Paypal;

public class PayPalPayment
{
    public string MakePayment(decimal amount)
    {
        return $"PayPal processed payment of ${amount}";
    }
}
