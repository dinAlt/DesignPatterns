# Decorator pattern

The decorator pattern allows to modify or change behavior of object with wrapping it
by another one. The wrapper object itself is transparent for user. This is gained
by having same parent class with wrapped object or implementation of the same interface.

Decorator is often used in IO libraries of various programming languages like `C#`, `Go`,
`Java` and others, because it well suited for designing stream processing and data pipelines.

E.g, C#'s `System.IO.Compression.GZipStream` and `System.IO.FileStream` both have `System.IO.Stream` as an ancestor. Also, `GZipStream` has parameter of type `Stream` in all its
constructors, so we can't create `GZipStream` without having another `Stream` object to wrap
(decorate). And so, we can extract contents of gzip archive by creating new `FileStream` and
passing it to `GZipStream` constructor, and, finally, read from newly created object using
`Stream.Read` method.

In this sample, decorator is used for logging payment operations.

Sample content:
- `IPaymentMethod`  - interface implemented by payment methods and logger
- `Checkout` - class, which uses `IPaymentMethod` implementations to handle payments
- `CardPaymentMethod` and `CashPaymentMethod` - payment method classes
  (`IPaymentMethod` implementations)
- `PaymentMethodLogger` - the actual decorator class, which implements `IPaymentMethod`
  and wraps any other `IPaymentMethod` implementation

See usage example in `Program.cs`.