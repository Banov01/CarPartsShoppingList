using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
