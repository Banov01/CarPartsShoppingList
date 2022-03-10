using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListViewModel
    {
        public int Id { get; set; }

        [DisplayName("Shopping list name")]
        public string Name { get; set; }

        [DisplayName("List of products")]
        public List<int> Products { get; set; }
    }
}
