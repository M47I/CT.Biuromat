using CT.Biuromat.Web.Areas.Administration.Services;
using Microsoft.AspNetCore.Mvc;

namespace CT.Biuromat.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class RoomsController : Controller
    {
        private readonly IRoomsService _roomsService;
        
        public RoomsController(IRoomsService roomsService)
        {
            _roomsService = roomsService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Remove()
        {
            return View();
        }
    }
}