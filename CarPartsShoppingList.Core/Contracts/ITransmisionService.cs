using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ITransmisionService
    {
        public IQueryable<TransmisionViewModel> GetTransmisions();

        Task<bool> SaveData(TransmisionViewModel model);
        Task<bool> DeleteTransmision (int id);

        TransmisionViewModel GetTransmisionModel(int id);
    }
}
