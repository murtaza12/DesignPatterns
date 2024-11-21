using Adapter.Paypal;

namespace Adapter.Adapters;

internal class PayPalAdapter
{
    private readonly PayPalPayment _payPalPayment;

    public PayPalAdapter(PayPalPayment payPalPayment)
    {
        _payPalPayment = payPalPayment;
    }

    public bool ProcessPayment(decimal amount)
    {
        string result = _payPalPayment.MakePayment(amount);
        Console.WriteLine(result);
        return !string.IsNullOrEmpty(result);
    }
}
