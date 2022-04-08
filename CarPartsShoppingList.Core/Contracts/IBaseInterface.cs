using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IBaseInterface
    {
        public List<SelectListItem> GetDropDownList<T>() where T : BaseModel;
    }
}
