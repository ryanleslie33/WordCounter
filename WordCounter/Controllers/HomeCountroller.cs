using Microsoft.AspNetCore.Mvc;

namespace WordCountName.Controllers
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
