using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarPartsShoppingList.Core.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly IRepository repo;
        public ShoppingListService(IRepository _repo)
        {
            repo = _repo;
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
            return repo.All<ShoppingListItem>()
                .Where(x => x.Id == id)
                .Select(x => new ShoppingListItemViewModel()
                {
                    Id = x.Id,
                    ShoppingListItemName = x.Name,
                    IsPurchased = x.IsChecked,
                    ShoppingListItemPrice = x.Price
                })
                .FirstOrDefault();
        }

        public IQueryable<ShoppingListItemViewModel> GetShoppingListItems(int shoppingListId)
        {
            return repo.AllReadonly<ShoppingListItem>()
                .Include(x => x.Transmission)
                .Include(x => x.Engine)
                .Include(x => x.Suspension)
                .Where(x => x.ShoppingListId == shoppingListId)
                .Select(x => new ShoppingListItemViewModel()
                {
                    Id = x.Id,
                    ShoppingListItemName = x.Name,
                    ShoppingListItemPrice = x.Price,
                    IsPurchased = x.IsChecked,
                });
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
            catch (Exception ex)
            {
                //log error
                return false;
            }
        }
    }
}
