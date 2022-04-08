using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ISuspensionService : IBaseInterface
    {
        IQueryable<SuspensionViewModel> GetSuspensions();

        Task<bool> SaveData(SuspensionViewModel model);
        SuspensionViewModel GetSuspensionModel(int id);
    }
}
