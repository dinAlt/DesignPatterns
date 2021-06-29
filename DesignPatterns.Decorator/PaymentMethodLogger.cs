using System;

namespace DesignPatterns.Decorator
{
  class PaymentMethodLogger : IPaymentMethod
  {
    readonly IPaymentMethod _paymentMethod;

    public PaymentMethodLogger(IPaymentMethod paymentMethod) =>
      _paymentMethod = paymentMethod;

    public string Name => _paymentMethod.Name;

    public void MakePayment(int amount)
    {
      Console.WriteLine(
        $"[{DateTime.Now}] Incoming payment. Type: {_paymentMethod.Name}, amount: {amount}");
      _paymentMethod.MakePayment(amount);
    }
  }
}