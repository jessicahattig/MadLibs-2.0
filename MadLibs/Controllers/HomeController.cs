using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    public string Hello() { return "Hello friend!"; }

        [Route("/")]
    // Notice the changes below!
    public ActionResult Story() { return View(); }

  }
}