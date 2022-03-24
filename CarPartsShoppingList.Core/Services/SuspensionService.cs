using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;

namespace CarPartsShoppingList.Core.Services
{
    public class SuspensionService : ISuspensionService
    {
        private readonly IRepository repo;
        public SuspensionService(IRepository _repo)
        {
            repo = _repo;
        }

        public SuspensionViewModel GetSuspensionModel(int id)
        {
            return repo.All<Suspension>()
               .Where(x => x.Id == id)
               .Select(x => new SuspensionViewModel()
               {
                    Id = x.Id,
                    SuspensionName = x.Name,
                    SuspensionCode = x.Code,
                    SuspensionPrice = x.Price
               })
               .FirstOrDefault();
        }

        public IQueryable<SuspensionViewModel> GetSuspensions()
        {
            return repo.AllReadonly<Suspension>()
                 .Select(x => new SuspensionViewModel()
                 {
                     Id = x.Id,
                     SuspensionName = x.Name,
                     SuspensionCode = x.Code,
                     SuspensionPrice = x.Price
                 })
                 .AsQueryable();
        }

        public async Task<bool> SaveData(SuspensionViewModel model)
        {
            bool result = false;
            Suspension entity = null;

            try
            {
                if (model.Id > 0)
                {
                    entity = await repo.GetByIdAsync<Suspension>(model.Id);

                    entity.Name = model.SuspensionName;
                    entity.Price=model.SuspensionPrice;
                    entity.Code=model.SuspensionCode;
                }

                else
                {
                    entity = new Suspension();
                    {
                        entity.Name = model.SuspensionName;
                        entity.Price = model.SuspensionPrice;
                        entity.Code = model.SuspensionCode;
                    };

                   await repo.AddAsync(entity);
                }
                repo.SaveChanges();
                result = true;
            }

            catch (Exception ex)
            {
                //log error
            }
            return result;
        }
    }
}
