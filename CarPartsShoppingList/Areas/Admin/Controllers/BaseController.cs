using CarPartsShoppingList.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Areas.Admin.Controllers
{
        [Authorize(Roles = UserConstant.Roles.Administrator)]
        [Area("Admin")]
        public class BaseController : Controller
        {

        }
}
