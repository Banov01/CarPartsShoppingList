using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;

namespace CarPartsShoppingList.Core.Services
{
    public class EngineService : IEngineService
    {
        private readonly IRepository repo;
        public EngineService(IRepository _repo)
        {
            repo = _repo;
        }

        public EngineViewModel GetEngineModel(int id)
        {
            var test = repo.AllReadonly<Engine>()
                .Where(x => x.Id == id)
                .Select(x => new EngineViewModel()
                {
                    Id = x.Id,
                    Cilinders = x.Cilinders,
                    Cubature = x.Cubature,
                    EngineName = x.Name,
                    EngineCode = x.Code,
                    EnginePrice = x.Price,
                    EngineCategory = x.EngineCategory,
                })
                .FirstOrDefault();

            if (test == null)
            {
                return new EngineViewModel();
            }
            return test;
        }

        public IQueryable<EngineViewModel> GetEngines()
        {
            return repo.AllReadonly<Engine>()
                 .Select(x => new EngineViewModel()
                 {
                     Id = x.Id,
                     Cilinders = x.Cilinders,
                     EngineCategory = x.EngineCategory,
                     Cubature = x.Cubature,
                     EngineCode = x.Code,
                     EngineName = x.Name,
                     EnginePrice = x.Price
                 })
                 .AsQueryable();
        }

        public async Task<bool> SaveData(EngineViewModel model)
        {
            bool result = false;
            Engine entity = null;

            try
            {
                if (model.Id > 0)
                {
                    entity = await repo.GetByIdAsync<Engine>(model.Id);

                    entity.Cilinders = model.Cilinders;
                    entity.Cubature = model.Cubature;
                    entity.EngineCategory = model.EngineCategory;
                    entity.Code = model.EngineCode;
                    entity.Name = model.EngineName;
                    entity.Price = model.EnginePrice;
                }

                else
                {
                    entity = new Engine();
                    {
                        
                        entity.Cilinders = model.Cilinders;
                        entity.Cubature = model.Cubature;
                        entity.EngineCategory = model.EngineCategory;
                        entity.Code = model.EngineCode;
                        entity.Name = model.EngineName;
                        entity.Price = model.EnginePrice;
                    };

                    await repo.AddAsync(entity);
                }
                repo.SaveChanges();
                result = true;
            }

            catch (Exception)
            {
                throw new ArgumentException("Cant save data");
            }
            return result;
        }
    }
}
