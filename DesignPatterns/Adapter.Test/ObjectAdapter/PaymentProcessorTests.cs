using Adapter.ObjectAdapter.Paypal;
using Adapter.ObjectAdapter.Stripe;
using Adapter.ObjectAdapter.Adapters;
using Adapter.ObjectAdapter;

namespace Adapter.Test;

public class PaymentProcessorTests
{
    [Fact]
    public void PayPalAdapter_ShouldProcessPayment()
    {
        var payPalPayment = new PayPalPayment();
        IPaymentProcessor payPalAdapter = new PayPalAdapter(payPalPayment);

        Assert.True(payPalAdapter.ProcessPayment(150.00m));
    }

    [Fact]
    public void StripeAdapter_ShouldProcessPayment()
    {
        var stripePayment = new StripePayment();
        IPaymentProcessor stripeAdapter = new StripeAdapter(stripePayment);

        Assert.True(stripeAdapter.ProcessPayment(250.00m));
    }
}