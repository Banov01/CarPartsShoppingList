using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly IShoppingListService shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            this.shoppingListService = shoppingListService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddShoppingList()
        {
            var viewModel = new ShoppingListViewModel();

            return View("Edit", viewModel);
        }

        public IActionResult EditShoppingList(int id)
        {
            var model = shoppingListService.GetShoppingList(id);

            return View("Edit", model);
        }
    }
}
