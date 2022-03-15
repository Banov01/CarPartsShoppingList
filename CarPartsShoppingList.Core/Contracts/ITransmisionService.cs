using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface ITransmisionService
    {
        public IQueryable<TransmissionViewModel> GetTransmisions();

        bool SaveData(TransmissionViewModel model);

        TransmissionViewModel GetTransmisionModel(int id);
    }
}
