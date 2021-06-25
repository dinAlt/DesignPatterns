using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
  using GoodsReminder = Dictionary<string, int>;

  class Buyer : IObserver<GoodsReminder>
  {
    GoodsReminder _stock = new();
    readonly IObservable<GoodsReminder> _observable;

    public Buyer(IObservable<GoodsReminder> observable)
    {
      observable.Register(this);
      _observable = observable;
    }

    public void Update(GoodsReminder value)
    {
      foreach (var entry in value)
      {
        if (_stock.TryGetValue(entry.Key, out int amount) &&
          amount < 1 && entry.Value > 0)
        {
          Console.WriteLine($"[Buyer] They just shipped {entry.Key}, time to go shopping.");
        }
      }

      _stock = value;
    }

    public void Leave()
    {
      Console.WriteLine($"[Buyer] I'm not shopping here anymore.");
      _observable.Unregister(this);
    }
  }
}