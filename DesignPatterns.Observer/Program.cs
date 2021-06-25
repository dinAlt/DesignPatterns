using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
  class Program
  {
    static void Main()
    {
      var shop = new Shop(new Dictionary<string, int> {
        { "salt", 2 },
        { "sugar", 2 },
        { "flour", 2 },
      });

      var shipper = new Shipper(shop);
      var buyer = new Buyer(shop);

      shop.Sell("salt", 1);

      // Sugar goes out of stock here, shipper should respond.
      shop.Sell("sugar", 2);
      shop.Ship("flour", 1);

      // Sugar went on sale, buyer should respond.
      shop.Ship("sugar", 3);

      // Shipper unsubscribes and will no longer respond if the goods run out.
      shipper.Leave();
      shop.Sell("flour", 3);

      // Shipper unsubscribes and will no longer respond if the goods are back on sale.
      buyer.Leave();
      shop.Ship("flour", 1);
    }
  }
}
