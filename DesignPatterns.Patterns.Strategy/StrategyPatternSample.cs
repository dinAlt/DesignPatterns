using System;

namespace DesignPatterns.Patterns.Strategy
{
  public class StrategyPatternSample : IPatternSample
  {
    public string Description => @"
    Strategy
    ========

    This pattern groups algorithm variants by their objectives and encapsulates them
    into interchangable entities (Behaviors).

    In C# (and other OOP languages with interfaces support) may be implemented as 
    interface, which describes the behavior, number of classes, implementing this
    interface and behavior holder class. 
    
    Holder class should contain member of behavior interface type, methods, which
    proxies to coresponding methods of the behavior and\or accessor, which allows
    to change the behavior member in runtime.
    
    Sample pattern implementation consists of:
      - Advertisement class as behavior holder (Advertisement.cs);
      - ISender interface as send behavior definition (ISender.cs);
      - NoopSender (NoopSender.cs), NewGoodsSender (NewGoodsSender.cs) and
        DiscountsSender (DiscountsSender.cs) classes as send behavior
        implementations.
    
    Usage example can be found in StrategyPatternSample.cs.
    ";

    public void Run()
    {
      var advertisement = new Advertisement();
      var customerName = "John Doe";
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
