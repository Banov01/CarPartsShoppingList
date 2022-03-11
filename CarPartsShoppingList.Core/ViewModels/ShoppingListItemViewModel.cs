using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int Id { get; set; }

        [DisplayName("Име на предмета")]
        public string ShoppingListItemName { get; set; }

        [DisplayName("Цена на предмета")]
        public decimal ShoppingListItemPrice { get; set; }

        [DisplayName("Закупен")]
        public bool IsPurchased { get; set; }

    }
}
