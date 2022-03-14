using CarPartsShoppingList.Core.ViewModels;

namespace CarPartsShoppingList.Core.Services
{
    public interface IShoppingListService
    {
        public IQueryable<ShoppingListViewModel> GetShoppingLists();

        public IQueryable<ShoppingListItemViewModel> GetShoppingListItems(int shoppingListId);

        bool SaveData(ShoppingListViewModel model);

        ShoppingListViewModel GetShoppingListModel(int id);
        ShoppingListItemViewModel GetShoppingListItem(int id);
    }
}
