using CarPartsShoppingList.Infrastructure.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPartsShoppingList.Core.ViewModels
{
    public class ShoppingListViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Име на списък за пазаруване")]
        [StringLength(40)]
        public string ShoppingListName { get; set; }

        [DisplayName("Списък с продукти")]
        public List<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
