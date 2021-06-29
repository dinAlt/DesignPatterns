using System;
using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
  class Checkout
  {
    readonly List<IPaymentMethod> _paymentMethods;

    public Checkout(params IPaymentMethod[] paymentMethods) =>
      _paymentMethods = new(paymentMethods);

    public void HandlePayment(int amount, int paymentNumber)
    {
      if (paymentNumber < 0 || paymentNumber > _paymentMethods.Count - 1)
      {
        throw new ArgumentOutOfRangeException(nameof(paymentNumber),
          $"Payment method with number {paymentNumber} is not registered");
      }

      _paymentMethods[paymentNumber].MakePayment(amount);
    }
  }
}