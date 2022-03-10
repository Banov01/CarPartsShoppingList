using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int Id { get; set; }

        [DisplayName("Item Name")]
        public string Name { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        [DisplayName("Is Purcashed")]
        public bool IsActive { get; set; }

    }
}
