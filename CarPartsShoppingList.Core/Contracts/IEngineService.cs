using CarPartsShoppingList.Core.ViewModels;
using System.Web.Mvc;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IEngineService : IBaseInterface
    {
        IQueryable<EngineViewModel> GetEngines();

        Task<bool> SaveData(EngineViewModel model);

        EngineViewModel GetEngineModel(int id);
    }
}
