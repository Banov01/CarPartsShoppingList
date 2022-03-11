using CarPartsShoppingList.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface TransmisionService
    {
        public IQueryable<TransmissionViewModel> GetTransmisions();

        bool SaveData(TransmissionViewModel model);

        TransmissionViewModel GetTransmisionModel(int id);
    }
}
