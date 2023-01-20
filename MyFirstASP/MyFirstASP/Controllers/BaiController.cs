using Microsoft.AspNetCore.Mvc;

namespace MyFirstASP.Controllers
{
    public class BaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
