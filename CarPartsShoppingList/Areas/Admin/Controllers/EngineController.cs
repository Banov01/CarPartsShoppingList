using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Areas.Admin.Controllers
{
    public class EngineController : BaseController
    {
        private readonly IEngineService engineService;

        public EngineController(IEngineService engineService)
        {
            this.engineService = engineService;
        }

        public IActionResult Index()
        {
            var tableViewModel = engineService.GetEngines().ToList();

            return View(tableViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new EngineViewModel();

            return View("Edit", viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = engineService.GetEngineModel(id);

            return View(model);
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
