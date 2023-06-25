using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController: Controller
  {
    [Route("/")]
    public ActionResult SplashPage()
    {
      return View();
    }

    [Route("/letter")]
    public ActionResult MadLibsLetter()
    {
      InputForLetter userInputWords = new InputForLetter();
      userInputWords.Recipient = "Homer";
      return View(userInputWords);
    }

    [Route("/hello")]
    public string Hello()
    {
      return "Hi there.";
    }
  }
}