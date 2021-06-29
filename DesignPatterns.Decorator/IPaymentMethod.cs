using System;

namespace DesignPatterns.Decorator
{
  interface IPaymentMethod
  {
    string Name { get; }

    void MakePayment(int amount)
    {
      Console.WriteLine($"{GetType().Name}: Got payment ${amount} via {Name}");
    }
  }
}