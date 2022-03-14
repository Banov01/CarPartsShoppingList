using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface ITransmisionService
    {
        public IQueryable<TransmissionViewModel> GetTransmisions();

        bool SaveData(TransmissionViewModel model);

        TransmissionViewModel GetTransmisionModel(int id);
    }
}
