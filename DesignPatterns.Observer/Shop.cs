using System;
using System.Collections.Generic;


namespace DesignPatterns.Observer
{
  using GoodsReminder = Dictionary<string, int>;

  class Shop : IObservable<GoodsReminder>
  {
    readonly GoodsReminder _stock;
    readonly List<IObserver<GoodsReminder>> _observers = new();

    public Shop(GoodsReminder stock) => _stock = stock;

    public void Register(IObserver<GoodsReminder> observer)
    {
      if (_observers.Contains(observer)) return;

      _observers.Add(observer);
      observer.Update(new GoodsReminder(_stock));
    }

    public void Unregister(IObserver<GoodsReminder> observer)
    {
      _observers.Remove(observer);
    }

    public void Sell(string good, int amount)
    {
      if (!_stock.ContainsKey(good))
      {
        throw new ArgumentException($"oops, we don't sell any {good}");
      }
      _stock[good] -= amount;
      Console.WriteLine(
        $"[Shop] New sale of {good}. Sale amount: {amount}, new reminder: {_stock[good]}.");
      NotifyObservers();
    }

    public void Ship(string good, int amount)
    {
      if (!_stock.ContainsKey(good))
      {
        throw new ArgumentException($"oops, we don't sell any {good}");
      }
      _stock[good] += amount;
      Console.WriteLine(
        $"[Shop] {good[..1].ToUpper() + good[1..]} was shipped. " +
        $"Shipped amount: {amount}, new reminder: {_stock[good]}.");
      NotifyObservers();
    }

    private void NotifyObservers()
    {
      foreach (var observer in _observers)
      {
        // Copying a whole stock dictionary for every observer should be very ineffective,
        // but it protects against external changes.
        observer.Update(new GoodsReminder(_stock));
      }
    }
  }
}