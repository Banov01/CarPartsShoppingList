using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IShoppingListService
    {
        public IQueryable<ShoppingListViewModel> GetShoppingLists();

        public IQueryable<ShoppingListItemViewModel> GetShoppingListItems(int shoppingListId);

        Task<bool> SaveData(ShoppingListViewModel model);

        ShoppingListViewModel GetShoppingList(int id);
        ShoppingListItemViewModel GetShoppingListItemById(int id);
    }
}
