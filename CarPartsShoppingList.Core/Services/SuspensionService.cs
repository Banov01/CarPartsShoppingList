using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface SuspensionService
    {
        public IQueryable<SuspensionViewModel> GetSuspensions();

        bool SaveData(SuspensionViewModel model);

        SuspensionViewModel GetSuspensionModel(int id);
    }
}
