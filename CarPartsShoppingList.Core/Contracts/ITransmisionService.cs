using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ITransmisionService
    {
        public IQueryable<TransmisionViewModel> GetTransmisions();

        Task<bool> SaveData(TransmisionViewModel model);
        TransmisionViewModel GetTransmisionModel(int id);
    }
}
