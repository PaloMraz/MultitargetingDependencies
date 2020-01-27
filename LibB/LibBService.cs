using LibA;
using System;

namespace LibB
{
  public class LibBService
  {
    private readonly LibAService _libAService;

    public LibBService()
    {
      this._libAService = new LibA.LibAService();
    }

    public string SayHello() => $"Hello from {this.GetType().Assembly.FullName} and also {this._libAService.SayHello()}";
  }
}
