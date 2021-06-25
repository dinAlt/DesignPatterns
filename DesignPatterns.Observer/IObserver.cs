namespace DesignPatterns.Observer
{
  interface IObserver<T>
  {
    void Update(T value);
  }
}