namespace DesignPatterns.Decorator
{
  class CachePaymentMethod : IPaymentMethod
  {
    public string Name => "Cache";
  }
}