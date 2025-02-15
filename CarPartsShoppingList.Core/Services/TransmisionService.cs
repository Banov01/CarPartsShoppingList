﻿using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;

namespace CarPartsShoppingList.Core.Services
{
    public class TransmisionService : BaseService, ITransmisionService
    {
        public TransmisionService(IRepository _repo) : base(_repo)
        {
        }

        public TransmisionViewModel GetTransmisionModel(int id)
        {
            return repo.All<Transmision>()
               .Where(x => x.Id == id)
               .Select(x => new TransmisionViewModel()
               {
                   Id = x.Id,
                   TransmisionName = x.Name,
                   TransmisionCode = x.Code,
                   TransmisionPrice = x.Price
               })
               .FirstOrDefault();
        }

        public IQueryable<TransmisionViewModel> GetTransmisions()
        {
            return repo.AllReadonly<Transmision>()
                 .Select(x => new TransmisionViewModel()
                 {
                     Id = x.Id,
                     TransmisionName = x.Name,
                     TransmisionCode = x.Code,
                     TransmisionPrice = x.Price
                 })
                 .AsQueryable();
        }

        public async Task<bool> SaveData(TransmisionViewModel model)
        {
            bool result = false;
            Transmision entity = null;

            try
            {
                entity = await repo.GetByIdAsync<Transmision>(model.Id);
                if (entity != null)
                {
                    entity.Name = model.TransmisionName;
                    entity.Code = model.TransmisionCode;
                    entity.Price = model.TransmisionPrice;
                }

                else
                {
                    entity = new Transmision();
                    {
                        entity.Name = model.TransmisionName;
                        entity.Code = model.TransmisionCode;
                        entity.Price = model.TransmisionPrice;
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
