using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int itemId { get; set; }

        [Required]
        [DisplayName("Shopping list name")]
        [StringLength(25)]
        public string ShoppingListName { get; set; }

        public string ApplicationUserId { get; set; }

        [DisplayName("Suspension")]
        public int? Suspension { get; set; }

        [DisplayName("Transmision")]
        public int? Transmision { get; set; }

        [DisplayName("Engine")]
        public int? Engine { get; set; }

        [DisplayName("Purchased")]
        public bool IsPurchased { get; set; }

    }
}