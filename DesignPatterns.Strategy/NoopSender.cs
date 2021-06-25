namespace DesignPatterns.Strategy
{
  internal class NoopSender : ISender
  {
    public void Send(string customerName)
    {
    }
  }
}