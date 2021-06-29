namespace DesignPatterns.Decorator
{
  class CardPaymentMethod : IPaymentMethod
  {
    public string Name => "Card";
  }
}