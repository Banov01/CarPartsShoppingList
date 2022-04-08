using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarPartsShoppingList.Core.Services
{
    public class BaseService : IBaseInterface
    {
        protected IRepository repo;
        public BaseService(IRepository repo)
        {
            this.repo = repo;
        }
        public List<SelectListItem> GetDropDownList<T>() where T : BaseModel
        {
            return repo.AllReadonly<T>()
                .Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                })
                .ToList();
        }
    }
}
