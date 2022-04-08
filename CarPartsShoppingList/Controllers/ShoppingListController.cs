using CarPartsShoppingList.Core.Constants;
using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService shoppingListService;
        private readonly IEngineService engineService;
        private readonly ITransmisionService transmisionService;
        private readonly ISuspensionService suspensionService;

        public ShoppingListController(IShoppingListService shoppingListService, IEngineService engineService, ITransmisionService transmisionService,
            ISuspensionService suspensionService)
        {
            this.shoppingListService = shoppingListService;
            this.engineService = engineService;
            this.transmisionService = transmisionService;
            this.suspensionService = suspensionService;
        }

        public IActionResult ShoppingList()
        {
            var model = new List<ShoppingListViewModel>();
            return View(model);
        }

        public IActionResult ShoppingListItem(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingListData()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var listItems = this.shoppingListService.GetShoppingLists();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShoppingListItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.shoppingListService.Add(model);

            return this.RedirectToAction("ShoppingList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = shoppingListService.GetShoppingList(id);

            return View(nameof(Edit), model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ShoppingListViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await shoppingListService.SaveData(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = MessageConstant.SaveOK;
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = MessageConstant.SaveFailed;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Check(int id)
        {
            var shoppingListItem = shoppingListService.GetShoppingListItemById(id);

            return View();
        }

        public void GetViewBags()
        {
            ViewBag.EngineList = engineService.GetDropDownList<Engine>();
            ViewBag.SuspensionList = suspensionService.GetDropDownList<Suspension>();
            ViewBag.TransmisionList = transmisionService.GetDropDownList<Transmision>();
        }
    }
}
