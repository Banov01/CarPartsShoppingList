using CarPartsShoppingList.Core.Constants;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsShoppingList.Extensions
{
    public static class ControllerExtensions
    {
        public static void ShowNotificationMessageOnUI<T>(this T controller, bool result) where T : Controller
        {
            if (result)
            {
                controller.TempData[MessageConstant.SuccessMessage] = MessageConstant.SaveOK;
            }
            else
            {
                controller.TempData[MessageConstant.ErrorMessage] = MessageConstant.SaveFailed;
            }
        }
    }
}
