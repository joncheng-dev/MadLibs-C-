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

    [Route("/letterform")]
    public ActionResult LetterForm()
    {
      return View();
    }

    [Route("/letterdisplay")]
    public ActionResult LetterDisplay(string recipient, string nameOfPlace, string topicToLearn, string nounSingular, string sender)
    {
      InputForLetter userInputWords = new InputForLetter();
      userInputWords.Recipient = recipient;
      userInputWords.NameOfPlace = nameOfPlace;
      userInputWords.TopicToLearn = topicToLearn;
      userInputWords.NounSingular = nounSingular;
      userInputWords.Sender = sender;
      return View(userInputWords);
    }

    [Route("/hallpassform")]
    public ActionResult HallPassForm()
    {
      return View();
    }

    [Route("/hallpassdisplay")]
    public ActionResult HallPassDisplay(string hallPassRecipient, string adjective, string noun)
    {
      InputForHallPass userInputWords = new InputForHallPass();
      userInputWords.HallPassRecipient = hallPassRecipient;
      userInputWords.Adjective = adjective;
      userInputWords.Noun = noun;
      return View(userInputWords);
    }

    [Route("/hello")]
    public string Hello()
    {
      return "Hi there.";
    }
  }
}