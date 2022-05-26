using Microsoft.AspNetCore.Mvc;

namespace Juan.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
