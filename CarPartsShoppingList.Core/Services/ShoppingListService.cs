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
        
        public async Task<bool> Add(ShoppingListItemViewModel model)
        {
            try
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
                     TransmisionId = model.Transmision,
                 });

                await this.repo.AddAsync(shoppingList);
                await this.repo.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw new ArgumentException("Cant add it");
            }
        }

        public ShoppingListViewModel GetShoppingList(int id)
        {
            return repo.AllReadonly<ShoppingList>()
                .Include(x => x.ShoppingListItems)
                .Where(x => x.Id == id)
                .Select(x => new ShoppingListViewModel()
                {
                    Id = x.Id,
                    ShoppingListName = x.Name,
                    ShoppingListItems = x.ShoppingListItems
                })
                .FirstOrDefault();
        }

        public ShoppingListItemViewModel GetShoppingListItemById(int id)
        {
            return repo.AllReadonly<ShoppingListItem>()
                .Where(x => x.Id == id)
                .Select(x => new ShoppingListItemViewModel()
                {
                    itemId = x.Id,
                    ShoppingListName = x.Name,
                    IsPurchased = x.IsChecked,
                })
                .FirstOrDefault();
        }

        public List<ShoppingListItemReviewViewModel> GetShoppingListItems(int shoppingListId)
        {
            var Engines = repo.AllReadonly<ShoppingListItem>()
                .Include(x => x.Engine)
                .Where(x => x.ShoppingListId == shoppingListId)
                .Select(x => new ShoppingListItemReviewViewModel()
                {
                    Id = x.Id,
                    ProductName = x.Engine.Name,
                    Price = x.Engine.Price,
                    Code = x.Engine.Code,
                    IsPurchased = x.IsChecked,
                });

            var Suspensions = repo.AllReadonly<ShoppingListItem>()
                  .Include(x => x.Suspension)
                  .Where(x => x.ShoppingListId == shoppingListId)
                  .Select(x => new ShoppingListItemReviewViewModel()
                  {
                      Id = x.Id,
                      ProductName = x.Suspension.Name,
                      Price = x.Suspension.Price,
                      Code = x.Suspension.Code,
                      IsPurchased = x.IsChecked,
                  });

            var Transmisions = repo.AllReadonly<ShoppingListItem>()
                .Include(x => x.Transmision)
                .Where(x => x.ShoppingListId == shoppingListId)
                .Select(x => new ShoppingListItemReviewViewModel()
                {
                    Id = x.Id,
                    ProductName = x.Transmision.Name,
                    Price = x.Transmision.Price,
                    Code = x.Transmision.Code,
                    IsPurchased = x.IsChecked,
                });

            var list = new List<ShoppingListItemReviewViewModel>();
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

        public async Task<bool> SaveData(ShoppingListItemViewModel model)
        {
            try
            {
                var item = repo.All<ShoppingListItem>()
                    .Include(x => x.ShoppingList)
                    .FirstOrDefault(x => x.Id == model.itemId);
                
                item.EngineId = model.Engine;
                item.SuspensionId = model.Suspension;
                item.TransmisionId = model.Transmision;
                item.ShoppingList.Name = model.ShoppingListName;

                repo.Update(item);

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