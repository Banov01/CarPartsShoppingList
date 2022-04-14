using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ITransmisionService : IBaseInterface
    {
        IQueryable<TransmisionViewModel> GetTransmisions();
        Task<bool> SaveData(TransmisionViewModel model);
        TransmisionViewModel GetTransmisionModel(int id);
    }
}
