using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Име на предмета")]
        [StringLength(40)]
        public string ShoppingListItemName { get; set; }

        [DisplayName("Цена на предмета")]
        public decimal ShoppingListItemPrice { get; set; }

        [DisplayName("Закупен")]
        public bool IsPurchased { get; set; }

    }
}
