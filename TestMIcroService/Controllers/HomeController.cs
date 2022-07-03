using Microsoft.AspNetCore.Mvc;

namespace TestMIcroService.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// simple summary
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
