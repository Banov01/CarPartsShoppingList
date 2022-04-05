using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class SuspensionController : Controller
    {
        private readonly ISuspensionService suspensionService;

        public SuspensionController(ISuspensionService suspensionService)
        {
            this.suspensionService = suspensionService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddSuspension()
        {
            var viewModel = new SuspensionViewModel();

            return View("Edit", viewModel);
        }

        public IActionResult EditSuspension(int id)
        {
            var model = suspensionService.GetSuspensionModel(id);

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SuspensionViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var result = await suspensionService.SaveData(viewModel);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Suspension");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSuspension(int id)
        {
            var result = await suspensionService.DeleteSuspension(id);

            this.ShowNotificationMessageOnUI(result);

            return RedirectToAction("Index", "Suspension");
        }
    }
}
