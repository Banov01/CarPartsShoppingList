using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface EngineService
    {
        public IQueryable<EngineViewModel> GetEngines();

        bool SaveData(EngineViewModel model);

        EngineViewModel GetEngineModel(int id);
    }
}
