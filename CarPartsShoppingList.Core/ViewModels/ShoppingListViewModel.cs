using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListViewModel
    {
        public int Id { get; set; }

        [DisplayName("Име на списък за пазаруване")]
        public string ShoppingListName { get; set; }

        [DisplayName("Списък с продукти")]
        public List<int> Products { get; set; }
    }
}
