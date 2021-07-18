using System;

namespace DesignPatterns.Singleton
{
  class Program
  {
    static void Main()
    {
      var instanceRef1 = Singleton.Instance;
      instanceRef1.Title = "Ref1 title";
      var instanceRef2 = Singleton.Instance;

      Console.WriteLine(
        $"{nameof(instanceRef1)}.{nameof(instanceRef1.Title)}: {instanceRef2.Title}");
      Console.WriteLine(
        $"{nameof(instanceRef2)}.{nameof(instanceRef2.Title)}: {instanceRef2.Title}");
      Console.WriteLine(
        $"{nameof(instanceRef1)} is references the same object as {nameof(instanceRef2)}" +
        $": {instanceRef1 == instanceRef2}");
    }
  }
}