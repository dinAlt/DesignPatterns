namespace DesignPatterns.Patterns.Strategy
{
  internal class NoopSender : ISender
  {
    public void Send(string customerName)
    {
    }
  }
}