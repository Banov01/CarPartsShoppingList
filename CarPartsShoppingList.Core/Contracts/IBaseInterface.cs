using CarPartsShoppingList.Infrastructure.Data.Models;
using System.Web.Mvc;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IBaseInterface
    {
        public List<SelectListItem> GetDropDownList<T>() where T : BaseModel;
    }
}
