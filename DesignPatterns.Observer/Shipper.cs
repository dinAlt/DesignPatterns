using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
  using GoodsReminder = Dictionary<string, int>;

  class Shipper : IObserver<GoodsReminder>
  {
    readonly IObservable<GoodsReminder> _observable;

    public Shipper(IObservable<GoodsReminder> observable)
    {
      observable.Register(this);
      _observable = observable;
    }

    public void Update(GoodsReminder value)
    {
      foreach (var entry in value)
      {
        if (entry.Value < 1)
        {
          Console.WriteLine($"[Shipper] {entry.Key[..1].ToUpper() + entry.Key[1..]} is" +
          " out of stock, we need to ship some.");
        }
      }
    }

    public void Leave()
    {
      Console.WriteLine("[Shipper] I'm no longer shipping goods here.");
      _observable.Unregister(this);
    }
  }
}