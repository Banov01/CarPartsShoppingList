using CarPartsShoppingList.Core.Constants;
using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Identity;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService shoppingListService;
        private readonly IEngineService engineService;
        private readonly ITransmisionService transmisionService;
        private readonly ISuspensionService suspensionService;
        private readonly UserManager<ApplicationUser> userManager;

        public ShoppingListController(IShoppingListService shoppingListService, IEngineService engineService, ITransmisionService transmisionService,
            ISuspensionService suspensionService, UserManager<ApplicationUser> userManager)
        {
            this.shoppingListService = shoppingListService;
            this.engineService = engineService;
            this.transmisionService = transmisionService;
            this.suspensionService = suspensionService;
            this.userManager = userManager;
        }

        public IActionResult ShoppingList()
        {
            var model = new List<ShoppingListViewModel>();
            var tableViewModel = shoppingListService.GetShoppingLists().ToList();

            return View(tableViewModel);
        }

        public IActionResult ShoppingListItem(int id)
        {
            ViewBag.Id = id;
            var model = new List<ShoppingListItemViewModel>();
            var tableViewModel = shoppingListService.GetShoppingListItems(id);

            return View(tableViewModel);
        }

        [HttpPost]
        public IActionResult ShoppingListData()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetViewBags();
            var shoppingListItem = new ShoppingListItemViewModel()
            {
                ApplicationUserId = userManager.GetUserId(User)
            };
            var listItems = this.shoppingListService.GetShoppingLists();
            shoppingListItem.IsPurchased = false;
            return View(shoppingListItem);
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
            GetViewBags();
            var model = shoppingListService.GetShoppingList(id);

            var shoppingListItem = new ShoppingListItemViewModel()
            {

            };
            return View(nameof(Add), model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ShoppingListViewModel model)
        {
            GetViewBags();

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
