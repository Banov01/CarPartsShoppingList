using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPartsShoppingList.Core.Services
{
    public class ShoppingListService : BaseService, IShoppingListService
    {
        public ShoppingListService(IRepository _repo) : base(_repo)
        {
        }

        public async Task Add(ShoppingListItemViewModel model)
        {
            var shoppingList = new ShoppingList()
            {
                ApplicationUserId = model.ApplicationUserId,
                Name = model.ShoppingListName
            };

            shoppingList.ShoppingListItems.Add(
             new ShoppingListItem()
             {
                 EngineId = model.Engine,
                 SuspensionId = model.Suspension,
                 TransmissionId = model.Transmision,
             });

            await this.repo.AddAsync(shoppingList);
            await this.repo.SaveChangesAsync();
        }

        public ShoppingListViewModel GetShoppingList(int id)
        {
            return repo.All<ShoppingList>()
                .Where(x => x.Id == id)
                .Select(x => new ShoppingListViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name
                })
                .FirstOrDefault();
        }

        public ShoppingListItemViewModel GetShoppingListItemById(int id)
        {
            return repo.AllReadonly<ShoppingListItem>()
                .Where(x => x.Id == id)
                .Select(x => new ShoppingListItemViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name,
                    IsPurchased = x.IsChecked,

                })
                .FirstOrDefault();
        }

        public List<ShoppingListItemViewModel> GetShoppingListItems(int shoppingListId)
        {
            var Engines = repo.AllReadonly<ShoppingListItem>()
                .Include(x => x.Engine)
                .Where(x => x.ShoppingListId == shoppingListId)
                .Select(x => new ShoppingListItemViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name,
                    ProductName = x.Engine.Name,
                    Price = x.Engine.Price,
                    Code = x.Engine.Code,
                    IsPurchased = x.IsChecked,
                });

            var Suspensions = repo.AllReadonly<ShoppingListItem>()
                  .Include(x => x.Suspension)
                  .Where(x => x.ShoppingListId == shoppingListId)
                  .Select(x => new ShoppingListItemViewModel()
                  {
                      Id = x.Id,
                      ShoppingListName = x.Name,
                      ProductName = x.Suspension.Name,
                      Price = x.Suspension.Price,
                      Code = x.Suspension.Code,
                      IsPurchased = x.IsChecked,
                  });

            var Transmisions = repo.AllReadonly<ShoppingListItem>()
                .Include(x => x.Transmision)
                .Where(x => x.ShoppingListId == shoppingListId)
                .Select(x => new ShoppingListItemViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name,
                    ProductName = x.Transmision.Name,
                    Price = x.Transmision.Price,
                    Code = x.Transmision.Code,
                    IsPurchased = x.IsChecked,
                });

            var list = new List<ShoppingListItemViewModel>();
            list.AddRange(Engines);
            list.AddRange(Suspensions);
            list.AddRange(Transmisions);

            return list;
        }

        public IQueryable<ShoppingListViewModel> GetShoppingLists()
        {
            return repo.AllReadonly<ShoppingList>()
                .Select(x => new ShoppingListViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name,
                })
                .AsQueryable();
        }

        public async Task<bool> SaveData(ShoppingListViewModel model)
        {
            try
            {
                foreach (var item in model.ShoppingListItems)
                {
                    await repo.AddAsync(item);
                }
                repo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new ArgumentException("Cant save data");
            }
        }
    }
}