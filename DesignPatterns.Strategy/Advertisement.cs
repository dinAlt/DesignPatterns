using System;

namespace DesignPatterns.Strategy
{
  internal class Advertisement
  {
    public ISender Sender { private get; set; }

    public Advertisement() => Sender = new NoopSender();

    public void PerformSend(string customerName) => Sender.Send(customerName);
  }
}