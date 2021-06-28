# Observer pattern

Observer pattern specifies how multiple objects (observers) may watch for state changes of some other object (observable).

This pattern is usually implemented using two interfaces: `Observable` and `Observer`. `Observable` interface should at least provide method for `Observer` subscription, as well as a way to unsubscribe. `Observer` should provide one or several methods which will be called when `Observable` state changes. New state can be passed through observers update method, or pulled
directly from observable using access properties or methods.

Although, .Net [has](https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern) built in observer support through [IObserver<T>](https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1) and [IObservable<T>](https://docs.microsoft.com/en-us/dotnet/api/system.iobservable-1) interfaces, this sample uses its own interfaces to simplify code as much as possible.

Sample content:
- `IObservable` and `IObserver` interfaces
- `Shop` class as `IObservable` implementation
- `Buyer` and `Shipper` classes as IObserver implementations

See usage example in `Program.cs`.