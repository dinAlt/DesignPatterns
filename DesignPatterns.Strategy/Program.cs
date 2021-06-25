using System;

namespace DesignPatterns.Strategy
{
  class Program
  {
    public static void Main()
    {
      var advertisement = new Advertisement();
      var customerName = "Tom";
      // Nothing happens here, because we have NoopSender as ISender implementation,
      // assigned to Advertisement.Sender in the constructor.
      advertisement.PerformSend(customerName);

      foreach (var sender in new ISender[] { new NewGoodsSender(), new DiscountsSender() })
      {
        Console.WriteLine($"Changing sender to {sender.GetType().Name}.");
        advertisement.Sender = sender;
        Console.WriteLine("Sending advertisement:");
        advertisement.PerformSend(customerName);
        Console.WriteLine("=====================");
      }
    }
  }
}
