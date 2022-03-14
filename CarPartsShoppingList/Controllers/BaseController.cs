using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}