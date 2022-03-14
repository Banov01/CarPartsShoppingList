using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface ISuspensionService
    {
        public IQueryable<SuspensionViewModel> GetSuspensions();

        bool SaveData(SuspensionViewModel model);

        SuspensionViewModel GetSuspensionModel(int id);
    }
}
