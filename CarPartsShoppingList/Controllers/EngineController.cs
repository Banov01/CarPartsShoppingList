using CarPartsShoppingList.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class EngineController : Controller
    {
        private IEngineService engineService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
