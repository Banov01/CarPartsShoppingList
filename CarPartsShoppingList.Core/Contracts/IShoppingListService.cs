using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Contracts
{
    public interface IShoppingListService : IBaseInterface
    {
        Task<bool> Add(ShoppingListItemViewModel model);

        IQueryable<ShoppingListViewModel> GetShoppingLists();

        List<ShoppingListItemReviewViewModel> GetShoppingListItems(int shoppingListId);

        Task<bool> SaveData(ShoppingListItemViewModel model);

        ShoppingListViewModel GetShoppingList(int id);
        ShoppingListItemViewModel GetShoppingListItemById(int id);
    }
}
