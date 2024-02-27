using Microsoft.AspNetCore.Mvc;

namespace MuratoriFortissimi.Controllers
{
    public class PagamentiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisualizzaPagamenti()
        {
            return View();
        }
    }
}
