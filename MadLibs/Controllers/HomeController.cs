using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController: Controller
  {
    [Route("/hello")]
    public string Hello()
    {
      return "Hi there.";
    }

    [Route("/goodbye")]
    public string Goodbye()
    {
      return "Goodbye.";
    }

    [Route("/")]
    public string Letter()
    {
      return "MadLibs splash page here.";
    }
  }
}