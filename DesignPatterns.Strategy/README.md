# Strategy pattern

Strategy pattern groups algorithm variants by their objectives and encapsulates 
them into interchangeable entities (Behaviors).

In C# (and other OOP languages with interfaces support) it may be 
implemented as interface, which describes the behavior, number of classes,
implementing this interface and behavior holder class. 

Holder class should contain member of behavior interface type, methods, which
proxies to corresponding methods of the behavior and\or accessor, which allows
to change the behavior member in runtime.

Sample pattern implementation consists of:
- `Advertisement` class as behavior holder
- `ISender`  interface as send behavior definition
- `NoopSender`, `NewGoodsSender` and `DiscountsSender` classes as 
  send behavior implementations

See usage example in `Program.cs`.