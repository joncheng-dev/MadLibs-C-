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

    [Route("/letterdisplay")]
    public ActionResult LetterDisplay(string recipient)
    {
      InputForLetter userInputWords = new InputForLetter();
      userInputWords.Recipient = recipient;
      return View(userInputWords);
    }

    [Route("/letterform")]
    public ActionResult LetterForm()
    {
      return View();
    }

    [Route("/hello")]
    public string Hello()
    {
      return "Hi there.";
    }
  }
}