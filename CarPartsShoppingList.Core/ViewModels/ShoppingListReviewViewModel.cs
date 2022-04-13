using System.ComponentModel;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListItemReviewViewModel
    {
        public int Id { get; set; }

        [DisplayName("ProductName")]
        public string ProductName { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Purchased")]
        public bool IsPurchased { get; set; }

    }
}
