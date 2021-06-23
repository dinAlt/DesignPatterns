using System;

namespace DesignPatterns.Patterns.Strategy
{
  internal class DiscountsSender : ISender
  {
    public void Send(string customerName)
    {
      Console.WriteLine(
        $"Dear {customerName}! \nOur discounts will pleasantly surprise you!");
    }
  }
}