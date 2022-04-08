using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using System.Web.Mvc;

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
                    Text = x.Id.ToString(),
                    Value = x.Name,
                })
                .ToList();
        }
    }
}
