using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IEngineService
    {
        public IQueryable<EngineViewModel> GetEngines();

        bool SaveData(EngineViewModel model);

        EngineViewModel GetEngineModel(int id);
    }
}
