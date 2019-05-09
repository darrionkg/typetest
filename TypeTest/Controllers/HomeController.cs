using Microsoft.AspNetCore.Mvc;

namespace TypingSpeed.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
