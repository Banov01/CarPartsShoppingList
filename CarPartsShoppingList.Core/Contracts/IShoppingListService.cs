using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IShoppingListService : IBaseInterface
    {
        Task Add(ShoppingListItemViewModel model);

        IQueryable<ShoppingListViewModel> GetShoppingLists();

        IQueryable<ShoppingListItemViewModel> GetShoppingListItems(int shoppingListId);

        Task<bool> SaveData(ShoppingListViewModel model);

        ShoppingListViewModel GetShoppingList(int id);
        ShoppingListItemViewModel GetShoppingListItemById(int id);
    }
}
