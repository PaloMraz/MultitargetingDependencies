using System;

namespace LibA
{
  public class LibAService
  {
    public string SayHello() => $"Hello from {this.GetType().Assembly.FullName}";
  }
}
