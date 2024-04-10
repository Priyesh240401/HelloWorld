using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, world!");
        }
    }
}
