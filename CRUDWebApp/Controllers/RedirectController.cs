using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApp.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RedirectToSwagger()
        {
            return Redirect("/swagger/index.html");
        }
    }
}