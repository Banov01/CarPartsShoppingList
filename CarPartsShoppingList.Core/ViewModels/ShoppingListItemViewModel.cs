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
        public string ShoppingListName { get; set; }

        [DisplayName("Suspension")]
        public string Suspension { get; set; }

        [DisplayName("Transmision")]
        public string Transmision { get; set; }

        [DisplayName("Engine")]
        public string Engine { get; set; }

        [DisplayName("Purchased")]
        public bool IsPurchased { get; set; }

    }
}
