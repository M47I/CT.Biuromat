using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CT.Biuromat.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class DashboardController : Controller
    {
        [HttpGet] // [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}