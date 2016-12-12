using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthProject2.Controllers
{
    public class ReactHomeController : Controller
    {
        // GET: /<controller>/
        [ValidateAntiForgeryToken]
        public IActionResult Index()
        {
            return View();
        }
    }
}
