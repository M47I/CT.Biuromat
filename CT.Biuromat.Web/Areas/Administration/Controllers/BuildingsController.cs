using CT.Biuromat.Web.Areas.Administration.Services;
using CT.Biuromat.Web.Areas.Administration.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CT.Biuromat.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class BuildingsController : Controller
    {
        private readonly IBuildingsService _buildingsService;
        
        public BuildingsController(IBuildingsService buildingsService)
        {
            _buildingsService = buildingsService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var model = _buildingsService.PrepareVmForIndex();
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new BuildingsCreateVm());
        }
        
        [HttpPost] 
        public IActionResult Create(BuildingsCreateVm model)
        {
            _buildingsService.AddToDatabase(model);
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _buildingsService.PrepareVmForDetails(id);
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _buildingsService.PrepareVmForEdit(id);
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Edit(BuildingsEditVm model)
        {
            _buildingsService.UpdateBuilding(model);
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult Remove(int id)
        {
            _buildingsService.DeleteBuilding(id);
            return RedirectToAction(nameof(Index));
        }
    }
}