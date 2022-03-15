using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ISuspensionService
    {
        public IQueryable<SuspensionViewModel> GetSuspensions();

        bool SaveData(SuspensionViewModel model);

        SuspensionViewModel GetSuspensionModel(int id);
    }
}
