using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
