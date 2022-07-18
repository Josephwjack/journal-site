using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Template() 
    // {
    //   MadLibsVariable myMadLibVariable = new MadLibsVariable();
    //   myMadLibVariable.Person1 = "Lina";
    //   myMadLibVariable.Person2 = "Jasmine";
    //   myMadLibVariable.Animal = "pig";
    //   myMadLibVariable.Exclamation = "Yay!";
    //   myMadLibVariable.Verb = "ran";
    //   myMadLibVariable.Food = "beans";
    //   return View(myMadLibVariable);  

    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string person1, string person2, string animal, string exclamation, string verb, string food)
    {
      MadLibsVariable myMadLibVariable = new MadLibsVariable();
      myMadLibVariable.Person1 = person1;
      myMadLibVariable.Person2 = person2;
      myMadLibVariable.Animal = animal;
      myMadLibVariable.Exclamation = exclamation;
      myMadLibVariable.Verb = verb;
      myMadLibVariable.Food = food;

      return View(myMadLibVariable);
    }
  }
}