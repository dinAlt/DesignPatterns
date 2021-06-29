using System;

namespace DesignPatterns.Decorator
{
  class Program
  {
    static void Main()
    {
      var checkout = new Checkout(
        new PaymentMethodLogger(new CardPaymentMethod()),
        new PaymentMethodLogger(new CachePaymentMethod()));

      checkout.HandlePayment(10, 0);
      checkout.HandlePayment(20, 1);
    }
  }
}
