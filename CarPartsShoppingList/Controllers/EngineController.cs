using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class EngineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
