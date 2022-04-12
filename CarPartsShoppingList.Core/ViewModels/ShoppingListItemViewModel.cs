using CarPartsShoppingList.Infrastructure.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Shopping list name")]
        [StringLength(15)]
        public string ShoppingListName { get; set; }

        [DisplayName("ProductName")]
        public string ProductName { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        public string ApplicationUserId { get; set; }

        [DisplayName("Suspension")]
        public List<int> Suspension { get; set; }

        [DisplayName("Transmision")]
        public List<int> Transmision { get; set; }

        [DisplayName("Engine")]
        public List<int> Engine { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Purchased")]
        public bool IsPurchased { get; set; }

    }
}
