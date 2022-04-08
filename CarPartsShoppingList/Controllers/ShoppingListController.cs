using CarPartsShoppingList.Core.Constants;
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

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult ShoppingListItem(int id)
        //{
        //    ViewBag.Id = id;
        //    return View(id);
        //}

        //[HttpPost]
        //public IActionResult ShoppingListData()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Add()
        //{
        //    //GetViewBags();
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    GetViewBags();

        //    var model = shoppingListService.GetShoppingList(id);

        //    return View(nameof(Edit), model);
        //}

        //[HttpPost]
        //public IActionResult Edit(ShoppingListItemViewModel model)
        //{
        //    GetViewBags();

        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var result = shoppingListService.SaveData(model);

        //    if (result)
        //    {
        //        TempData[MessageConstant.SuccessMessage] = MessageConstant.SaveOK;
        //    }
        //    else
        //    {
        //        TempData[MessageConstant.ErrorMessage] = MessageConstant.SaveFailed;
        //    }

        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult Check(int id)
        //{
        //    var shoppingListItem = shoppingListService.GetShoppingListItemById(id);

        //    return View();
        //}

        //TODO DropDownList
        //private void GetViewBags()
        //{
        //    ViewBag.Products = GetDropDownList<Engine>();
        //}
    }
}
