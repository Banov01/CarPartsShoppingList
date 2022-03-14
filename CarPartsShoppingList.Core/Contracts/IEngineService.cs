using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface IEngineService
    {
        public IQueryable<EngineViewModel> GetEngines();

        bool SaveData(EngineViewModel model);

        EngineViewModel GetEngineModel(int id);
    }
}
