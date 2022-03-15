using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Repositories;

namespace CarPartsShoppingList.Core.Services
{
    public class EngineService : IEngineService
    {
        private readonly IApplicatioDbRepository repo;

        public EngineService (IApplicatioDbRepository _repo)
        {
            repo = _repo;
        }

        public EngineViewModel GetEngineModel(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EngineViewModel> GetEngines()
        {
            throw new NotImplementedException();
        }

        public bool SaveData(EngineViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
