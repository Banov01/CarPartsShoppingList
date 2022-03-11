using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class TransmisionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
