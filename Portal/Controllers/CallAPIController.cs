using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class CallAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
