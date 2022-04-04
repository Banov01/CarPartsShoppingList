using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IEngineService
    {
        public IQueryable<EngineViewModel> GetEngines();

        Task<bool> SaveData(EngineViewModel model);
        Task<bool> DeleteEngine(int id);

        EngineViewModel GetEngineModel(int id);
    }
}
