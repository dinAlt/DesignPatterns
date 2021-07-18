using System;

namespace DesignPatterns.Singleton
{
  public class Singleton
  {
    public static Singleton Instance
    {
      get
      {
        if (_instance is null)
        {
          lock (_instanceLock)
          {
            if (_instance is null)
            {
              _instance = new();
            }
          }
        }
        return _instance;
      }
    }

    public string Title { get; set; }

    private static Singleton _instance;
    private static readonly object _instanceLock = new();

    private Singleton()
    {
    }
  }
}
