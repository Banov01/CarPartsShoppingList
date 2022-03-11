using CarPartsShoppingList.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    public class EngineController : Controller
    {
        private EngineService engineService;
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
