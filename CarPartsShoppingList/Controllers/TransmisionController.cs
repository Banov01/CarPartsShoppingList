using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class TransmisionController : Controller
    {
        private readonly ITransmisionService transmisionService;

        public TransmisionController(ITransmisionService transmisionService)
        {
            this.transmisionService = transmisionService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddTransmision()
        {
            var viewModel = new TransmisionViewModel();

            return View("Edit", viewModel);
        }
        public IActionResult EditTransmision(int id)
        {
            var model = transmisionService.GetTransmisionModel(id);

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TransmisionViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var result = await transmisionService.SaveData(viewModel);

            //TODO show notific ui
            return RedirectToAction("Index", "Engine");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTransmision(int id)
        {
            var result = await transmisionService.DeleteTransmision(id);

            //TODO show notific ui
            return RedirectToAction("Index", "Engine");
        }
    }
}
