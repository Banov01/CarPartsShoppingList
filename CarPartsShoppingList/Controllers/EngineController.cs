using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using CarPartsShoppingList.Extensions;

namespace CarPartsShoppingList.Controllers
{
    public class EngineController : Controller
    {
        private readonly IEngineService engineService;

        public EngineController(IEngineService engineService)
        {
            this.engineService = engineService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEngine()
        {
            var viewModel = new EngineViewModel();

            return View("Edit", viewModel);
        }

        public IActionResult EditEngine(int id)
        {
            var model = engineService.GetEngineModel(id);

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EngineViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var result = await engineService.SaveData(viewModel);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Engine");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEngine(int id)
        {
            var result = await engineService.DeleteEngine(id);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Engine");
        }
    }
}
