using System;

namespace DesignPatterns.Strategy
{
  internal class NewGoodsSender : ISender
  {
    public void Send(string customerName)
    {
      Console.WriteLine(
        $"Hello {customerName}! \nCome and see our new goods!");
    }
  }
}