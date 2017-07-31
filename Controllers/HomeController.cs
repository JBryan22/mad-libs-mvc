using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/results")]
        public ActionResult Results()
        {
            WordVariables myWordVariables = new WordVariables();
            myWordVariables.SetNoun(Request.Query["noun"]);
            myWordVariables.SetVerb(Request.Query["verb"]);
            myWordVariables.SetAdjective(Request.Query["adjective"]);
            myWordVariables.SetPronoun(Request.Query["pronoun"]);

            return View("index", myWordVariables);
        }

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }
    }
}
