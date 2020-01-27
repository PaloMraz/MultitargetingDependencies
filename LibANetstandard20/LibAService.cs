using System;

namespace LibANetstandard20
{
  public class LibAService
  {
    public string SayHello() => $"Hello from {this.GetType().Assembly.FullName}";
  }
}
