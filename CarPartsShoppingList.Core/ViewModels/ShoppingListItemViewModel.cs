using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Item name")]
        [StringLength(15)]
        public string ShoppingListItemName { get; set; }

        [DisplayName("Item price")]
        public decimal ShoppingListItemPrice { get; set; }

        [DisplayName("Purchased")]
        public bool IsPurchased { get; set; }

    }
}
