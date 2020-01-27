using System;

namespace LibB
{
  public class LibBService
  {
    private readonly LibA.LibAService _libAService;
    private readonly LibANetstandard20.LibAService _libANetstandard20Service;

    public LibBService()
    {
      this._libAService = new LibA.LibAService();
      this._libANetstandard20Service = new LibANetstandard20.LibAService();
    }

    public string SayHello() => 
      $"Hello from {this.GetType().Assembly.FullName} and also " + 
      $"{this._libAService.SayHello()} and also " +
      $"{this._libANetstandard20Service.SayHello()}";
  }
}
